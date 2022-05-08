﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confectionery.Models
{
    class Product
    {
        public ulong ID { get; }
        public string Name { get; }

        public List<string> Contents { get; set; }

        public decimal Price { get; set; }

        public uint Quantity { get; set; }

        public DateTime ExpiryDate { get; }

        public Product(ulong id, string name, List<string> contents,
            decimal price, uint quantity, DateTime expiry)
        {
            ID = id;
            Name = name;
            Contents = contents;
            Price = price;
            Quantity = quantity;
            ExpiryDate = expiry;
        }

        public string GetListBoxString()
        {
            return $"{Name}, {Price}";
        }
    }
}
