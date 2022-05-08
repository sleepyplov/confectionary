using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confectionery.Models;

namespace Confectionery.Core
{
    class OrderEventArgs : EventArgs
    {
        public ulong ID { get; }
        public string CustomerEmail { get; }
        public List<OrderProduct> OrderProducts { get; }
        public DateTime DeliveryDate { get; }
        public string DeliveryAddress { get; }

        public OrderEventArgs(ulong iD, string customerEmail,
            List<OrderProduct> orderProducts, DateTime deliveryDate, string deliveryAddress)
        {
            ID = iD;
            CustomerEmail = customerEmail;
            OrderProducts = orderProducts;
            DeliveryDate = deliveryDate;
            DeliveryAddress = deliveryAddress;
        }
    }
}
