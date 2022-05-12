using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confectionery.Models;
using Confectionery.Utils;

namespace Confectionery.Core
{
    class Store
    {
        private ulong _productIDCounter = 0;
        private ulong _customerIDCounter = 0;
        private ulong _orderIDCounter = 0;

        private Dictionary<ulong, Product> _products = new Dictionary<ulong, Product>();
        private Dictionary<ulong, Customer> _customers = new Dictionary<ulong, Customer>();
        private Dictionary<ulong, Order> _orders = new Dictionary<ulong, Order>();

        private SaveManager _saveManager = new SaveManager();

        public event EventHandler<ErrorEventArgs> Error;
        public event EventHandler OrderCreated;

        public Store()
        {
            _saveManager.Load(out _products, out _customers, out _orders,
                out _productIDCounter, out _customerIDCounter, out _orderIDCounter);
        }

        public bool Save()
        {
            try
            {
                _saveManager.Save(_products, _customers);
                return true;
            } catch
            {
                Error?.Invoke(this, new ErrorEventArgs("Ошибка при сохранении данных"));
                return false;
            }
        }

        #region Products

        public IEnumerable<Product> FindProducts(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return _products.Values;
            }
            return _products.Values.Where(p =>
            {
                var searcher = new Searcher(search);
                return searcher.MatchString(p.Name) || searcher.MatchString(p.Quantity.ToString());
            });
        }

        public List<ProductTableItem> GetProductsTable(string search = "")
        {
            var found = FindProducts(search);
            return found.Select(p => new ProductTableItem(p)).ToList();
        }

        public Product GetProduct(ulong id)
        {
            return _products.TryGetValue(id, out Product p) ? p : null;
        }

        public bool HandleProductEvent(ProductEventArgs e)
        {
            switch (e.EventType)
            {
                case ProductEventType.Create:
                    var exists = _products.FirstOrDefault(kv => kv.Value.Name == e.Name).Key != 0;
                    if (exists)
                    {
                        Error?.Invoke(this,
                            new ErrorEventArgs("Продукт с таким названием уже существует"));
                        return false;
                    }
                    var created = new Product(++_productIDCounter, e.Name, e.Contents, e.Price,
                            e.Quantity, e.ExpiryDate);
                    _products.Add(_productIDCounter, created);
                    return true;
                case ProductEventType.Update:
                    if (!_products.ContainsKey(e.ID))
                    {
                        Error?.Invoke(this, new ErrorEventArgs("Такого продукта не существует"));
                        return false;
                    }
                    _products[e.ID].Contents = e.Contents;
                    _products[e.ID].Price = e.Price;
                    _products[e.ID].Quantity = e.Quantity;
                    return true;
                default:
                    throw new ArgumentException($"Неизвестный тип события: {e.EventType}");
            }
        }

        public bool DeleteProduct(ulong id)
        {
            if (!_products.ContainsKey(id))
            {
                Error?.Invoke(this, new ErrorEventArgs("Такого продукта не существует"));
                return false;
            }
            var isOrdered = _orders.FirstOrDefault(
                        kv => kv.Value.OrderProducts.Exists(p => p.Product.ID == id)).Key != 0;
            if (isOrdered)
            {
                Error?.Invoke(this, new ErrorEventArgs("Есть заказы на этот продукт"));
                return false;
            }
            _products.Remove(id);
            return true;
        }

        #endregion

        #region Customers

