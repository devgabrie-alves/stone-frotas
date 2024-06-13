using GerenciadorFrotas.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorFrotas.Utils
{
    public static class DatabaseUtils
    {
        public static string Conexao = string.Empty;
        public static string Servidor = string.Empty;
        public static string Banco = string.Empty;
        public static int IdUsuarioLogado = 0;

        public static DataTable ConsultarCidades(int estadoId)
        {
            try
            {
                string sql = "select id, cidade from tblCidade \n";
                sql += " where estadoId = @estadoId \n";

                DataTable dataTable = new DataTable();
                AcessoDAO acessoBD = new AcessoDAO();
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@estadoId", estadoId));

                return acessoBD.Consultar(sql, sqlParameters);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarEstados()
        {
            try
            {
                string sql = "select id, estado from tblEstado \n";
                return new AcessoDAO().Consultar(sql, new List<SqlParameter>());
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int ConsultarEstado(int cidadeId)
        {
            try
            {
                int estado = 0;
                string sql = "select EstadoId from tblCidade \n";
                sql += "where Id = @Id";

                DataTable dataTable = new DataTable();
                AcessoDAO acessoBD = new AcessoDAO();
                List<SqlParameter> sqlParameters = new List<SqlParameter>();
                sqlParameters.Add(new SqlParameter("@Id", cidadeId));
                dataTable = acessoBD.Consultar(sql, sqlParameters);

                if (dataTable.Rows.Count > 0)
                {
                    estado = Convert.ToInt32(dataTable.Rows[0]["EstadoId"]);
                }

                return estado;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void LerAppConfig()
        {
            Servidor = ConfigurationManager.AppSettings.Get("servidor");
            Banco = ConfigurationManager.AppSettings.Get("banco");

            Conexao = $"Data Source={Servidor};Initial Catalog={Banco};Integrated Security=true;";
            //Conexao = $"Server=localhost;Database=GerenciadorFrotas;User Id=sa; Password=teste@123; Encrypt=False";
        }


    }
}
