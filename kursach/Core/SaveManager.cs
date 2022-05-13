using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using Confectionery.Models;

namespace Confectionery.Core
{
    class SaveManager
    {
        private readonly string _productsSavePath = "products.json";
        private readonly string _customersSavePath = "customers.json";

        private class OrderProductIDConverter : JsonConverter<Product>
        {
            private Dictionary<ulong, Product> _products;
            public OrderProductIDConverter(Dictionary<ulong, Product> products)
            {
                _products = products;
            }
            public override Product Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                var id = reader.GetUInt64();
                return _products[id];
            }

            public override void Write(Utf8JsonWriter writer, Product value, JsonSerializerOptions options)
            {
                writer.WriteNumberValue(value.ID);
            }
        }
        public void Save(Dictionary<ulong, Product> products, Dictionary<ulong, Customer> customers)
        {
            using (var stream = File.Create(_productsSavePath))
            {
                JsonSerializer.Serialize(stream, products);
            }
            var options = new JsonSerializerOptions
            {
                Converters =
                {
                    new OrderProductIDConverter(products),
                }
            };
            using (var stream = File.Create(_customersSavePath))
            {
                JsonSerializer.Serialize(stream, customers, options);
            }
        }

        public void Load(out Dictionary<ulong, Product> products,
            out Dictionary<ulong, Customer> customers,
            out Dictionary<ulong, Order> orders, out ulong productIDCounter,
            out ulong customerIDCounter, out ulong orderIDCounter)
        {
            productIDCounter = customerIDCounter = orderIDCounter = 0;
            if (!File.Exists(_productsSavePath) || !File.Exists(_customersSavePath))
            {
                products = new Dictionary<ulong, Product>();
                customers = new Dictionary<ulong, Customer>();
                orders = new Dictionary<ulong, Order>();
                return;
            }
            try
            {
                using (var stream = File.OpenRead(_productsSavePath))
                {
                    products = JsonSerializer.Deserialize<Dictionary<ulong, Product>>(stream);
                }
                foreach (var id in products.Keys)
                {
                    if (id > productIDCounter)
                    {
                        productIDCounter = id;
                    }
                }
                var options = new JsonSerializerOptions
                {
                    Converters =
                {
                    new OrderProductIDConverter(products),
                }
                };
                using (var stream = File.OpenRead(_customersSavePath))
                {
                    customers = JsonSerializer.Deserialize<Dictionary<ulong, Customer>>(stream, options);
                }
                orders = new Dictionary<ulong, Order>();
                foreach (var c in customers.Values)
                {
                    if (c.ID > customerIDCounter)
                    {
                        customerIDCounter = c.ID;
                    }
                    foreach (var o in c.Orders)
                    {
                        orders.Add(o.ID, o);
                        if (o.ID > orderIDCounter)
                        {
                            orderIDCounter = o.ID;
                        }
                    }
                }
            }
            catch
            {
                products = new Dictionary<ulong, Product>();
                customers = new Dictionary<ulong, Customer>();
                orders = new Dictionary<ulong, Order>();
            }
        }
    }
}
