using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string ImageUrl { get; set; }
       
        public string BookUrl { get; set; }
        [Required]
        public string ISBNNUMBER { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [NotMapped]
        public IFormFile Bookfile { get; set; }
        public int BookCoverId { get; set; }    
        public BookCover BookCover { get; set; }
        public int BookWriterId { get; set; }   
        public BookWriter BookWriter     { get; set;}

    }
}
