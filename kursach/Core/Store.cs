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

        private Dictionary<ulong, Product> _products;
        private Dictionary<ulong, Customer> _customers;
        private Dictionary<ulong, Order> _orders;

        public event EventHandler<ErrorEventArgs> Error;
        public event EventHandler OrderCreated;

        public Store()
        {
            Seed();
        }

        public void Seed()
        {
            _products = new Dictionary<ulong, Product>
            {
                { 1UL, new Product(
                        1,
                        "Тортик",
                        new List<string> {"asfd", "asfew", "ewger", "lkjlknj"},
                        1234.5m,
                        10,
                        DateTime.Today.AddDays(2)
                )}
            };
            _productIDCounter = 1;
            _customers = new Dictionary<ulong, Customer>
            {
                { 1UL, new Customer(1, "Александр", "Палатов", "", "asdf@mail.ru") },
            };
            _customerIDCounter = 1;
            _orders = new Dictionary<ulong, Order>
            {
                { 1UL, new Order(1, 1,
                    new List<OrderProduct>{new OrderProduct(_products[1], 2) },
                    DateTime.Today.AddDays(2), "adres") }
            };
            _orderIDCounter = 1;
            _customers[1].Orders.Add(_orders[1]);
        }

        #region Products

        public IEnumerable<Product> FindProducts(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return _products.Values;
            }
            var searcher = new Searcher(search);
            return _products.Values.Where(p => searcher.MatchString(p.Name));
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
            var searcher = new Searcher(search);
            return _customers.Values.Where(c => searcher.MatchString(c.FirstName) ||
                searcher.MatchString(c.LastName) ||
                searcher.MatchString(c.MiddleName) ||
                searcher.MatchString(c.Email));
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

        private IEnumerable<Order> FindOrders(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return _orders.Values;
            }
            var searcher = new Searcher(search);
            return _orders.Values.Where(o => searcher.MatchString(o.ID.ToString()) ||
                searcher.MatchString(_customers[o.CustomerID].Email));
        }

        public IList<OrderTableItem> GetOrdersTable(string search = "")
        {
            var found = FindOrders(search);
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
            var created = new Order(++_orderIDCounter, customerID, orderProducts,
                deliveryDate, deliveryAddress);
            _orders.Add(_orderIDCounter, created);
            _customers[customerID].Orders.Add(created);
            OrderCreated?.Invoke(this, new EventArgs());
            return true;
        }

        public bool ConfirmDelivery(ulong id)
        {
            if (!_orders.ContainsKey(id))
            {
                Error?.Invoke(this, new ErrorEventArgs("Такого заказа не существует"));
                return false;
            }
            var customer = _customers[_orders[id].CustomerID];
            customer.Orders.RemoveAll(o => o.ID == id);
            _orders.Remove(id);
            return true;
        }

        #endregion
    }
}
