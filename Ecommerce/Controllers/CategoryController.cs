using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(await _context.Categories.ToListAsync());
        //}

        //// GET api/<CategoryController>/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    return Ok(await _context.Categories.FirstOrDefaultAsync(x=>x.Id==id));
        //}

        //// POST api/<CategoryController>
        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] Category category)
        //{
        //    if (category == null)
        //    {
        //        return BadRequest();
        //    }
        //    else
        //    {
        //        await _context.Categories.AddAsync(category);
        //        await _context.SaveChangesAsync();
        //        return Ok("Category Created");
        //    }
            
        //}

        //// PUT api/<CategoryController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, [FromBody] Category category)
        //{

        //     var categoryFromDb = await _context.Categories.FirstOrDefaultAsync(x=>x.Id==id);
        //   if (categoryFromDb == null)
        //    {
        //        return NotFound();
        //    }
        //   else
        //    {
        //        categoryFromDb.Name = category.Name;
        //        categoryFromDb.DisplayOrder = category.DisplayOrder;
        //        _context.Categories.Update(categoryFromDb);
        //        await _context.SaveChangesAsync();
        //        return Ok("Category Updated");
        //    }
            
        //}

        //// DELETE api/<CategoryController>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var categoryFromDb = await _context.Categories.FindAsync(id);
        //    if (categoryFromDb == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        _context.Categories.Remove(categoryFromDb);
        //        await _context.SaveChangesAsync();
        //        return Ok("Category Deleted");
        //    }
           
        //}
    }
}
