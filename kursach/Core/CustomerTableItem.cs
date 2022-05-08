using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confectionery.Models;

namespace Confectionery.Core
{
    class CustomerTableItem
    {
        public ulong ID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string MiddleName { get; }
        public string Email { get; }
        public int OrdersCount { get; }
        public decimal OrdersTotalPrice { get; }

        public CustomerTableItem(Customer customer)
        {
            ID = customer.ID;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            MiddleName = customer.MiddleName;
            Email = customer.Email;
            OrdersCount = customer.Orders.Count;
            OrdersTotalPrice = customer.TotalOrdersPrice;
        }
    }
}
