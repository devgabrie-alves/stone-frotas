using GerenciadorFrotas.Data;
using GerenciadorFrotas.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace GerenciadorFrotas.Model
{
    public class EnderecoOficina
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public int CidadeId { get; set; }
        public int OficinaId { get; set; }

        public EnderecoOficina()
        {
            Id = 0;
            Logradouro = string.Empty;
            Numero = string.Empty;
            Complemento = string.Empty;
            Bairro = string.Empty;
            CEP = string.Empty;
            CidadeId = 0;
            OficinaId = 0;
        }

        AcessoDAO acessoDAO = new AcessoDAO();
        DataTable dt = new DataTable();
        List<SqlParameter> parameters = new List<SqlParameter>();
        StringBuilder sql;

        public void Consultar()
        {
            sql = new StringBuilder();

            try
            {
                parameters.Clear();

                sql.Append(" SELECT id, logradouro, numero, complemento, \n");
                sql.Append(" bairro, CEP, cidadeId, oficinaId \n");
                sql.Append(" FROM tblEnderecoOficina \n");
                sql.Append(" WHERE oficinaId = @oficinaId ");

                parameters.Add(new SqlParameter("@oficinaId", OficinaId));

                dt = acessoDAO.Consultar(sql.ToString(), parameters);

                if (dt.Rows.Count > 0)
                {
                    Id = Convert.ToInt32(dt.Rows[0]["id"]);
                    Logradouro = dt.Rows[0]["logradouro"].ToString();
                    Numero = dt.Rows[0]["numero"].ToString();
                    Complemento = dt.Rows[0]["complemento"].ToString();
                    Bairro = dt.Rows[0]["bairro"].ToString();
                    CEP = dt.Rows[0]["CEP"].ToString();
                    CidadeId = Convert.ToInt32(dt.Rows[0]["cidadeId"]);
                    OficinaId = Convert.ToInt32(dt.Rows[0]["oficinaId"]);
                }

            }
            catch (Exception ex)
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
                    sql.Append("INSERT INTO tblEnderecoOficina \n");
                    sql.Append("(logradouro, numero, complemento, bairro, CEP, cidadeId, oficinaId) \n");
                    sql.Append("VALUES \n");
                    sql.Append("(@logradouro, @numero, @complemento, @bairro, @CEP, @cidadeId, @oficinaId) \n");
                }
                else
                {
                    sql.Append("UPDATE tblEnderecoOficina \n");
                    sql.Append("SET \n");
                    sql.Append("logradouro      = @logradouro, \n");
                    sql.Append("numero          = @numero, \n");
                    sql.Append("complemento     = @complemento, \n");
                    sql.Append("bairro          = @bairro, \n");
                    sql.Append("CEP             = @CEP, \n");
                    sql.Append("cidadeId        = @cidadeId, \n");
                    sql.Append("oficinaId       = @oficinaId \n");
                    sql.Append("WHERE id = @id \n");

                    parameters.Add(new SqlParameter("@id", Id));
                }

                parameters.Add(new SqlParameter("@logradouro", Logradouro));
                parameters.Add(new SqlParameter("@numero", Numero));
                parameters.Add(new SqlParameter("@complemento", Complemento));
                parameters.Add(new SqlParameter("@bairro", Bairro));
                parameters.Add(new SqlParameter("@CEP", CEP));
                parameters.Add(new SqlParameter("@cidadeId", CidadeId));
                parameters.Add(new SqlParameter("@oficinaId", OficinaId));

                acessoDAO.Executar(sql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
