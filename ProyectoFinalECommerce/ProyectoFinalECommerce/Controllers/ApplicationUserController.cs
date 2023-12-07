//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using ProyectoFinalECommerce.Data;
//using ProyectoFinalECommerce.Shared;

//namespace ProyectoFinalECommerce.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ApplicationUserController : ControllerBase
//    {
//        private readonly ApplicationDbContext _context;

//        public ApplicationUserController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetUsuarios()
//        {
//            return await _context.ApplicationUsers.ToListAsync();
//        }

//        // GET: api/Clientes/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<ApplicationUser>> GetUsuarios(string id)
//        {
//            if (_context.ApplicationUsers == null)
//            {
//                return NotFound();
//            }
//            var usuarios = await _context.ApplicationUsers
//                        .Include(c => c.UsuarioDetalle)
//                        .Where(c => c.Id == id)
//                        .FirstOrDefaultAsync();

//            if (usuarios == null)
//            {
//                return NotFound();
//            }

//            return usuarios;
//        }



//        // POST: api/Clientes
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPost]
//        public async Task<ActionResult<ApplicationUser>> PostUsuarios(ApplicationUser usuario)
//        {
//            if (!UsuarioExists(usuario.Id))
//            {
//                _context.ApplicationUsers.Add(usuario);
//            }
//            else
//            {
//                _context.ApplicationUsers.Update(usuario);
//            }

//            await _context.SaveChangesAsync();

//            return Ok(usuario);
//        }

//        // DELETE: api/Clientes/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteUsuarios(string id)
//        {
//            var usuarios = await _context.ApplicationUsers.FindAsync(id);
//            if (usuarios == null)
//            {
//                return NotFound();
//            }

//            _context.ApplicationUsers.Remove(usuarios);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        private bool UsuarioExists(string id)
//        {
//            return _context.ApplicationUsers.Any(e => e.Id == id);
//        }
//    }
//}
