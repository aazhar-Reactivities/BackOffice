using System;
using System.Threading.Tasks;
using ListingsTrades.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ListingsTrades.Models;

namespace ListingsTrades.Controllers
{
    public class ConditionsController : BaseApiController
    {
        private readonly ApplicationDBContext _context;
        public ConditionsController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetConditionsAsync()
        {
            var conditions = await _context.Conditions.ToListAsync();

            return Ok(conditions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetConditionById(Guid id)
        {
            var condition = await _context.FindAsync<Conditions>(id);

            if (condition == null) return NotFound("Not Found");

            return Ok(condition);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCondition(Conditions condition)
        {
            if (ModelState.IsValid)
            {
                await _context.Conditions.AddAsync(condition);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetConditionById", new { condition.Id }, condition);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCondition(Guid id, Conditions condition)
        {
            var existConditions = await _context.Conditions.FindAsync(id);

            if(existConditions == null) return NotFound("Not Found");

            existConditions.Condition = condition.Condition;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCondition(Guid id)
        {
            var existConditions = await _context.Conditions.FindAsync(id);

            if(existConditions == null) return NotFound("Not Found");

            _context.Conditions.Remove(existConditions);

            await _context.SaveChangesAsync();

            return Ok(existConditions);
        }        
    }
}