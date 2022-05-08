using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confectionery.Models
{
    class Customer
    {
        public ulong ID { get; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Email { get; set; }

        public ObservableCollection<Order> Orders { get; set; } = new ObservableCollection<Order>();

        public decimal TotalOrdersPrice { get; private set; } = 0m;

        public Customer(ulong id, string firstName, string lastName, string middleName, string email)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Email = email;
            calcTotalOrdersPrice();
        }

        private void calcTotalOrdersPrice()
        {
            TotalOrdersPrice = Orders.Aggregate(0m, (ac, o) => ac + o.TotalPrice);
        }

        public string GetListBoxString()
        {
            if (string.IsNullOrEmpty(MiddleName))
            {
                return $"{LastName} {FirstName[0]}., {Email}";
            }
            return $"{LastName} {FirstName[0]}.{MiddleName[0]}., {Email}";

        }
    }
}
