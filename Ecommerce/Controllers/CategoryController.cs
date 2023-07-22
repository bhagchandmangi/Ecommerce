using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public static List<Category> ListOfcategories = new List<Category>
        {

        new Category{Id = 1, Name = "Samsung", DisplayOrder = 1 },
        new Category{Id = 2, Name = "Apple", DisplayOrder= 2 },
        new Category{Id = 3, Name = "Oppo", DisplayOrder = 3 },
        };

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return ListOfcategories;
        }
        [HttpPost]
        public void Post([FromBody] Category category)
        {
            ListOfcategories.Add(category); 
        }
    }
}
