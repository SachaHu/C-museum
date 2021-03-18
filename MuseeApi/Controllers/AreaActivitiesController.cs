using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MuseeApi.Data;
using MuseeApi.Models;

namespace MuseeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaActivitiesController : ControllerBase
    {
        private readonly MuseeApiContext _context;

        public AreaActivitiesController(MuseeApiContext context)
        {
            _context = context;
        }

        // GET: api/AreaActivities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AreaActivity>>> GetAreaActivities()
        {
            return await _context.AreaActivities.ToListAsync();
        }

        // GET: api/AreaActivities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AreaActivity>> GetAreaActivity(int id)
        {
            var areaActivity = await _context.AreaActivities.FindAsync(id);

            if (areaActivity == null)
            {
                return NotFound();
            }

            return areaActivity;
        }

        // PUT: api/AreaActivities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAreaActivity(int id, AreaActivity areaActivity)
        {
            if (id != areaActivity.AreaId)
            {
                return BadRequest();
            }

            _context.Entry(areaActivity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AreaActivityExists(id))
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

        // POST: api/AreaActivities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AreaActivity>> PostAreaActivity(AreaActivity areaActivity)
        {
            _context.AreaActivities.Add(areaActivity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AreaActivityExists(areaActivity.AreaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAreaActivity", new { id = areaActivity.AreaId }, areaActivity);
        }

        // DELETE: api/AreaActivities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAreaActivity(int id)
        {
            var areaActivity = await _context.AreaActivities.FindAsync(id);
            if (areaActivity == null)
            {
                return NotFound();
            }

            _context.AreaActivities.Remove(areaActivity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AreaActivityExists(int id)
        {
            return _context.AreaActivities.Any(e => e.AreaId == id);
        }
    }
}
