namespace GerenciadorFrotas.Model
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public decimal QuilometragemInicial { get; set; }
        public decimal QuilometragemAtual { get; set; }
        public bool Ativo { get; set; }

        public Veiculo()
        {
            Id = 0;
            Marca = string.Empty;
            Modelo = string.Empty;
            Placa = string.Empty;
            Chassi = string.Empty;
            QuilometragemInicial = 0;
            QuilometragemAtual = 0;
            Ativo = false;
        }
    }
}
