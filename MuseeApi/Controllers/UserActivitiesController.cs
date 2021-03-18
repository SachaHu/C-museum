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
    public class UserActivitiesController : ControllerBase
    {
        private readonly MuseeApiContext _context;

        public UserActivitiesController(MuseeApiContext context)
        {
            _context = context;
        }

        // GET: api/UserActivities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserActivity>>> GetUserActivities()
        {
            return await _context.UserActivities.ToListAsync();
        }

        // GET: api/UserActivities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserActivity>> GetUserActivity(int id)
        {
            var userActivity = await _context.UserActivities.FindAsync(id);

            if (userActivity == null)
            {
                return NotFound();
            }

            return userActivity;
        }

        // PUT: api/UserActivities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserActivity(int id, UserActivity userActivity)
        {
            if (id != userActivity.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userActivity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserActivityExists(id))
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

        // POST: api/UserActivities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserActivity>> PostUserActivity(UserActivity userActivity)
        {
            _context.UserActivities.Add(userActivity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserActivityExists(userActivity.UserId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserActivity", new { id = userActivity.UserId }, userActivity);
        }

        // DELETE: api/UserActivities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserActivity(int id)
        {
            var userActivity = await _context.UserActivities.FindAsync(id);
            if (userActivity == null)
            {
                return NotFound();
            }

            _context.UserActivities.Remove(userActivity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserActivityExists(int id)
        {
            return _context.UserActivities.Any(e => e.UserId == id);
        }
    }
}
