using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confectionery.Models;

namespace Confectionery.Core
{
    class ProductEventArgs : EventArgs
    {
        public ProductEventType EventType { get; }
        public ulong ID { get; } = 0;
        public string Name { get; }
        public List<string> Contents { get; }
        public decimal Price { get; }
        public uint Quantity { get; }
        public DateTime ExpiryDate { get; }

        public ProductEventArgs(ProductEventType eventType, string name,
            List<string> contents, decimal price, uint quantity, DateTime expiryDate)
        {
            EventType = eventType;
            Name = name;
            Contents = contents;
            Price = price;
            Quantity = quantity;
            ExpiryDate = expiryDate;
        }

        public ProductEventArgs(ProductEventType eventType, ulong id, string name,
            List<string> contents, decimal price, uint quantity, DateTime expiryDate)
        {
            EventType = eventType;
            ID = id;
            Name = name;
            Contents = contents;
            Price = price;
            Quantity = quantity;
            ExpiryDate = expiryDate;
        }
    }
}
