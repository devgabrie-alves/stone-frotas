using System;

namespace GerenciadorFrotas.Model
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataAdmissao { get; set; }
        public int StatusId { get; set; }

        public Colaborador() 
        {
            Id = 0;
            Nome = string.Empty;
            CPF = string.Empty;
            Email = string.Empty;
            DataAdmissao = DateTime.MinValue;
            StatusId = 0;
        }
    }
}
