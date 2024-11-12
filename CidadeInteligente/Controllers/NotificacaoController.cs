using Microsoft.AspNetCore.Mvc;
using CidadeInteligente.Data;
using CidadeInteligente.Models;
using System.Threading.Tasks;

namespace CidadeInteligente.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaminhaoController : ControllerBase
    {
        private readonly APPDbContext _context;

        public CaminhaoController(APPDbContext context)
        {
            _context = context;
        }

        [HttpPut("{id}/atualizar-localizacao")]
        public async Task<IActionResult> AtualizarLocalizacao(int id, [FromBody] Caminhao caminhaoAtualizado)
        {
            var caminhao = await _context.Caminhoes.FindAsync(id);
            if (caminhao == null) return NotFound();

            caminhao.LocalizacaoAtual = caminhaoAtualizado.LocalizacaoAtual;
            await _context.SaveChangesAsync();

            return Ok(caminhao);
        }
    }
}
