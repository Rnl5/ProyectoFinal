//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using ProyectoFinalECommerce.Data;
//using ProyectoFinalECommerce.Model;

//namespace ProyectoFinalECommerce.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TelefonosUsuariosController : ControllerBase
//    {
//        private readonly ApplicationDbContext _context;

//        public TelefonosUsuariosController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: api/TelefonosUsuarios
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<TelefonosUsuario>>> GetTelefonosUsuario()
//        {
//            return await _context.TelefonosUsuario.ToListAsync();
//        }

//        // GET: api/TelefonosUsuarios/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<TelefonosUsuario>> GetTelefonosUsuario(int id)
//        {
//            var telefonosUsuario = await _context.TelefonosUsuario.FindAsync(id);

//            if (telefonosUsuario == null)
//            {
//                return NotFound();
//            }

//            return telefonosUsuario;
//        }

//        // PUT: api/TelefonosUsuarios/5
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutTelefonosUsuario(int id, TelefonosUsuario telefonosUsuario)
//        {
//            if (id != telefonosUsuario.TipoTelId)
//            {
//                return BadRequest();
//            }

//            _context.Entry(telefonosUsuario).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!TelefonosUsuarioExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/TelefonosUsuarios
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPost]
//        public async Task<ActionResult<TelefonosUsuario>> PostTelefonosUsuario(TelefonosUsuario telefonosUsuario)
//        {
//            _context.TelefonosUsuario.Add(telefonosUsuario);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetTelefonosUsuario", new { id = telefonosUsuario.TipoTelId }, telefonosUsuario);
//        }

//        // DELETE: api/TelefonosUsuarios/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteTelefonosUsuario(int id)
//        {
//            var telefonosUsuario = await _context.TelefonosUsuario.FindAsync(id);
//            if (telefonosUsuario == null)
//            {
//                return NotFound();
//            }

//            _context.TelefonosUsuario.Remove(telefonosUsuario);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        private bool TelefonosUsuarioExists(int id)
//        {
//            return _context.TelefonosUsuario.Any(e => e.TipoTelId == id);
//        }
//    }
//}
