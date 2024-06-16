using GerenciadorFrotas.Data;
using GerenciadorFrotas.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GerenciadorFrotas.Model
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }

        public Marca()
        {
            Id = 0;
            Nome = string.Empty;
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
                sql.Append("SELECT id, nome, dataCadastro \n");
                sql.Append("FROM tblMarca \n");

                if (Id != 0)
                {
                    sql.Append("WHERE id = @id \n");
                    parameters.Add(new SqlParameter("@id", Id));

                } else if (Nome != string.Empty)
                {
                    sql.Append("WHERE nome LIKE @nome \n");
                    parameters.Add(new SqlParameter("@nome", DatabaseUtils.LikeFormatter(Nome)));
                }

                dataTable = acessoDAO.Consultar(sql.ToString(), parameters);

                if (Id != 0)
                {
                    Id = Convert.ToInt32(dataTable.Rows[0]["id"]);
                    Nome = dataTable.Rows[0]["nome"].ToString();
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
                    sql.Append("INSERT INTO tblMarca \n");
                    sql.Append("(nome, dataCadastro) \n");
                    sql.Append("VALUES \n");
                    sql.Append("(@nome, @dataCadastro) \n");

                    parameters.Add(new SqlParameter("@dataCadastro", DateTime.Now));

                } else
                {
                    sql.Append("UPDATE tblMarca \n");
                    sql.Append("SET \n");
                    sql.Append("nome            = @nome \n");
                    sql.Append("WHERE id = @id \n");

                    parameters.Add(new SqlParameter("@id", Id));
                }

                parameters.Add(new SqlParameter("@nome", Nome));

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

                sql.Append("DELETE FROM tblMarca \n");
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
