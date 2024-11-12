using Microsoft.AspNetCore.Mvc;
using CidadeInteligente.Data;
using CidadeInteligente.Models;
using Microsoft.EntityFrameworkCore;

namespace CidadeInteligente.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipienteController : ControllerBase
    {
        private readonly APPDbContext _context;

        public RecipienteController(APPDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarRecipiente([FromBody] Recipiente recipiente)
        {
            _context.Recipientes.Add(recipiente);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(ObterRecipiente), new { idrecipiente = recipiente.IdRecipiente }, recipiente);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterRecipiente(int id)
        {
            var recipiente = await _context.Recipientes.FindAsync(id);
            return recipiente == null ? NotFound() : Ok(recipiente);
        }
    }
}
