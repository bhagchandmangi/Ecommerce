using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _context.Categories;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.Categories.FirstOrDefault(x=>x.Id==id));
        }

        // POST api/<CategoryController>
        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok("Category Created");
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Category category)
        {
            var categoryFromDb = _context.Categories.FirstOrDefault(x=>x.Id==id);
            categoryFromDb.Name = category.Name;
            categoryFromDb.DisplayOrder = category.DisplayOrder;
            _context.Categories.Update(categoryFromDb);
            _context.SaveChanges();
            return Ok("Category Updated");
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var categoryFromDb = _context.Categories.Find(id);
            _context.Categories.Remove(categoryFromDb);
            _context.SaveChanges();
            return Ok("Category Deleted");
        }
    }
}
