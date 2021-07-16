using ListingsTrades.Data;
using Microsoft.AspNetCore.Mvc;

namespace ListingsTrades.Controllers
{
    public class ConditionsController : BaseApiController
    {
        private readonly ListingsTradesContext _context;
        public ConditionsController(ListingsTradesContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult GetAllConditions()
        {
            var conditions = _context.Conditions;

            return Ok(conditions);
        }
    }
}