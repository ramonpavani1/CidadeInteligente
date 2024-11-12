using Microsoft.EntityFrameworkCore;
using CidadeInteligente.Models;

namespace CidadeInteligente.Data
{
    public class APPDbContext : DbContext
    {
        public APPDbContext(DbContextOptions<DbContext> options) : base(options) { }

        public DbSet<Recipiente> Recipientes { get; set; }
        public DbSet<Caminhao> Caminhoes { get; set; }
        public DbSet<Notificacao> Notificacoes { get; set; }
        public DbSet<Residuo> Residuos { get; set; }
    }
}
