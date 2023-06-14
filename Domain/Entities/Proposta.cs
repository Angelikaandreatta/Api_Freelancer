namespace Domain.Entities
{
    public class Proposta : Base
    {
        public int IdProjeto { get; set; }
        public int IdContratado { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataEntrega { get; set; }
        public Projeto Projeto { get; set; }
        public Contratado Contratado { get; set; }
    }
}
