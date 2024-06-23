using GerenciadorFrotas.Data;
using GerenciadorFrotas.Model.enums;
using GerenciadorFrotas.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GerenciadorFrotas.Model
{
    public class Controle
    {
        public int Id { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataEntrada { get; set; }
        public int TotalPercorrido { get; set; }
        public bool Concluido { get; set; }
        public int UsuarioId { get; set; }
        public int ColaboradorId { get; set; }
        public int VeiculoId { get; set; }

        public Controle()
        {
            Id = 0;
            DataSaida = DateTime.MinValue;
            DataEntrada = DateTime.MinValue;
            TotalPercorrido = 0;
            Concluido = false;
            UsuarioId = 0;
            ColaboradorId = 0;
            VeiculoId = 0;
        }

        AcessoDAO acessoDAO = new AcessoDAO();
        DataTable dataTable = new DataTable();
        List<SqlParameter> parameters = new List<SqlParameter>();
        StringBuilder sql;

        public void Gravar()
        {
            sql = new StringBuilder();

            try
            {
                parameters.Clear();

                if (Id == 0)
                {
                    sql.Append("INSERT INTO tblControle \n");
                    sql.Append("(dataSaida, concluido, usuarioId, colaboradorId, veiculoId) \n");
                    sql.Append("VALUES \n");
                    sql.Append("(@dataSaida, @concluido, @usuarioId, @colaboradorId, @veiculoId) \n");

                } else
                {
                    sql.Append("UPDATE tblControle \n");
                    sql.Append("SET \n");
                    sql.Append("dataSaida           = @dataSaida, \n");
                    sql.Append("dataEntrada         = @dataEntrada, \n");
                    sql.Append("totalPercorrido     = @totalPercorrido, \n");
                    sql.Append("concluido           = @concluido, \n");
                    sql.Append("usuarioId           = @usuarioId, \n");
                    sql.Append("colaboradorId       = @colaboradorId, \n");
                    sql.Append("veiculoId           = @veiculoId \n");
                    sql.Append("WHERE id = @id \n");

                    parameters.Add(new SqlParameter("@totalPercorrido", TotalPercorrido));
                    parameters.Add(new SqlParameter("@dataEntrada", DataEntrada));
                    parameters.Add(new SqlParameter("@id", Id));
                }

                parameters.Add(new SqlParameter("@dataSaida", DataSaida));
                parameters.Add(new SqlParameter("@concluido", Concluido));
                parameters.Add(new SqlParameter("@usuarioId", UsuarioId));
                parameters.Add(new SqlParameter("@colaboradorId", ColaboradorId));
                parameters.Add(new SqlParameter("@veiculoId", VeiculoId));

                acessoDAO.Executar(sql.ToString(), parameters);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool VerificarPendencia()
        {
            sql = new StringBuilder();

            try
            {
                parameters.Clear();
                sql.Append(" SELECT 1 \n");
                sql.Append(" FROM tblControle \n");
                sql.Append(" WHERE colaboradorId = @colaboradorId ");
                sql.Append("   AND veiculoId = @veiculoId ");
                sql.Append("   AND concluido = @concluido ");

                parameters.Add(new SqlParameter("@colaboradorId", ColaboradorId));
                parameters.Add(new SqlParameter("@veiculoId", VeiculoId));
                parameters.Add(new SqlParameter("@concluido", false));

                dataTable = acessoDAO.Consultar(sql.ToString(), parameters);

                if (dataTable.Rows.Count > 0)
                {
                    return true;

                } else
                {
                    return false;
                }

            } catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DataTable Consultar(StatusEnum status, Veiculo veiculo, Colaborador colaborador)
        {
            sql = new StringBuilder();

            try
            {
                parameters.Clear();
                sql.Append(" SELECT ctl.id, ctl.dataSaida, m.nome, c.nome, ctl.dataEntrada, ctl.totalPercorrido, ctl.concluido, \n");
                sql.Append(" ctl.usuarioId, ctl.colaboradorId, ctl.veiculoId, v.placa, v.chassi, v.modeloId, c.nome AS colaboradorNome, c.cpf, c.celular  ");
                sql.Append(" FROM tblControle ctl \n");
                sql.Append(" INNER JOIN tblVeiculo v on v.id = ctl.veiculoId \n");
                sql.Append(" INNER JOIN tblColaborador c on c.id = ctl.colaboradorId \n");
                sql.Append(" INNER JOIN tblModelo m on m.id = v.modeloId ");
                sql.Append(" WHERE 1=1  ");

                if (Id != 0)
                {
                    sql.Append(" AND ctl.id = @id \n");
                    parameters.Add(new SqlParameter("@id", Id));

                }

                if (veiculo.Placa != string.Empty)
                {
                    sql.Append(" AND v.placa like @placa \n");
                    parameters.Add(new SqlParameter("@placa", DatabaseUtils.LikeFormatter(veiculo.Placa)));

                } else if (veiculo.Chassi != string.Empty)
                {
                    sql.Append(" AND v.chassi like @chassi \n");
                    parameters.Add(new SqlParameter("@chassi", DatabaseUtils.LikeFormatter(veiculo.Chassi)));

                }

                if (colaborador.Nome != string.Empty)
                {
                    sql.Append(" AND c.nome like @nome \n");
                    parameters.Add(new SqlParameter("@nome", DatabaseUtils.LikeFormatter(colaborador.Nome)));

                } else if (colaborador.CPF != string.Empty)
                {
                    sql.Append(" AND c.cpf = @cpf \n");
                    parameters.Add(new SqlParameter("@cpf", colaborador.CPF));

                }

                if (status == StatusEnum.CONCLUIDO)
                {
                    sql.Append(" AND ctl.concluido = 1 ");

                } else if (status == StatusEnum.PENDENTE)
                {
                    sql.Append(" AND ctl.concluido = 0 ");
                }

                dataTable = acessoDAO.Consultar(sql.ToString(), parameters);


                if (Id != 0 && dataTable.Rows.Count == 1)
                {
                    Id = Convert.ToInt32(dataTable.Rows[0]["id"]);
                    DataSaida = Convert.ToDateTime(dataTable.Rows[0]["dataSaida"]);

                    if (dataTable.Rows[0]["dataEntrada"] != DBNull.Value)
                    {
                        DataEntrada = Convert.ToDateTime(dataTable.Rows[0]["dataEntrada"]);
                    }

                    if (dataTable.Rows[0]["dataEntrada"] != DBNull.Value)
                    {
                        TotalPercorrido = Convert.ToInt32(dataTable.Rows[0]["totalPercorrido"]);
                    }

                    Concluido = Convert.ToBoolean(dataTable.Rows[0]["concluido"]);
                    UsuarioId = Convert.ToInt32(dataTable.Rows[0]["usuarioId"]);
                    ColaboradorId = Convert.ToInt32(dataTable.Rows[0]["colaboradorId"]);
                    VeiculoId = Convert.ToInt32(dataTable.Rows[0]["veiculoId"]);

                    veiculo.Placa = dataTable.Rows[0]["placa"].ToString();
                    veiculo.Chassi = dataTable.Rows[0]["chassi"].ToString();
                    veiculo.ModeloId = Convert.ToInt32(dataTable.Rows[0]["modeloId"]);

                    colaborador.Nome = dataTable.Rows[0]["colaboradorNome"].ToString();
                    colaborador.CPF = dataTable.Rows[0]["cpf"].ToString();
                    colaborador.Celular = dataTable.Rows[0]["celular"].ToString();
                }


                return dataTable;
            } catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
