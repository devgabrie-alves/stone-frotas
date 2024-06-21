namespace GerenciadorFrotas.Model
{
    public class Manutencao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Orcamento { get; set; }
        public int OficinaId { get; set; }
        public int VeiculoId { get; set; }

        public Manutencao()
        {
            Id = 0;
            Descricao = string.Empty;
            Orcamento = 0;
            OficinaId = 0;
            VeiculoId = 0;
        }
    }
}
