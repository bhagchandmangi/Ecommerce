using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class BookWriter
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public string ImageFile { get; set; }
        public ICollection<Book> Books { get; set;}
        public ICollection<BookWriter> Writers { get; set;}
    }
}
