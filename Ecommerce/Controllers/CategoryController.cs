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
        List<Category> categories = new List<Category>
        {

        new Category{Id = 1, Name = "Samsung", DisplayOrder = 1 },
        new Category{Id = 2, Name = "Apple", DisplayOrder= 2 },
        new Category{Id = 3, Name = "Oppo", DisplayOrder = 3 },
        };
    }
}
