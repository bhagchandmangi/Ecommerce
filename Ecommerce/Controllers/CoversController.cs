using Ecommerce.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoversController : ControllerBase
    {
        private readonly Data.ApplicationDbContext _context;

        public CoversController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
