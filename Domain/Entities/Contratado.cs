﻿using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Contratado
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Descricao { get; set; }
        public string Habilidades { get; set; }
        public string Profissao { get; set; }

        [JsonIgnore]
        public virtual Projeto Projeto { get; set; }
    }
}
