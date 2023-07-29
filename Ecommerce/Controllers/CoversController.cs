using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoversController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public CoversController(IWebHostEnvironment env, ApplicationDbContext context)
        {
            _hostEnvironment = env;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUpdate(BookCover bookCover, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string fileName = string.Empty;
                if (file != null)
                {
                    string uploadDir = Path.Combine(_hostEnvironment.WebRootPath, "Images");
                    fileName = Guid.NewGuid().ToString() + "-" + file.FileName;
                    string filePath = Path.Combine(uploadDir, fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    //   vm.Product.ImageUrl = filePath;
                    bookCover.ImageUrl = @"\Images\" + fileName;
                }
                if (bookCover.Id == 0)
                {
                    await _context.BookCovers.AddAsync(bookCover);
                    //TempData["success"] = "Product Added Successfully";
                }

                await _context.SaveChangesAsync();
                // TempData["success"] = "Category Updated Done";
                ;
            }
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}