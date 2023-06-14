using Domain.Enuns;

namespace Domain.Entities
{
    public class Projeto : Base
    {
        public string IdContratante { get; set; }
        public string IdContratado { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Prazo { get; set; }
        public CategoriaProjeto Categoria { get; set; }
        public Contratante Contratante { get; set; }
        public Contratado Contratado { get; set; }
        public Proposta Proposta { get; set; }
    }
}
