using Microsoft.AspNetCore.Mvc;
using CidadeInteligente.Data;
using CidadeInteligente.Models;
using System.Threading.Tasks;

namespace CidadeInteligente.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResiduoController : ControllerBase
    {
        private readonly APPDbContext _context;

        public ResiduoController(APPDbContext context)
        {
            _context = context;
        }

        [HttpPost("{idRecipiente}/registrar-residuo")]
        public async Task<IActionResult> RegistrarResiduo(int idRecipiente, [FromBody] Residuo residuo)
        {
            var recipiente = await _context.Recipientes.FindAsync(idRecipiente);
            if (recipiente == null) return NotFound();

            recipiente.CapacidadeAtual += residuo.Quantidade;
            await _context.SaveChangesAsync();

            return Ok("Resíduo registrado com sucesso.");
        }
    }
}
