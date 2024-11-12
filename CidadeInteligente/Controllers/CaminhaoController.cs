using Microsoft.AspNetCore.Mvc;
using CidadeInteligente.Data;
using CidadeInteligente.Models;

namespace CidadeInteligente.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificacaoController : ControllerBase
    {
        private readonly DbContext _context;

        public NotificacaoController(DbContext context)
        {
            _context = context;
        }

        [HttpPost("enviar")]
        public IActionResult EnviarNotificacao([FromBody] Notificacao notificacao)
        {
            _context.Notificacoes.Add(notificacao);
            _context.SaveChanges();

            return Ok("Notificação enviada com sucesso.");
        }
    }
}
