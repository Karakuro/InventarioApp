using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioApp.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public List<Detail> Details { get; set; }

        public Order(List<Detail> details, DateTime? created)
        {
            Id = Guid.NewGuid();
            Details = details;
            //Versione 1
            Created = created ?? DateTime.Now;
            
            //Versione 2
            //Created = created != null ? created.Value : DateTime.Now;

            //Versione 3
            //if (created != null)
            //    Created = created.Value;
            //else
            //    created = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Order Id: {Id} - Created: {Created.ToShortDateString()}";
        }
    }
}
