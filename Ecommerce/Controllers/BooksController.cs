using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public BooksController(IWebHostEnvironment env, ApplicationDbContext context)
        {
            _hostEnvironment = env;
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUpdate([FromForm]Book book, IFormFile? file)
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
                    book.ImageUrl= @"\Images\" + fileName;
                }
                if (book.Id == 0)
                {
                   await _context.Books.AddAsync(book);
                    //TempData["success"] = "Product Added Successfully";
                }

                await  _context.SaveChangesAsync();
               // TempData["success"] = "Category Updated Done";
                ;
            }
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}