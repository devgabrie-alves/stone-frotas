using GerenciadorFrotas.Data;
using GerenciadorFrotas.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Transactions;

namespace GerenciadorFrotas.Model
{
    public class Oficina
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string UrlSite { get; set; }
        public string Telefone { get; set; }
        public int UsuarioId { get; set; }
        public EnderecoOficina Endereco { get; set; }

        public Oficina()
        {
            Id = 0;
            RazaoSocial = string.Empty;
            NomeFantasia = string.Empty;
            CNPJ = string.Empty;
            Email = string.Empty;
            UrlSite = string.Empty;
            Telefone = string.Empty;
            UsuarioId = 0;
            Endereco = new EnderecoOficina();
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

                sql.Append("SELECT id, razaoSocial, nomeFantasia, cnpj, email, urlSite, telefone, usuarioId \n");
                sql.Append("FROM tblOficina \n");

                if (Id != 0)
                {
                    sql.Append("WHERE id = @id \n");
                    parameters.Add(new SqlParameter("@id", Id));
                }
                else if (CNPJ != string.Empty)
                {
                    sql.Append("WHERE cnpj = @cnpj \n");
                    parameters.Add(new SqlParameter("@CNPJ", CNPJ));
                }
                else if (NomeFantasia != string.Empty)
                {
                    sql.Append("WHERE nomeFantasia like @nomeFantasia \n");
                    parameters.Add(new SqlParameter("@nomeFantasia", '%' + NomeFantasia + '%'));
                }

                dataTable = acessoDAO.Consultar(sql.ToString(), parameters);

                if (Id != 0 || CNPJ != string.Empty && dataTable.Rows.Count == 1)
                {
                    Id = Convert.ToInt32(dataTable.Rows[0]["id"]);
                    RazaoSocial = dataTable.Rows[0]["razaoSocial"].ToString();
                    NomeFantasia = dataTable.Rows[0]["nomeFantasia"].ToString();
                    CNPJ = dataTable.Rows[0]["cnpj"].ToString();
                    Email = dataTable.Rows[0]["email"].ToString();
                    UrlSite = dataTable.Rows[0]["urlSite"].ToString();
                    Telefone = dataTable.Rows[0]["telefone"].ToString();
                    UsuarioId = Convert.ToInt32(dataTable.Rows[0]["usuarioId"]);

                    Endereco.OficinaId = Id;
                    Endereco.Consultar();
                }
                return dataTable;
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
                using (TransactionScope transacao = new TransactionScope())
                {
                    parameters.Clear();

                    if (Id == 0)
                    {
                        sql.Append("INSERT INTO tblOficina \n");
                        sql.Append("(razaoSocial, nomeFantasia, cnpj, email, urlSite, telefone, usuarioId) \n");
                        sql.Append("VALUES \n");
                        sql.Append("(@razaoSocial, @nomeFantasia, @cnpj, @email, @urlSite, @telefone, @usuarioId); \n");
                        sql.Append("SELECT @@IDENTITY ");
                    }
                    else
                    {
                        sql.Append("UPDATE tblOficina \n");
                        sql.Append("SET \n");
                        sql.Append("razaoSocial         = @razaoSocial, \n");
                        sql.Append("nomeFantasia        = @nomeFantasia, \n");
                        sql.Append("cnpj                = @cnpj, \n");
                        sql.Append("email               = @email, \n");
                        sql.Append("urlSite             = @urlSite, \n");
                        sql.Append("telefone            = @telefone, \n");
                        sql.Append("usuarioId           = @usuarioId \n");
                        sql.Append("WHERE id = @id \n");

                        parameters.Add(new SqlParameter("@id", Id));
                    }

                    parameters.Add(new SqlParameter("@razaoSocial", RazaoSocial));
                    parameters.Add(new SqlParameter("@nomeFantasia", NomeFantasia));
                    parameters.Add(new SqlParameter("@cnpj", CNPJ));
                    parameters.Add(new SqlParameter("@email", Email));
                    parameters.Add(new SqlParameter("@urlSite", UrlSite));
                    parameters.Add(new SqlParameter("@telefone", Telefone));
                    parameters.Add(new SqlParameter("@usuarioId", DatabaseUtils.IdUsuarioLogado));

                    if (Id == 0)
                    {
                        Id = acessoDAO.Executar(parameters, sql.ToString());
                    }
                    else
                    {
                        acessoDAO.Executar(sql.ToString(), parameters);
                    }

                    Endereco.OficinaId = Id;
                    Endereco.Gravar();

                    transacao.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
