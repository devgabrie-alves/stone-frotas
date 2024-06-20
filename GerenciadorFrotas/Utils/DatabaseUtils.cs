using GerenciadorFrotas.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GerenciadorFrotas.Utils
{
    public static class DatabaseUtils
    {
        public static string Conexao = string.Empty;
        public static string Servidor = string.Empty;
        public static string Banco = string.Empty;
        public static int IdUsuarioLogado = 0;

        public static void LerAppConfig()
        {
            Servidor = ConfigurationManager.AppSettings.Get("servidor");
            Banco = ConfigurationManager.AppSettings.Get("banco");

            Conexao = $"Data Source={Servidor};Initial Catalog={Banco};Integrated Security=true;";
            //Conexao = $"Server=localhost;Database=GerenciadorFrotas;User Id=sa; Password=teste@123; Encrypt=False";
        }

        public static DataTable ConsultarCidades(int estadoId)
        {
            StringBuilder sql = new StringBuilder();

            try
            {
                sql.Append("SELECT id, cidade FROM tblCidade \n");
                sql.Append(" WHERE estadoId = @estadoId \n");

                DataTable dataTable = new DataTable();
                AcessoDAO acessoBD = new AcessoDAO();
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@estadoId", estadoId));

                return acessoBD.Consultar(sql.ToString(), sqlParameters);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarEstados()
        {
            StringBuilder sql = new StringBuilder();

            try
            {
                sql.Append("SELECT id, uf FROM tblEstado \n");
                return new AcessoDAO().Consultar(sql.ToString(), new List<SqlParameter>());
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int ConsultarEstado(int cidadeId)
        {
            StringBuilder sql = new StringBuilder();

            try
            {
                int estado = 0;
                sql.Append("SELECT estadoId from tblCidade \n");
                sql.Append("WHERE Id = @Id");

                DataTable dataTable = new DataTable();
                AcessoDAO acessoBD = new AcessoDAO();
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@Id", cidadeId));
                dataTable = acessoBD.Consultar(sql.ToString(), sqlParameters);

                if (dataTable.Rows.Count > 0)
                {
                    estado = Convert.ToInt32(dataTable.Rows[0]["estadoId"]);
                }

                return estado;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarStatusFuncionario()
        {
            StringBuilder sql = new StringBuilder();

            try
            {
                sql.Append("SELECT id, descricao FROM tblStatus \n");
                return new AcessoDAO().Consultar(sql.ToString(), new List<SqlParameter>());
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarSexo()
        {
            StringBuilder sql = new StringBuilder();

            try
            {
                sql.Append("SELECT id, descricao FROM tblSexo \n");
                return new AcessoDAO().Consultar(sql.ToString(), new List<SqlParameter>());
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string LikeFormatter(string descricao)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append('%');
            stringBuilder.Append(descricao);
            stringBuilder.Append('%');

            return stringBuilder.ToString();
        }

        public static bool JaExisteNoBanco(string nomeTabela, string colunaWhere, string valorWhere)
        {
            StringBuilder sql = new StringBuilder();
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            try
            {
                sql.Append(" SELECT 1 \n");
                sql.Append(" FROM \n");
                sql.Append(nomeTabela);
                sql.Append(" WHERE \n");
                sql.Append(" UPPER(").Append(colunaWhere).Append(") \n");
                sql.Append(" = UPPER(@parametro) ");

                sqlParameters.Add(new SqlParameter("@parametro", valorWhere));

                if (new AcessoDAO().Consultar(sql.ToString(), sqlParameters).Rows.Count > 0)
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

        public static bool IsAssociado(string nomeTabela, string chaveEstrangeira, int id)
        {
            StringBuilder sql = new StringBuilder();
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            try
            {
                sql.Append(" SELECT 1 \n");
                sql.Append(" FROM \n");
                sql.Append(nomeTabela);
                sql.Append(" WHERE \n");
                sql.Append(chaveEstrangeira);
                sql.Append(" = @id ");

                sqlParameters.Add(new SqlParameter("@id", id));

                if (new AcessoDAO().Consultar(sql.ToString(), sqlParameters).Rows.Count > 0)
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
    }
}
