using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confectionery.Models
{
    class Order
    {
        public ulong ID { get; }
        public List<OrderProduct> OrderProducts { get; }

        public ulong CustomerID { get; }

        public DateTime DeliveryDate { get; }

        public string DeliveryAddress { get; }

        public decimal TotalPrice { get; }

        public OrderStatus Status { get; set; } = OrderStatus.Created;

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
