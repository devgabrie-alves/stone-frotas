using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFrotas.Model
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo {  get; set; }
        public string Placa { get; set; }
        public string Chassi {  get; set; }
        public decimal quilometragemInicial {  get; set; }
        public decimal quilometragemAtual { get; set; }
        public bool ativo { get; set; }

        public Veiculo()
        {
            Id = 0;
            Marca = string.Empty; 
            Modelo = string.Empty; 
            Placa = string.Empty; 
            Chassi = string.Empty;
            quilometragemInicial = 0;
            quilometragemAtual = 0;
            ativo = false;
        }
    }
}
