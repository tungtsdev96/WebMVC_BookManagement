using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fa.WebMVC.Model.Models
{
    public class Order
    {

        [Key]
        public int OrderId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public DateTime CreatedDate { get; set; }

        public int Status { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        [ForeignKey("OrderId")]
        public virtual Customer Customer { get; set; }

    }
}
