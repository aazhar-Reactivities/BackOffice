using System;
using System.Threading.Tasks;
using ListingsTrades.Data;
using ListingsTrades.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListingsTrades.Controllers
{
    public class SourceOfBusinessController : BaseApiController
    {
        private readonly ApplicationDBContext _context;
        public SourceOfBusinessController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetSourceOfBusinessAsync()
        {
            var sourceOfBusiness = await _context.SourceOfBusiness.ToListAsync();

            return Ok(_context.SourceOfBusiness);
        }

        [HttpGet("{id}")]
        public IActionResult GetSourceOfBusinessById(Guid id)
        {
            var sourceOfBusiness = _context.Find<SourceOfBusiness>(id);

            if (sourceOfBusiness == null) return BadRequest("Not Found");

            return Ok(sourceOfBusiness);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSourceOfBusiness(SourceOfBusiness sourceOfBusiness)
        {
            if (ModelState.IsValid)
            {
                await _context.SourceOfBusiness.AddAsync(sourceOfBusiness);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetPropertyTypeById", new { sourceOfBusiness.Id }, sourceOfBusiness);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSourceOfBusiness(Guid id, SourceOfBusiness sourceOfBusiness)
        {
            var existSourceOfBusiness = await _context.SourceOfBusiness.FindAsync(id);

            if(existSourceOfBusiness == null) return NotFound("Not Found");

            existSourceOfBusiness.Code = sourceOfBusiness.Code;
            existSourceOfBusiness.Description = sourceOfBusiness.Description;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteexistSourceOfBusiness(Guid id)
        {
            var existSourceOfBusiness = await _context.SourceOfBusiness.FindAsync(id);

            if(existSourceOfBusiness == null) return NotFound("Not Found");

            _context.SourceOfBusiness.Remove(existSourceOfBusiness);

            await _context.SaveChangesAsync();

            return Ok(existSourceOfBusiness);
        }

    }
}