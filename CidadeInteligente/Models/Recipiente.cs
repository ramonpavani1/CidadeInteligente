namespace CidadeInteligente.Models
{
    public class Recipiente
    {
        public int IdRecipiente { get; set; }
        public string Localizacao { get; set; }
        public double CapacidadeTotal { get; set; }
        public double CapacidadeAtual { get; set; }
        public bool IsCheio => CapacidadeAtual >= CapacidadeTotal;
    }
}
