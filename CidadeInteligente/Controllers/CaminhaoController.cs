using Microsoft.AspNetCore.Mvc;
using CidadeInteligente.Data;
using CidadeInteligente.Models;
using Microsoft.EntityFrameworkCore;

namespace CidadeInteligente.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificacaoController : ControllerBase
    {
        private readonly APPDbContext _context;

        public NotificacaoController(APPDbContext context)
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
