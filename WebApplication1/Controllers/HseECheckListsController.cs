using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HseECheckListsController : ControllerBase
    {
        private readonly HSEContext _context;

        public HseECheckListsController(HSEContext context)
        {
            _context = context;
        }

        // GET: api/HseECheckLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HseECheckList>>> GetHseECheckLists()
        {
            return await _context.HseECheckLists.ToListAsync();
        }

        // GET: api/HseECheckLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HseECheckList>> GetHseECheckList(long id)
        {
            var hseECheckList = await _context.HseECheckLists.FindAsync(id);

            if (hseECheckList == null)
            {
                return NotFound();
            }

            return hseECheckList;
        }

        // PUT: api/HseECheckLists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHseECheckList(long id, HseECheckList hseECheckList)
        {
            if (id != hseECheckList.ECheckListId)
            {
                return BadRequest();
            }

            _context.Entry(hseECheckList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HseECheckListExists(id))
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

        // POST: api/HseECheckLists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HseECheckList>> PostHseECheckList(HseECheckList hseECheckList)
        {
            _context.HseECheckLists.Add(hseECheckList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHseECheckList", new { id = hseECheckList.ECheckListId }, hseECheckList);
        }

        // DELETE: api/HseECheckLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHseECheckList(long id)
        {
            var hseECheckList = await _context.HseECheckLists.FindAsync(id);
            if (hseECheckList == null)
            {
                return NotFound();
            }

            _context.HseECheckLists.Remove(hseECheckList);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HseECheckListExists(long id)
        {
            return _context.HseECheckLists.Any(e => e.ECheckListId == id);
        }
    }
}
