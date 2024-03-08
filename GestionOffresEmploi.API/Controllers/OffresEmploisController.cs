﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModernRecrut.Emplois.API.Data;
using ModernRecrut.Emplois.API.Models;

namespace ModernRecrut.Emplois.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffresEmploisController : ControllerBase
    {
        private readonly OffreEmploiDbContext _context;

        public OffresEmploisController(OffreEmploiDbContext context)
        {
            _context = context;
        }

        // GET: api/OffresEmplois
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OffreEmploi>>> GetOffreEmploi()
        {
          if (_context.OffreEmploi == null)
          {
              return NotFound();
          }
            return await _context.OffreEmploi.ToListAsync();
        }

        // GET: api/OffresEmplois/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OffreEmploi>> GetOffreEmploi(int id)
        {
          if (_context.OffreEmploi == null)
          {
              return NotFound();
          }
            var offreEmploi = await _context.OffreEmploi.FindAsync(id);

            if (offreEmploi == null)
            {
                return NotFound();
            }

            return offreEmploi;
        }

        // PUT: api/OffresEmplois/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOffreEmploi(int id, OffreEmploi offreEmploi)
        {
            if (id != offreEmploi.Id)
            {
                return BadRequest();
            }

            _context.Entry(offreEmploi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OffreEmploiExists(id))
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

        // POST: api/OffresEmplois
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OffreEmploi>> PostOffreEmploi(OffreEmploi offreEmploi)
        {
          if (_context.OffreEmploi == null)
          {
              return Problem("Entity set 'OffreEmploiDbContext.OffreEmploi'  is null.");
          }
            _context.OffreEmploi.Add(offreEmploi);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOffreEmploi", new { id = offreEmploi.Id }, offreEmploi);
        }

        // DELETE: api/OffresEmplois/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOffreEmploi(int id)
        {
            if (_context.OffreEmploi == null)
            {
                return NotFound();
            }
            var offreEmploi = await _context.OffreEmploi.FindAsync(id);
            if (offreEmploi == null)
            {
                return NotFound();
            }

            _context.OffreEmploi.Remove(offreEmploi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OffreEmploiExists(int id)
        {
            return (_context.OffreEmploi?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
