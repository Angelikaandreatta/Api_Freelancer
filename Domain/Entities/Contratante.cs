﻿namespace Domain.Entities
{
    public class Contratante : Base
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Projeto Projeto { get; set; }
    }
}
