using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalECommerce.Data;
using ProyectoFinalECommerce.Entidades;
using ProyectoFinalECommerce.Shared;

namespace ProyectoFinalECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosNuevoesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductosNuevoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ProductosNuevoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductosNuevo>>> GetProductosNuevos()
        {
            return await _context.ProductosNuevos.ToListAsync();
        }

        // GET: api/ProductosNuevoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductosNuevo>> GetProductosNuevo(int id)
        {
            var productosNuevo = await _context.ProductosNuevos
                                    .Where(p => p.ProductoNuevoId == id)
                                    .FirstOrDefaultAsync();

            if (productosNuevo == null)
            {
                return NotFound();
            }

            return productosNuevo;
        }

        // PUT: api/ProductosNuevoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductosNuevo(int id, ProductosNuevo productosNuevo)
        {
            if (id != productosNuevo.ProductoNuevoId)
            {
                return BadRequest();
            }

            _context.Entry(productosNuevo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductosNuevoExists(id))
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

        // POST: api/ProductosNuevoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductosNuevo>> PostProductosNuevo(ProductosNuevo productosNuevo)
        {
            if(!ProductosNuevoExists(productosNuevo.ProductoNuevoId))
            {
                _context.ProductosNuevos.Add(productosNuevo);
            }
            else
            {
                _context.ProductosNuevos.Add(productosNuevo);
            }
            
            await _context.SaveChangesAsync();

            return Ok(productosNuevo);
        }

        // DELETE: api/ProductosNuevoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductosNuevo(int id)
        {
            var productosNuevo = await _context.ProductosNuevos.FindAsync(id);
            if (productosNuevo == null)
            {
                return NotFound();
            }

            _context.ProductosNuevos.Remove(productosNuevo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductosNuevoExists(int id)
        {
            return _context.ProductosNuevos.Any(e => e.ProductoNuevoId == id);
        }
    }
}
