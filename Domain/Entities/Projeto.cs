using Domain.Enuns;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        public virtual Contratante Contratante { get; set; }

        [JsonIgnore]
        public virtual Contratado Contratado { get; set; }
    }
}
