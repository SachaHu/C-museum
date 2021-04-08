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
            return await _context.ExhibitTags.Include("Exhibit").Include("Tag").ToListAsync();
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

        [HttpGet("filterByTag/{tagId}")]
        public async Task<ActionResult<IEnumerable<ExhibitTag>>> GetExhibitByTag(string tagId)
        {
            IQueryable<ExhibitTag> queryable = _context.ExhibitTags;
            if (!string.IsNullOrEmpty(tagId))
            {
                queryable = queryable.Where(et => et.TagId.Equals(int.Parse(tagId)));
            }

            return await queryable.Include("Exhibit").Include("Tag").ToListAsync();
        }
        
        [HttpGet("filterByExhibit/{exhibitId}")]
        public async Task<ActionResult<IEnumerable<ExhibitTag>>> GetTagByExhibit(string exhibitId)
        {
            IQueryable<ExhibitTag> queryable = _context.ExhibitTags;
            if (!string.IsNullOrEmpty(exhibitId))
            {
                queryable = queryable.Where(et => et.ExhibitId .Equals(int.Parse(exhibitId)));
            }

            return await queryable.Include("Exhibit").Include("Tag").ToListAsync();
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

        // DELETE: api/ExhibitTags/5&6
        [HttpDelete("{id1}&{id2}")]
        public async Task<IActionResult> DeleteExhibitTag(int id1,int id2)
        {
            var exhibitTag = await _context.ExhibitTags.FindAsync(id1,id2);
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
