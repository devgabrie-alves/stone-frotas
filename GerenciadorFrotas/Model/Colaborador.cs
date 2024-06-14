using GerenciadorFrotas.Model.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFrotas.Model
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email {  get; set; }
        public DateTime DataAdmissao { get; set; }
        public StatusColaborador Status { get; set; }
    }
}
