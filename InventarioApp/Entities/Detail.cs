using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioApp.Entities
{
    public class Detail
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public Detail(int quantity, double price, Product product)
        {
            Id = Guid.NewGuid();
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public override string ToString()
        {
            return $"\tDetail Id: {Id} - Quantity: {Quantity} - Price: {Price}€ - Product: {Product.Name}";
        }
    }
}
