using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Proposta : Base
    {
        public int IdProjeto { get; set; }
        public string IdContratado { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataEntrega { get; set; }

        [JsonIgnore]
        public virtual Projeto Projeto { get; set; }
        [JsonIgnore]
        public virtual Contratado Contratado { get; set; }
    }
}
