using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalECommerce.Data;
using ProyectoFinalECommerce.DTO;
using ProyectoFinalECommerce.Entidades;

namespace ProyectoFinalECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CarritoComprasNuevoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CarritoComprasNuevoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CarritoComprasNuevo
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.CarritoComprasNuevos
                        .Include(ts => ts.User!)
                        .Include(ts => ts.ProductosNuevo!)
                        .ThenInclude(pc => pc.CategoriaId)
                        .Include(ts => ts.ProductosNuevo!)
                        .Where(x => x.User!.Email == User.Identity!.Name)
                        .ToListAsync());
        }

        // GET: api/CarritoComprasNuevo/5
        [HttpGet("count")]
        public async Task<ActionResult> GetCount()
        {
            return Ok(await _context.CarritoComprasNuevos
                        .Where(x => x.User!.Email == User.Identity!.Name)
                        .SumAsync(x => x.Cantidad));
        }

        // PUT: api/CarritoComprasNuevo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarritoComprasNuevo(int id, CarritoComprasNuevo carritoComprasNuevo)
        {
            if (id != carritoComprasNuevo.CarritoComprasNuevoId)
            {
                return BadRequest();
            }

            _context.Entry(carritoComprasNuevo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarritoComprasNuevoExists(id))
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

        // POST: api/CarritoComprasNuevo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarritoComprasNuevo>> PostCarritoComprasNuevo(CarritoComprasNuevoDTO carritoComprasNuevoDTO)
        {
            var producto = await _context.ProductosNuevos.FirstOrDefaultAsync(p => p.ProductoNuevoId == carritoComprasNuevoDTO.ProductoNuevoId);

            if(producto == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == User.Identity!.Name);
            if(user == null)
            {
                return NotFound();
            }

            var carritoComprasNuevo = new CarritoComprasNuevo
            {
                ProductosNuevo = producto,
                Cantidad = carritoComprasNuevoDTO.Cantidad,
                Observaciones = carritoComprasNuevoDTO.Observaciones,
                User = user
            };

            try
            {
                _context.Add(carritoComprasNuevo);
                await _context.SaveChangesAsync();
                return Ok(carritoComprasNuevoDTO);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        // DELETE: api/CarritoComprasNuevo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarritoComprasNuevo(int id)
        {
            var carritoComprasNuevo = await _context.CarritoComprasNuevos.FindAsync(id);
            if (carritoComprasNuevo == null)
            {
                return NotFound();
            }

            _context.CarritoComprasNuevos.Remove(carritoComprasNuevo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarritoComprasNuevoExists(int id)
        {
            return _context.CarritoComprasNuevos.Any(e => e.CarritoComprasNuevoId == id);
        }
    }
}
