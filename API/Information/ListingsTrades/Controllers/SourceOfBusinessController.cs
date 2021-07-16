using ListingsTrades.Data;
using Microsoft.AspNetCore.Mvc;

namespace ListingsTrades.Controllers
{
    public class SourceOfBusinessController : BaseApiController
    {
        private readonly ListingsTradesContext _context;
        public SourceOfBusinessController(ListingsTradesContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult GetAllSourceOfBusiness()
        {
            var sourceOfBusiness = _context.SourceOfBusiness;

            return Ok(sourceOfBusiness);
        }        
    }
}