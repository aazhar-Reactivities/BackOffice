using System;
using System.Threading.Tasks;
using ListingsTrades.Data;
using ListingsTrades.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListingsTrades.Controllers
{
    public class ClassificationsController : BaseApiController
    {
        private readonly ApplicationDBContext _context;
        public ClassificationsController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetClassificationsAsync()
        {
            var cassifications = await _context.Classifications.ToListAsync();

            return Ok(_context.Classifications);
        }

        [HttpGet("{id}")]
        public IActionResult GetClassificationById(Guid id)
        {
            var classification = _context.Find<Classifications>(id);

            if (classification == null) return BadRequest("Not Found");

            return Ok(classification);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClassification(Classifications classification)
        {
            if (ModelState.IsValid)
            {
                await _context.Classifications.AddAsync(classification);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetClassificationById", new { classification.Id }, classification);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }  

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClassification(Guid id, Classifications classification)
        {
            if (id != classification.Id) return BadRequest();

            var existClassification = await _context.FindAsync<Classifications>(id);

            if(existClassification == null) return NotFound("Not Found");

            existClassification.Code = classification.Code;
            existClassification.Description = classification.Description;
            existClassification.Acct_Id = classification.Acct_Id;
            existClassification.GST = classification.GST;
            existClassification.Ends = classification.Ends;
            existClassification.Type = classification.Type;
            existClassification.BrokerAccount = classification.BrokerAccount;
            existClassification.AgentAccount = classification.AgentAccount;
            existClassification.FeeAccount = classification.FeeAccount;
            existClassification.TaxRate = classification.TaxRate;
            existClassification.TaxAccount = classification.TaxAccount;
            existClassification.ChargeHOFees = classification.ChargeHOFees;
            existClassification.AllowFeeDiscounting = classification.AllowFeeDiscounting;
            existClassification.ChargePST = classification.ChargePST;
            existClassification.PSTRate = classification.PSTRate;
            existClassification.CreditOffice = classification.CreditOffice;
            existClassification.ListStatus = classification.ListStatus;
            existClassification.CommissionPlan = classification.CommissionPlan;
            existClassification.BrokerAccount_S = classification.BrokerAccount_S;
            existClassification.AgentAccount_S = classification.AgentAccount_S;
            existClassification.RevenueAccount_S = classification.RevenueAccount_S;
            existClassification.NotIn231 = classification.NotIn231;
            existClassification.InactiveDate = classification.InactiveDate;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClassification(Guid id)
        {
            var existClassification = await _context.Classifications.FindAsync(id);

            if(existClassification == null) return NotFound("Not Found");

            _context.Classifications.Remove(existClassification);

            await _context.SaveChangesAsync();

            return Ok(existClassification);
        }         

    }
}