using GerenciadorFrotas.Data;
using GerenciadorFrotas.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GerenciadorFrotas.Model
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public decimal QuilometragemInicial { get; set; }
        public decimal QuilometragemAtual { get; set; }
        public bool Ativo { get; set; }
        public int UsuarioId { get; set; }
        public int ModeloId { get; set; }


        public Veiculo()
        {
            Id = 0;
            Placa = string.Empty;
            Chassi = string.Empty;
            QuilometragemInicial = 0;
            QuilometragemAtual = 0;
            Ativo = false;
            UsuarioId = 0;
            ModeloId = 0;
        }

        AcessoDAO acessoDAO = new AcessoDAO();
        DataTable dataTable = new DataTable();
        List<SqlParameter> parameters = new List<SqlParameter>();
        StringBuilder sql;

        public DataTable Consultar(int valorSelecionado, string campoPesquisa)
        {
            sql = new StringBuilder();

            try
            {
                parameters.Clear();

                sql.Append("SELECT \n");
                sql.Append("    v.id AS id, \n");
                sql.Append("    v.placa AS placa, \n");
                sql.Append("    v.chassi AS chassi, \n");
                sql.Append("    v.quilometragemInicial AS quilometragemInicial, \n");
                sql.Append("    v.quilometragemAtual AS quilometragemAtual, \n");
                sql.Append("    v.ativo AS ativo, \n");
                sql.Append("    v.usuarioId AS usuarioId, \n");
                sql.Append("    v.modeloId AS modeloId, \n");
                sql.Append("    mo.nome AS nomeModelo, \n");
                sql.Append("    ma.nome AS nomeMarca, \n");
                sql.Append("    ca.descricao AS descricaoCategoria \n");
                sql.Append(" FROM tblVeiculo v \n");
                sql.Append("INNER JOIN tblModelo mo ON mo.id = v.modeloId \n");
                sql.Append("INNER JOIN tblMarca ma ON ma.id = mo.marcaId \n");
                sql.Append("INNER JOIN tblCategoria ca ON ca.id = mo.categoriaId \n");

                if (Id != 0)
                {
                    sql.Append("WHERE v.id = @id \n");

                    parameters.Add(new SqlParameter("@id", Id));
                }

                if (campoPesquisa != string.Empty)
                {
                    if (valorSelecionado == 1)
                    {
                        sql.Append("WHERE v.placa LIKE @placa \n");

                        parameters.Add(new SqlParameter("@placa", DatabaseUtils.LikeFormatter(campoPesquisa)));

                    } else if (valorSelecionado == 2)
                    {
                        sql.Append("WHERE v.chassi LIKE @chassi \n");

                        parameters.Add(new SqlParameter("@chassi", DatabaseUtils.LikeFormatter(campoPesquisa)));

                    } else if (valorSelecionado == 3)
                    {
                        sql.Append("WHERE mo.nome LIKE @nomeModelo \n");

                        parameters.Add(new SqlParameter("@nomeModelo", DatabaseUtils.LikeFormatter(campoPesquisa)));

                    } else if (valorSelecionado == 4)
                    {
                        sql.Append("WHERE ma.nome LIKE @nomeMarca \n");

                        parameters.Add(new SqlParameter("@nomeMarca", DatabaseUtils.LikeFormatter(campoPesquisa)));

                    } else if (valorSelecionado == 5)
                    {
                        sql.Append("WHERE ca.descricao LIKE @descricaoCategoria \n");

                        parameters.Add(new SqlParameter("@descricaoCategoria", DatabaseUtils.LikeFormatter(campoPesquisa)));
                    }
                }

                //Para comparar placas IGUAIS
                if (valorSelecionado == 6)
                {
                    sql.Append("WHERE v.placa = @placa \n");

                    parameters.Add(new SqlParameter("@placa", campoPesquisa));
                }

                dataTable = acessoDAO.Consultar(sql.ToString(), parameters);

                if (Id != 0 || Placa != string.Empty && dataTable.Rows.Count == 1)
                {
                    Id = Convert.ToInt32(dataTable.Rows[0]["id"]);
                    Placa = dataTable.Rows[0]["placa"].ToString();
                    Chassi = dataTable.Rows[0]["chassi"].ToString();
                    QuilometragemInicial = Convert.ToInt32(dataTable.Rows[0]["quilometragemInicial"]);
                    QuilometragemAtual = Convert.ToInt32(dataTable.Rows[0]["quilometragemAtual"]);
                    Ativo = Convert.ToBoolean(dataTable.Rows[0]["ativo"]);
                    UsuarioId = Convert.ToInt32(dataTable.Rows[0]["usuarioId"]);
                    ModeloId = Convert.ToInt32(dataTable.Rows[0]["modeloId"]);
                }

                return dataTable;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Gravar()
        {
            sql = new StringBuilder();

            try
            {
                parameters.Clear();

                if (Id == 0)
                {
                    sql.Append("INSERT INTO tblVeiculo \n");
                    sql.Append("(placa, chassi, quilometragemInicial, quilometragemAtual, ativo, usuarioId, modeloId) \n");
                    sql.Append("VALUES \n");
                    sql.Append("(@placa, @chassi, @quilometragemInicial, @quilometragemAtual, @ativo, @usuarioId, @modeloId) \n");

                    parameters.Add(new SqlParameter("@quilometragemInicial", QuilometragemInicial));
                    parameters.Add(new SqlParameter("@quilometragemAtual", QuilometragemAtual));
                    parameters.Add(new SqlParameter("@usuarioId", UsuarioId));

                } else
                {
                    sql.Append("UPDATE tblVeiculo \n");
                    sql.Append("SET \n");
                    sql.Append("placa                   = @placa, \n");
                    sql.Append("chassi                  = @chassi, \n");
                    sql.Append("ativo                   = @ativo, \n");
                    sql.Append("modeloId                = @modeloId \n");
                    sql.Append("WHERE id = @id \n");

                    parameters.Add(new SqlParameter("@id", Id));
                }

                parameters.Add(new SqlParameter("@placa", Placa));
                parameters.Add(new SqlParameter("@chassi", Chassi));
                parameters.Add(new SqlParameter("@ativo", Ativo));
                
                parameters.Add(new SqlParameter("@modeloId", ModeloId));

                acessoDAO.Executar(sql.ToString(), parameters);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
