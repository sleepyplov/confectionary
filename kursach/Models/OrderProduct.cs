using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confectionery.Models
{
    class OrderProduct
    {
        public Product Product { get; set; }
        public uint Count { get; set; }

        public OrderProduct() { }

        public OrderProduct(Product product, uint count)
        {
            Product = product;
            Count = count;
        }
        
        public string GetListBoxString()
        {
            return $"{Product.Name} x{Count}";
        }
    }
}
