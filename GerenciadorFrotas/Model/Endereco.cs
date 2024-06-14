namespace GerenciadorFrotas.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public int CidadeId { get; set; }
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }

        public Endereco()
        {
            Id = 0;
            Logradouro = string.Empty;
            Numero = string.Empty;
            Complemento = string.Empty;
            Bairro = string.Empty;
            CEP = string.Empty;
            CidadeId = 0;
            ClienteId = 0;
            UsuarioId = 0;
        }
    }
}
