using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioApp.Entities
{
    public class OrderDTO
    {
        public Guid OrderId { get; set; }
        public DateTime Processed { get; set; }

        public OrderDTO(Order order, DateTime? processed)
        {
            OrderId = order.Id;
            Processed = processed ?? DateTime.Now;
        }
    }
}
