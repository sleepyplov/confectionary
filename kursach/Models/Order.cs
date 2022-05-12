using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confectionery.Models
{
    class Order
    {
        public ulong ID { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }

        public ulong CustomerID { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string DeliveryAddress { get; set; }

        public decimal TotalPrice { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Created;

        public Order() { }

        public Order(ulong id, ulong customerId, List<OrderProduct> orderProducts,
            DateTime deliveryDate, string deliveryAddress)
        {
            ID = id;
            CustomerID = customerId;
            OrderProducts = orderProducts;
            DeliveryDate = deliveryDate;
            DeliveryAddress = deliveryAddress;
            TotalPrice = orderProducts.Aggregate(0m, (ac, op) => ac + op.Product.Price * op.Count);
        }
    }
}
