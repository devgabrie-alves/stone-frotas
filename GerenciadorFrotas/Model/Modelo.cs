using GerenciadorFrotas.Data;
using GerenciadorFrotas.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GerenciadorFrotas.Model
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Ano { get; set; }
        public int MarcaId { get; set; }
        public int CategoriaId { get; set; }

        public Modelo()
        {
            Id = 0;
            Nome = string.Empty;
            DataCadastro = DateTime.MinValue;
            Ano = 0;
            MarcaId = 0;
            CategoriaId = 0;
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
                sql.Append("SELECT mo.id AS id, mo.nome AS nome, mo.dataCadastro AS dataCadastro, \n");
                sql.Append("mo.marcaId AS marcaId, mo.categoriaId AS categoriaId, ma.nome, ca.descricao,  \n");
                sql.Append("mo.ano AS ano, CONCAT(mo.nome, ' - ', mo.ano) AS nomeAno \n");
                sql.Append("FROM tblModelo mo \n");
                sql.Append("INNER JOIN tblMarca ma ON ma.Id = mo.marcaId \n");
                sql.Append("INNER JOIN tblCategoria ca ON ca.Id = mo.categoriaId \n");

                if (Id != 0)
                {
                    sql.Append("WHERE mo.id = @id \n");
                    parameters.Add(new SqlParameter("@id", Id));

                } else if (Nome != string.Empty)
                {
                    sql.Append("WHERE mo.nome LIKE @nome \n");
                    parameters.Add(new SqlParameter("@nome", DatabaseUtils.LikeFormatter(Nome)));

                } else if (MarcaId != 0 && CategoriaId != 0)
                {
                    sql.Append("WHERE mo.categoriaId = @categoriaId \n");
                    sql.Append("  AND mo.marcaId = @marcaId \n");

                    parameters.Add(new SqlParameter("@categoriaId", CategoriaId));
                    parameters.Add(new SqlParameter("@marcaId", MarcaId));
                }

                dataTable = acessoDAO.Consultar(sql.ToString(), parameters);

                if (Id != 0)
                {
                    Id = Convert.ToInt32(dataTable.Rows[0]["id"]);
                    Nome = dataTable.Rows[0]["nome"].ToString();
                    DataCadastro = Convert.ToDateTime(dataTable.Rows[0]["dataCadastro"]);
                    Ano = Convert.ToInt32(dataTable.Rows[0]["ano"]);
                    MarcaId = Convert.ToInt32(dataTable.Rows[0]["marcaId"]);
                    CategoriaId = Convert.ToInt32(dataTable.Rows[0]["categoriaId"]);
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
                    sql.Append("INSERT INTO tblModelo \n");
                    sql.Append("(nome, dataCadastro, marcaId, categoriaId, ano) \n");
                    sql.Append("VALUES \n");
                    sql.Append("(@nome, @dataCadastro, @marcaId, @categoriaId, @ano) \n");

                    parameters.Add(new SqlParameter("@dataCadastro", DateTime.Now));

                } else
                {
                    sql.Append("UPDATE tblModelo \n");
                    sql.Append("SET \n");
                    sql.Append("nome            = @nome, \n");
                    sql.Append("marcaId         = @marcaId, \n");
                    sql.Append("categoriaId     = @categoriaId, \n");
                    sql.Append("ano             = @ano \n");
                    sql.Append("WHERE id = @id \n");

                    parameters.Add(new SqlParameter("@id", Id));
                }

                parameters.Add(new SqlParameter("@nome", Nome));
                parameters.Add(new SqlParameter("@marcaId", MarcaId));
                parameters.Add(new SqlParameter("@categoriaId", CategoriaId));
                parameters.Add(new SqlParameter("@ano", Ano));

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
                sql.Append(" DELETE FROM tblModelo \n");
                sql.Append(" WHERE id = @id \n");

                parameters.Add(new SqlParameter("@id", Id));

                acessoDAO.Executar(sql.ToString(), parameters);

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool JaExisteNoBanco()
        {
            sql = new StringBuilder();

            try
            {
                parameters.Clear();

                sql.Append(" SELECT 1 FROM tblModelo mo \n");
                sql.Append(" INNER JOIN tblMarca ma ON ma.id = mo.marcaId \n");
                sql.Append(" INNER JOIN tblCategoria ca ON ca.id = mo.categoriaId \n");
                sql.Append(" WHERE mo.nome = @nome \n");
                sql.Append("   AND ma.id = @marcaId \n");
                sql.Append("   AND ca.id = @categoriaId \n");

                parameters.Add(new SqlParameter("@nome", Nome));
                parameters.Add(new SqlParameter("@marcaId", MarcaId));
                parameters.Add(new SqlParameter("@categoriaId", CategoriaId));

                if (new AcessoDAO().Consultar(sql.ToString(), parameters).Rows.Count > 0)
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
