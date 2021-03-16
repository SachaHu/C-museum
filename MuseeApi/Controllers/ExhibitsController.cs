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
    public class ExhibitsController : ControllerBase
    {
        private readonly MuseeApiContext _context;

        public ExhibitsController(MuseeApiContext context)
        {
            _context = context;
        }

        // GET: api/Exhibits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exhibit>>> GetExhibits()
        {
            return await _context.Exhibits.ToListAsync();
        }

        // GET: api/Exhibits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exhibit>> GetExhibit(int id)
        {
            var exhibit = await _context.Exhibits.FindAsync(id);

            if (exhibit == null)
            {
                return NotFound();
            }

            return exhibit;
        }

        // PUT: api/Exhibits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExhibit(int id, Exhibit exhibit)
        {
            if (id != exhibit.Id)
            {
                return BadRequest();
            }

            _context.Entry(exhibit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExhibitExists(id))
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

        // POST: api/Exhibits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Exhibit>> PostExhibit(Exhibit exhibit)
        {
            _context.Exhibits.Add(exhibit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExhibit", new { id = exhibit.Id }, exhibit);
        }

        // DELETE: api/Exhibits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExhibit(int id)
        {
            var exhibit = await _context.Exhibits.FindAsync(id);
            if (exhibit == null)
            {
                return NotFound();
            }

            _context.Exhibits.Remove(exhibit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExhibitExists(int id)
        {
            return _context.Exhibits.Any(e => e.Id == id);
        }
    }
}
