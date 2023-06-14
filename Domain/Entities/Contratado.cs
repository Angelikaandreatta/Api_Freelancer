namespace Domain.Entities
{
    public class Contratado : Base
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Descricao { get; set; }
        public string Habilidades { get; set; }
        public string Profissao { get; set; }
        public IList<Proposta> Proposta { get; set; }
        public Projeto Projeto { get; set; }
    }
}
