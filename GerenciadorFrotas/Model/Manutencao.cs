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
    public class Manutencao
    {
        public int Id { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataEntrada { get; set; }
        public bool Concluido { get; set; }
        public string Descricao { get; set; }
        public decimal Orcamento { get; set; }
        public int OficinaId { get; set; }
        public int VeiculoId { get; set; }

        public Manutencao()
        {
            Id = 0;
            DataSaida = DateTime.MinValue;
            DataEntrada = DateTime.MinValue;
            Concluido = false;
            Descricao = string.Empty;
            Orcamento = 0;
            OficinaId = 0;
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
                    sql.Append("INSERT INTO tblManutencao \n");
                    sql.Append("(dataSaida, concluido, descricao, orcamento, oficinaId, veiculoId) \n");
                    sql.Append("VALUES \n");
                    sql.Append("(@dataSaida, @concluido, @descricao, @orcamento, @oficinaId, @veiculoId) \n");

                } else
                {
                    sql.Append("UPDATE tblManutencao \n");
                    sql.Append("SET \n");
                    sql.Append("dataSaida           = @dataSaida, \n");
                    sql.Append("dataEntrada         = @dataEntrada, \n");
                    sql.Append("concluido           = @concluido, \n");
                    sql.Append("descricao           = @descricao, \n");
                    sql.Append("orcamento           = @orcamento, \n");
                    sql.Append("oficinaId           = @oficinaId, \n");
                    sql.Append("veiculoId           = @veiculoId \n");
                    sql.Append("WHERE id = @id \n");

                    parameters.Add(new SqlParameter("@dataEntrada", DataEntrada));
                    parameters.Add(new SqlParameter("@id", Id));
                }

                parameters.Add(new SqlParameter("@dataSaida", DataSaida));
                parameters.Add(new SqlParameter("@concluido", Concluido));
                parameters.Add(new SqlParameter("@descricao", Descricao));
                parameters.Add(new SqlParameter("@orcamento", Orcamento));
                parameters.Add(new SqlParameter("@oficinaId", OficinaId));
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
                sql.Append(" FROM tblManutencao \n");
                sql.Append("   WHERE veiculoId = @veiculoId ");
                sql.Append("   AND concluido = @concluido ");

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

        public DataTable Consultar(StatusAtividadeEnum status, Veiculo veiculo, Oficina oficina)
        {
            sql = new StringBuilder();

            try
            {
                parameters.Clear();
                sql.Append(" SELECT mn.id, mn.dataSaida, m.nome, o.nomeFantasia, mn.dataEntrada, mn.concluido, mn.descricao, mn.orcamento, \n");
                sql.Append(" mn.oficinaId, mn.veiculoId, v.placa, v.chassi, v.modeloId, o.razaoSocial, o.cnpj, o.email ");
                sql.Append(" FROM tblManutencao mn \n");
                sql.Append(" INNER JOIN tblVeiculo v on v.id = mn.veiculoId \n");
                sql.Append(" INNER JOIN tblOficina o on o.id = mn.oficinaId \n");
                sql.Append(" INNER JOIN tblModelo m on m.id = v.modeloId ");
                sql.Append(" WHERE 1=1  ");

                if (Id != 0)
                {
                    sql.Append(" AND mn.id = @id \n");
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

                if (oficina.NomeFantasia != string.Empty)
                {
                    sql.Append(" AND o.nomeFantasia like @nomeFantasia \n");
                    parameters.Add(new SqlParameter("@nomeFantasia", DatabaseUtils.LikeFormatter(oficina.NomeFantasia)));

                } else if (oficina.CNPJ != string.Empty)
                {
                    sql.Append(" AND o.cnpj = @cnpj \n");
                    parameters.Add(new SqlParameter("@cnpj", oficina.CNPJ));

                }

                if (status == StatusAtividadeEnum.CONCLUIDO)
                {
                    sql.Append(" AND mn.concluido = 1 ");

                } else if (status == StatusAtividadeEnum.PENDENTE)
                {
                    sql.Append(" AND mn.concluido = 0 ");
                }

                dataTable = acessoDAO.Consultar(sql.ToString(), parameters);


                if (Id != 0 && dataTable.Rows.Count == 1)
                {
                    Id = Convert.ToInt32(dataTable.Rows[0]["id"]);
                    Descricao = dataTable.Rows[0]["descricao"].ToString();
                    Orcamento = Convert.ToDecimal(dataTable.Rows[0]["orcamento"]);
                    DataSaida = Convert.ToDateTime(dataTable.Rows[0]["dataSaida"]);

                    if (dataTable.Rows[0]["dataEntrada"] != DBNull.Value)
                    {
                        DataEntrada = Convert.ToDateTime(dataTable.Rows[0]["dataEntrada"]);
                    }

                    Concluido = Convert.ToBoolean(dataTable.Rows[0]["concluido"]);
                    OficinaId = Convert.ToInt32(dataTable.Rows[0]["oficinaId"]);
                    VeiculoId = Convert.ToInt32(dataTable.Rows[0]["veiculoId"]);

                    veiculo.Placa = dataTable.Rows[0]["placa"].ToString();
                    veiculo.Chassi = dataTable.Rows[0]["chassi"].ToString();
                    veiculo.ModeloId = Convert.ToInt32(dataTable.Rows[0]["modeloId"]);

                    oficina.RazaoSocial = dataTable.Rows[0]["razaoSocial"].ToString();
                    oficina.NomeFantasia = dataTable.Rows[0]["nomeFantasia"].ToString();
                    oficina.CNPJ = dataTable.Rows[0]["cnpj"].ToString();
                    oficina.Email = dataTable.Rows[0]["email"].ToString();
                }

                return dataTable;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
