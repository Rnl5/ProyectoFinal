﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalECommerce.Data;
using ProyectoFinalECommerce.Shared;

namespace ProyectoFinalECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelefonosClientesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TelefonosClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TelefonosClientes
        [HttpGet("{id}")]
        public async Task<ActionResult<TelefonosClientes>> GetTelefonosClientes(int id)
        {
            var tipo = await _context.TelefonosClientes.FindAsync(id);

            return tipo!;
        }

        // GET: api/TelefonosClientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TelefonosClientes>>> GetTelefonosClientes()
        {
            if (_context.TelefonosClientes == null)
            {
                return NotFound();
            }
            return await _context.TelefonosClientes.ToListAsync();
        }
    }
}
