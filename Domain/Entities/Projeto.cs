using Domain.Enuns;

namespace Domain.Entities
{
    public class Projeto : Base
    {
        public int IdContratante { get; set; }
        public int IdContratado { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
        public DateTime Prazo { get; set; }
        public CategoriaProjeto Categoria { get; set; }
    }
}
