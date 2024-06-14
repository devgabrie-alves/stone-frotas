using System;

namespace GerenciadorFrotas.Model
{
    public class Controle
    {
        public int Id { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataEntrada { get; set; }
        public bool Concluido { get; set; }
        public int UsuarioId { get; set; }
        public int ColaboradorId { get; set; }
        public int VeiculoId { get; set; }

        public Controle()
        {
            Id = 0;
            DataSaida = DateTime.MinValue;
            DataEntrada = DateTime.MinValue;
            Concluido = false;
            UsuarioId = 0;
            ColaboradorId = 0;
            VeiculoId = 0;
        }
    }
}
