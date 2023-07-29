using Ecommerce.Data;
using Ecommerce.Helper;
using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WritersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public WritersController(IWebHostEnvironment env, ApplicationDbContext context)
        {
            _hostEnvironment = env;
            _context = context;
        }

        [HttpPost]
        
        public async Task<IActionResult> CreateUpdate([FromForm]BookWriter bookWriter, IFormFile? file)
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
                    bookWriter.ImageUrl = @"\Images\" + fileName;
                }
                if (bookWriter.Id == 0)
                {
                    await _context.Writers.AddAsync(bookWriter);
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
