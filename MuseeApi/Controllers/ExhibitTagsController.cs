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
    public class ExhibitTagsController : ControllerBase
    {
        private readonly MuseeApiContext _context;

        public ExhibitTagsController(MuseeApiContext context)
        {
            _context = context;
        }

        // GET: api/ExhibitTags
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExhibitTag>>> GetExhibitTags()
        {
            return await _context.ExhibitTags.ToListAsync();
        }

        // GET: api/ExhibitTags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExhibitTag>> GetExhibitTag(int id)
        {
            var exhibitTag = await _context.ExhibitTags.FindAsync(id);

            if (exhibitTag == null)
            {
                return NotFound();
            }

            return exhibitTag;
        }

        // PUT: api/ExhibitTags/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExhibitTag(int id, ExhibitTag exhibitTag)
        {
            if (id != exhibitTag.ExhibitId)
            {
                return BadRequest();
            }

            _context.Entry(exhibitTag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExhibitTagExists(id))
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

        // POST: api/ExhibitTags
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExhibitTag>> PostExhibitTag(ExhibitTag exhibitTag)
        {
            _context.ExhibitTags.Add(exhibitTag);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ExhibitTagExists(exhibitTag.ExhibitId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetExhibitTag", new { id = exhibitTag.ExhibitId }, exhibitTag);
        }

        // DELETE: api/ExhibitTags/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExhibitTag(int id)
        {
            var exhibitTag = await _context.ExhibitTags.FindAsync(id);
            if (exhibitTag == null)
            {
                return NotFound();
            }

            _context.ExhibitTags.Remove(exhibitTag);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExhibitTagExists(int id)
        {
            return _context.ExhibitTags.Any(e => e.ExhibitId == id);
        }
    }
}
