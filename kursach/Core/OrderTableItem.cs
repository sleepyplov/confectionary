using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confectionery.Models;

namespace Confectionery.Core
{
    class OrderTableItem
    {
        public ulong ID { get; }
        public string CustomerEmail { get; }
        public decimal TotalPrice { get; }
        public string DeliveryAddress { get; }
        public DateTime DeliveryDate { get; }
        public OrderStatus Status { get; }

        public OrderTableItem(Order order, Customer customer)
        {
            ID = order.ID;
            CustomerEmail = customer.Email;
            TotalPrice = order.TotalPrice;
            DeliveryAddress = order.DeliveryAddress;
            DeliveryDate = order.DeliveryDate;
            Status = order.Status;
        }
    }
}
