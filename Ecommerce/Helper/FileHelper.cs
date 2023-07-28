using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Web.Http.ModelBinding;

namespace Ecommerce.Helper
{
    public class FileHelper
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public FileHelper(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<string> UploadImage(IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string fileName = string.Empty;
                if (file != null)
                {
                    string uploadDir = Path.Combine(_hostEnvironment.WebRootPath, "ProductImage");
                    fileName = Guid.NewGuid().ToString() + "-" + file.FileName;
                    string filePath = Path.Combine(uploadDir, fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                            }
                    //   vm.Product.ImageUrl = filePath;
                    book.BookCover.ImageUrl = @"\ProductImage\" + fileName;
                }
                if (book.Product.Id == 0)
                {
                    _unitOfWork.Product.Add(book.Product);
                    TempData["success"] = "Product Added Successfully";
                }

                _unitOfWork.Save();
                TempData["success"] = "Category Updated Done";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