        public IEnumerable<Customer> FindCustomers(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return _customers.Values;
            } 
            return _customers.Values.Where(c =>
            {
                var searcher = new Searcher(search);
                return searcher.MatchString(c.FirstName) ||
                    searcher.MatchString(c.LastName) ||
                    searcher.MatchString(c.MiddleName) ||
                    searcher.MatchString(c.Email);
            });
        }

        public IList<CustomerTableItem> GetCustomersTable(string search = "")
        {
            var found = FindCustomers(search);
            return found.Select(c => new CustomerTableItem(c)).ToList();
        }

        public Customer GetCustomer(ulong id)
        {
            return _customers.TryGetValue(id, out Customer c) ? c : null;
        }

        public bool HandleCustomerEvent(CustomerEventArgs e)
        {
            switch (e.EventType)
            {
                case CustomerEventType.Create:
                    var exists = _customers.FirstOrDefault(kv => kv.Value.Email == e.Email).Key != 0;
                    if (exists)
                    {
                        Error?.Invoke(this, new ErrorEventArgs("Заказчик с такой почтой уже существует"));
                        return false;
                    }
                    var created = new Customer(++_customerIDCounter, e.FirstName,
                        e.LastName, e.MiddleName, e.Email);
                    _customers.Add(_customerIDCounter, created);
                    return true;
                case CustomerEventType.Update:
                    if (!_customers.ContainsKey(e.ID))
                    {
                        Error?.Invoke(this, new ErrorEventArgs("Такого заказчика не существует"));
                        return false;
                    }
                    _customers[e.ID].FirstName = e.FirstName;
                    _customers[e.ID].LastName = e.LastName;
                    _customers[e.ID].MiddleName = e.MiddleName;
                    _customers[e.ID].Email = e.Email;
                    return true;
                default:
                    throw new ArgumentException($"Неизвестный тип события: {e.EventType}");
            }
        }

        public bool DeleteCustomer(ulong id)
        {
            if (!_customers.ContainsKey(id))
            {
                Error?.Invoke(this, new ErrorEventArgs("Такого заказчика не существует"));
                return false;
            }
            var hasOrders = _customers[id].Orders.Count > 0;
            if (hasOrders)
            {
                Error?.Invoke(this,
                            new ErrorEventArgs("У этого заказчика есть не доставленные заказы"));
                return false;
            }
            _customers.Remove(id);
            return true;
        }
        #endregion

        #region Orders

        private IEnumerable<Order> FindOrders(string search, OrderStatus status)
        {
            var values = _orders.Values.Where(o => o.Status == status);
            if (string.IsNullOrEmpty(search))
            {
                return values;
            }
            return values.Where(o =>
            {
                var searcher = new Searcher(search);
                return searcher.MatchString(o.ID.ToString()) ||
                    searcher.MatchString(_customers[o.CustomerID].Email);
            });
        }

        public IList<OrderTableItem> GetOrdersTable(string search = "", OrderStatus status = OrderStatus.Created)
        {
            var found = FindOrders(search, status);
            return found.Select(o => new OrderTableItem(o, _customers[o.CustomerID])).ToList();
        }

        public Order GetOrder(ulong id)
        {
            return _orders.TryGetValue(id, out Order o) ? o : null;
        }

        public bool CreateOrder(ulong customerID, List<OrderProduct> orderProducts,
            DateTime deliveryDate, string deliveryAddress)
        {
            if (!_customers.ContainsKey(customerID))
            {
                Error?.Invoke(this, new ErrorEventArgs("Указанного заказчика не существует"));
                return false;
            }
            foreach (var op in orderProducts)
            {
                if (!_products.ContainsKey(op.Product.ID))
                {
                    Error?.Invoke(this, new ErrorEventArgs($"Продукта \"{op.Product.Name}\" не существует"));
                    return false;
                }
                var p = _products[op.Product.ID];
                if (p.Quantity < op.Count)
                {
                    Error?.Invoke(this, new ErrorEventArgs($"Для продукта \"{op.Product.Name}\" указано количество больше, чем на складе"));
                    return false;
                }
                p.Quantity -= op.Count;
            }
            var created = new Order(++_orderIDCounter, customerID, orderProducts,
                deliveryDate, deliveryAddress);
            _orders.Add(_orderIDCounter, created);
            _customers[customerID].Orders.Add(created);
            OrderCreated?.Invoke(this, new EventArgs());
            return true;
        }

        public bool ConfirmOrder(ulong id)
        {
            if (!_orders.ContainsKey(id))
            {
                Error?.Invoke(this, new ErrorEventArgs("Такого заказа не существует"));
                return false;
            }
            var order = _orders[id];
            if (order.Status == OrderStatus.Delivered)
            {
                Error?.Invoke(this, new ErrorEventArgs("Заказ уже доставлен"));
                return false;
            }
            if (order.Status == OrderStatus.Canceled)
            {
                Error?.Invoke(this, new ErrorEventArgs("Заказ был отменен"));
                return false;
            }
            order.Status = OrderStatus.Delivered;
            return true;
        }

        public bool CancelOrder(ulong id)
        {
            if (!_orders.ContainsKey(id))
            {
                Error?.Invoke(this, new ErrorEventArgs("Такого заказа не существует"));
                return false;
            }
            var order = _orders[id];
            if (order.Status == OrderStatus.Delivered)
            {
                Error?.Invoke(this, new ErrorEventArgs("Заказ уже доставлен"));
                return false;
            }
            if (order.Status == OrderStatus.Canceled)
            {
                Error?.Invoke(this, new ErrorEventArgs("Заказ уже отменен"));
                return false;
            }
            foreach (var op in order.OrderProducts)
            {
                op.Product.Quantity += op.Count;
            }
            order.Status = OrderStatus.Canceled;
            return true;
        }

        public bool DeleteOrder(ulong id)
        {
            if (!_orders.ContainsKey(id))
            {
                Error?.Invoke(this, new ErrorEventArgs("Такого заказа не существует"));
                return false;
            }
            var order = _orders[id];
            if (order.Status != OrderStatus.Canceled && order.Status != OrderStatus.Delivered)
            {
                Error?.Invoke(this,
                    new ErrorEventArgs("Можно удалять только доставленные и отменненные заказы"));
            }
            _customers[order.CustomerID].Orders.RemoveAll(o => o.ID == id);
            _orders.Remove(id);
            return true;
        }

        #endregion
    }
}
