namespace Domain.Entities
{
    public class Proposta : Base
    {
        public int IdProjeto { get; set; }
        public int IdContratado { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}
