using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confectionery.Models;

namespace Confectionery.Core
{
    class CustomerEventArgs : EventArgs
    {
        public CustomerEventType EventType { get; }
        public ulong ID { get; } = 0;
        public string FirstName { get; }
        public string LastName { get; }
        public string MiddleName { get; }
        public string Email { get; }

        public CustomerEventArgs(CustomerEventType eventType, string firstName,
            string lastName, string middleName, string email)
        {
            EventType = eventType;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Email = email;
        }

        public CustomerEventArgs(CustomerEventType eventType, ulong id, string firstName,
            string lastName, string middleName, string email)
        {
            EventType = eventType;
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Email = email;
        }
    }
}
