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
    public class ActivityTagsController : ControllerBase
    {
        private readonly MuseeApiContext _context;

        public ActivityTagsController(MuseeApiContext context)
        {
            _context = context;
        }

        // GET: api/ActivityTags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityTag>>> GetActivityTags()
        {
            return await _context.ActivityTags.Include("Activity").Include("Tag").ToListAsync();
        }

        // GET: api/ActivityTags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityTag>> GetActivityTag(int id)
        {
            var activityTag = await _context.ActivityTags.FindAsync(id);

            if (activityTag == null)
            {
                return NotFound();
            }

            return activityTag;
        }

        // PUT: api/ActivityTags/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivityTag(int id, ActivityTag activityTag)
        {
            if (id != activityTag.ActivityId)
            {
                return BadRequest();
            }

            _context.Entry(activityTag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityTagExists(id))
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

        // POST: api/ActivityTags
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ActivityTag>> PostActivityTag(ActivityTag activityTag)
        {
            _context.ActivityTags.Add(activityTag);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ActivityTagExists(activityTag.ActivityId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetActivityTag", new { id = activityTag.ActivityId }, activityTag);
        }

        // DELETE: api/ActivityTags/5&1
        [HttpDelete("{id1}&{id2}")]
        public async Task<IActionResult> DeleteActivityTag(int id1,int id2)
        {
            var activityTag = await _context.ActivityTags.FindAsync(id1, id2);
            if (activityTag == null)
            {
                return NotFound();
            }

            _context.ActivityTags.Remove(activityTag);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActivityTagExists(int id)
        {
            return _context.ActivityTags.Any(e => e.ActivityId == id);
        }
    }
}
