using System.Collections.Generic;
using System.Threading.Tasks;
using ListingsTrades.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListingsTrades.Controllers
{
    public class PropertyTypesController : BaseApiController
    {
        private readonly ListingsTradesContext _context;
        public PropertyTypesController(ListingsTradesContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult GetAllPropertyTypes()
        {
            var propertyTypes = _context.PropertyTypes;

            return Ok(propertyTypes);
        }
    }
}