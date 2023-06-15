using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    [NotMapped]
    public class Contratante
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        [JsonIgnore]
        public virtual Projeto Projeto { get; set; }
    }
}
