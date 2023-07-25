using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name conn't be null")]
        public string Name { get; set; }
        [Required(ErrorMessage ="DisplayOrder is Required")]
        public int DisplayOrder { get; set; }
        //public DateTime DateTime { get; set; } = DateTime.Now();
    }
}
