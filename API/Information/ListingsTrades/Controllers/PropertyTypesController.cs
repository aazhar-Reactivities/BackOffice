using System;
using System.Threading.Tasks;
using ListingsTrades.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ListingsTrades.Models;

namespace ListingsTrades.Controllers
{
    public class PropertyTypesController : BaseApiController
    {
        private readonly ApplicationDBContext _context;
        public PropertyTypesController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetPropertyTypesAsync()
        {
            var propertyTypes = await _context.PropertyTypes.ToListAsync();

            return Ok(_context.PropertyTypes);
        }

        [HttpGet("{id}")]
        public IActionResult GetPropertyTypeById(Guid id)
        {
            var propertyType = _context.Find<PropertyTypes>(id);

            if (propertyType == null) return BadRequest("Not Found");

            return Ok(propertyType);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePropertyType(PropertyTypes propertyType)
        {
            if (ModelState.IsValid)
            {
                await _context.PropertyTypes.AddAsync(propertyType);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetPropertyTypeById", new { propertyType.Id }, propertyType);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePropertyTypes(Guid id, PropertyTypes propertyTypes)
        {
            var existPropertyTypes = await _context.PropertyTypes.FindAsync(id);

            if(existPropertyTypes == null) return NotFound("Not Found");

            existPropertyTypes.Name = propertyTypes.Name;
            existPropertyTypes.Type = propertyTypes.Type;
            existPropertyTypes.ShortName = propertyTypes.ShortName;
            existPropertyTypes.Report2HO = propertyTypes.Report2HO;
            existPropertyTypes.RentalType = propertyTypes.RentalType;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePropertyTypes(Guid id)
        {
            var existPropertyTypes = await _context.PropertyTypes.FindAsync(id);

            if(existPropertyTypes == null) return NotFound("Not Found");

            _context.PropertyTypes.Remove(existPropertyTypes);

            await _context.SaveChangesAsync();

            return Ok(existPropertyTypes);
        }


    }
}