using ListingsTrades.Data;
using Microsoft.AspNetCore.Mvc;

namespace ListingsTrades.Controllers
{
    public class ClassificationsController : BaseApiController
    {
        private readonly ListingsTradesContext _context;
        public ClassificationsController(ListingsTradesContext context)
        {
            _context = context;
        }
       
        [HttpGet("")]
        public IActionResult GetAllClassifications()
        {
            var classifications = _context.Classifications;

            return Ok(classifications);
        }       
    }
}