using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fa.WebMVC.Model.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public int Active { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
