using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confectionery.Models;

namespace Confectionery.Core
{
    class ProductTableItem
    {
        public ulong ID { get; }
        public string Name { get; }
        public string Contents { get; }
        public decimal Price { get; }
        public uint Quantity { get; }
        public DateTime ExpiryDate { get; }

        public ProductTableItem(Product p)
        {
            ID = p.ID;
            Name = p.Name;
            Contents = string.Join("," , p.Contents);
            Price = p.Price;
            Quantity = p.Quantity;
            ExpiryDate = p.ExpiryDate;
        }
    }
}
