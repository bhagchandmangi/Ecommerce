using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Web.Http.ModelBinding;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
namespace Ecommerce.Helper
{
    public class FileHelper : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public FileHelper(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
        //[HttpPost]
        ////public static async Task<string> UploadImage(IFormFile file)
        //{
        //    if (file == null || file.Length == 0)
        //        return BadRequest("File is not selected or the file is empty.");

        //    try
        //    {
        //        string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "Images");
        //        if (!Directory.Exists(uploadsFolder))
        //            Directory.CreateDirectory(uploadsFolder);

        //        string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
        //        string filePath = Path.Combine(uploadsFolder, uniqueFileName);

        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await file.CopyToAsync(stream);
        //        }

        //        // Optionally, you can save the image URL in the database or return it in the response.
        //        // For simplicity, we'll just return the file name.
        //        return Ok(uniqueFileName);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Error uploading image: " + ex.Message);
        //    }

        //}

    }
}
