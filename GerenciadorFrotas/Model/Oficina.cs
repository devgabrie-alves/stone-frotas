namespace GerenciadorFrotas.Model
{
    public class Oficina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public Oficina()
        {
            Id = 0;
            Nome = string.Empty;
            Cnpj = string.Empty;
            Contato = string.Empty;
            Telefone = string.Empty;
            Endereco = new Endereco();
        }
    }
}
