using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Musica.DAL;
using Musica.Modelos;

namespace Musica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private readonly Context _context;

        public AlbumsController(Context context)
        {
            _context = context;
        }

        //Conexión al metodo de capa BL

        [HttpGet]
        [Route("AportesImpuestos")]
        public ActionResult<IEnumerable<Musica.Modelos.AporteImpuestos>> GetAportesImpuestos(int menor, int mayor)
        {
            var data = new Musica.BL.Nomina(_context).AportesImpuestos(menor, mayor);
            return Ok(data.ToArray());
        }

        [HttpGet]
        [Route("BuscarAlbum")]
        public ActionResult<IEnumerable<Musica.Modelos.Album>> GetBuscarAlbum(int idArtista)
        {
            var data = new Musica.BL.Nomina(_context).BuscarAlbumes(idArtista);
            return Ok(data.ToArray());
        }

        // GET: api/Albums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Album>>> GetAlbumes()
        {
          if (_context.Albumes == null)
          {
              return NotFound();
          }
            return await _context.Albumes.ToListAsync();
        }

        // GET: api/Albums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Album>> GetAlbum(int id)
        {
          if (_context.Albumes == null)
          {
              return NotFound();
          }
            var album = await _context.Albumes.FindAsync(id);

            if (album == null)
            {
                return NotFound();
            }

            return album;
        }

        // PUT: api/Albums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlbum(int id, Album album)
        {
            if (id != album.Id)
            {
                return BadRequest();
            }

            _context.Entry(album).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlbumExists(id))
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

        // POST: api/Albums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Album>> PostAlbum(Album album)
        {
          if (_context.Albumes == null)
          {
              return Problem("Entity set 'Context.Albumes'  is null.");
          }
            _context.Albumes.Add(album);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlbum", new { id = album.Id }, album);
        }

        // DELETE: api/Albums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlbum(int id)
        {
            if (_context.Albumes == null)
            {
                return NotFound();
            }
            var album = await _context.Albumes.FindAsync(id);
            if (album == null)
            {
                return NotFound();
            }

            _context.Albumes.Remove(album);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlbumExists(int id)
        {
            return (_context.Albumes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
