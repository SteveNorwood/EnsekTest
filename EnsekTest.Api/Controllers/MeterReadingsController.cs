using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EnsekTest.Db;
using EnsekTest.Shared.Entities;

namespace EnsekTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeterReadingsController : ControllerBase
    {
        private readonly EnsekTestContext _context;

        public MeterReadingsController(EnsekTestContext context)
        {
            _context = context;
        }

        // GET: api/MeterReadings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MeterReading>>> GetMeterReadings()
        {
            return await _context.MeterReadings.ToListAsync();
        }

        // GET: api/MeterReadings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MeterReading>> GetMeterReading(int id)
        {
            var meterReading = await _context.MeterReadings.FindAsync(id);

            if (meterReading == null)
            {
                return NotFound();
            }

            return meterReading;
        }

        // PUT: api/MeterReadings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeterReading(int id, MeterReading meterReading)
        {
            if (id != meterReading.Id)
            {
                return BadRequest();
            }

            _context.Entry(meterReading).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeterReadingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MeterReadings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MeterReading>> PostMeterReading(MeterReading meterReading)
        {
            _context.MeterReadings.Add(meterReading);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeterReading", new { id = meterReading.Id }, meterReading);
        }

        // DELETE: api/MeterReadings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MeterReading>> DeleteMeterReading(int id)
        {
            var meterReading = await _context.MeterReadings.FindAsync(id);
            if (meterReading == null)
            {
                return NotFound();
            }

            _context.MeterReadings.Remove(meterReading);
            await _context.SaveChangesAsync();

            return meterReading;
        }

        private bool MeterReadingExists(int id)
        {
            return _context.MeterReadings.Any(e => e.Id == id);
        }
    }
}
