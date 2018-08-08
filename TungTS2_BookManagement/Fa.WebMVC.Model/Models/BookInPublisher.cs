using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fa.WebMVC.Model.Models
{
    public class BookInPublisher
    {
        [Key]
        [Column(Order = 1)]
        public int BookId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int PublisherId { get; set; }

        public string Description { get; set; }

        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }

        [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { get; set; }
    }
}
