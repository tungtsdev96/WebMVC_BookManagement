using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fa.WebMVC.Model.Models
{
    public class Book
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        public string Summary { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int AuthorId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime DatePublisher { get; set; }

        [MaxLength(500)]
        public string ImageUrl { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public ICollection<BookInPublisher> BookInPublishers { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }

    }
}
