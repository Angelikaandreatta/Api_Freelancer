namespace Domain.Entities
{
    public class Proposta : Base
    {
        public int IdProjeto { get; set; }
        public string IdContratado { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataEntrega { get; set; }
        public Projeto Projeto { get; set; }
        public Contratado Contratado { get; set; }
    }
}
