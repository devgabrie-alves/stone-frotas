using GerenciadorFrotas.Data;
using GerenciadorFrotas.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GerenciadorFrotas.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

        public Categoria()
        {
            Id = 0;
            Descricao = string.Empty;
            DataCadastro = DateTime.MinValue;
        }

        AcessoDAO acessoDAO = new AcessoDAO();
        DataTable dataTable = new DataTable();
        List<SqlParameter> parameters = new List<SqlParameter>();
        StringBuilder sql;

        public DataTable Consultar()
        {
            sql = new StringBuilder();

            try
            {
                parameters.Clear();
                sql.Append("SELECT id, descricao, dataCadastro \n");
                sql.Append("FROM tblCategoria \n");

                if (Id != 0)
                {
                    sql.Append("WHERE id = @id \n");
                    parameters.Add(new SqlParameter("@id", Id));

                } else if (Descricao != string.Empty)
                {
                    sql.Append("WHERE descricao LIKE @descricao \n");
                    parameters.Add(new SqlParameter("@descricao", DatabaseUtils.LikeFormatter(Descricao)));
                }

                dataTable = acessoDAO.Consultar(sql.ToString(), parameters);

                if (Id != 0)
                {
                    Id = Convert.ToInt32(dataTable.Rows[0]["id"]);
                    Descricao = dataTable.Rows[0]["descricao"].ToString();
                    DataCadastro = Convert.ToDateTime(dataTable.Rows[0]["dataCadastro"]);
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
                    sql.Append("INSERT INTO tblCategoria \n");
                    sql.Append("(descricao, dataCadastro) \n");
                    sql.Append("VALUES \n");
                    sql.Append("(@descricao, @dataCadastro) \n");

                    parameters.Add(new SqlParameter("@dataCadastro", DateTime.Now));

                } else
                {
                    sql.Append("UPDATE tblCategoria \n");
                    sql.Append("SET \n");
                    sql.Append("descricao            = @descricao \n");
                    sql.Append("WHERE id = @id \n");

                    parameters.Add(new SqlParameter("@id", Id));
                }

                parameters.Add(new SqlParameter("@descricao", Descricao));

                acessoDAO.Executar(sql.ToString(), parameters);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir()
        {
            sql = new StringBuilder();

            try
            {
                parameters.Clear();

                sql.Append("DELETE FROM tblCategoria \n");
                sql.Append("WHERE id = @id \n");

                parameters.Add(new SqlParameter("@id", Id));

                acessoDAO.Executar(sql.ToString(), parameters);

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
