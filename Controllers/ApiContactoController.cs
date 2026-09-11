using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VaultContactos.Models;
using VaultContactos.Data;

[Route("api/contactos")]
[ApiController]
public class ApiContactosController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ApiContactosController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/contactos (Soporta búsqueda opcional por nombre o apellido)
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Contacto>>> GetContactos(string? filtro)
    {
        if (string.IsNullOrEmpty(filtro))
        {
            return await _context.Contactos.ToListAsync();
        }

        return await _context.Contactos
            .Where(c => c.Nombre.Contains(filtro) || c.Apellido.Contains(filtro))
            .ToListAsync();
    }

    // GET: api/contactos/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Contacto>> GetContacto(int id)
    {
        var contacto = await _context.Contactos.FindAsync(id);
        if (contacto == null) return NotFound();
        return contacto;
    }

    // POST: api/contactos
    [HttpPost]
    public async Task<ActionResult<Contacto>> PostContacto(Contacto contacto)
    {
        _context.Contactos.Add(contacto);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetContacto), new { id = contacto.Id }, contacto);
    }

    // PUT: api/contactos/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutContacto(int id, Contacto contacto)
    {
        if (id != contacto.Id)
        {
            return BadRequest("El ID de la ruta no coincide con el ID del objeto.");
        }

        _context.Entry(contacto).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Contactos.Any(e => e.Id == id))
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

    // DELETE: api/contactos/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContacto(int id)
    {
        var contacto = await _context.Contactos.FindAsync(id);
        if (contacto == null) return NotFound();

        _context.Contactos.Remove(contacto);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}