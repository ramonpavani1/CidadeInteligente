namespace CidadeInteligente.Models
{
    public class Notificacao
    {
        public int IdNotificacao { get; set; }
        public DateTime DataEnvio { get; set; }
        public string TipoNotificacao { get; set; }
        public int IdRecipiente { get; set; }
        public Recipiente Recipiente { get; set; }
    }
}
