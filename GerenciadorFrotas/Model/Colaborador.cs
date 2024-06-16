using GerenciadorFrotas.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GerenciadorFrotas.Model
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Celular { get; set; }
        public int SexoId { get; set; }
        public int StatusId { get; set; }
        public int UsuarioId { get; set; }


        public Colaborador()
        {
            Id = 0;
            Nome = string.Empty;
            CPF = string.Empty;
            Email = string.Empty;
            DataAdmissao = DateTime.MinValue;
            Celular = string.Empty;
            SexoId = 0;
            StatusId = 0;
            UsuarioId = 0;
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

                sql.Append("select id, nome, CPF, email, dataAdmissao, celular, sexoId, statusId, usuarioId \n");
                sql.Append("from tblColaborador \n");

                if (Id != 0)
                {
                    sql.Append("where id = @id \n");
                    parameters.Add(new SqlParameter("@id", Id));

                } else if (CPF != string.Empty)
                {
                    sql.Append("where CPF = @CPF \n");
                    parameters.Add(new SqlParameter("@CPF", CPF));

                } else if (Nome != string.Empty)
                {
                    sql.Append("where nome like @nome \n");
                    parameters.Add(new SqlParameter("@nome", '%' + Nome + '%'));
                }

                dataTable = acessoDAO.Consultar(sql.ToString(), parameters);

                if (Id != 0 || CPF != string.Empty && dataTable.Rows.Count == 1)
                {
                    Id = Convert.ToInt32(dataTable.Rows[0]["id"]);
                    Nome = dataTable.Rows[0]["nome"].ToString();
                    CPF = dataTable.Rows[0]["CPF"].ToString();
                    Email = dataTable.Rows[0]["email"].ToString();
                    DataAdmissao = Convert.ToDateTime(dataTable.Rows[0]["dataAdmissao"]);
                    Celular = dataTable.Rows[0]["Celular"].ToString();
                    SexoId = Convert.ToInt32(dataTable.Rows[0]["sexoId"]);
                    StatusId = Convert.ToInt32(dataTable.Rows[0]["statusId"]);
                    UsuarioId = Convert.ToInt32(dataTable.Rows[0]["usuarioId"]);
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
                    sql.Append("INSERT INTO tblColaborador \n");
                    sql.Append("(nome, CPF, email, dataAdmissao, celular, sexoId, statusId, usuarioId) \n");
                    sql.Append("VALUES \n");
                    sql.Append("(@nome, @CPF, @email, @dataAdmissao, @celular, @sexoId, @statusId, @usuarioId); \n");

                    parameters.Add(new SqlParameter("@usuarioId", UsuarioId));

                } else
                {
                    sql.Append("UPDATE tblColaborador \n");
                    sql.Append("SET \n");
                    sql.Append("nome                = @nome, \n");
                    sql.Append("CPF                 = @CPF, \n");
                    sql.Append("email               = @email, \n");
                    sql.Append("dataAdmissao        = @dataAdmissao, \n");
                    sql.Append("celular             = @celular, \n");
                    sql.Append("sexoId              = @sexoId, \n");
                    sql.Append("statusId            = @statusId \n");
                    sql.Append("WHERE id = @id \n");

                    parameters.Add(new SqlParameter("@id", Id));
                }

                parameters.Add(new SqlParameter("@nome", Nome));
                parameters.Add(new SqlParameter("@CPF", CPF));
                parameters.Add(new SqlParameter("@email", Email));
                parameters.Add(new SqlParameter("@dataAdmissao", DataAdmissao));
                parameters.Add(new SqlParameter("@celular", Celular));
                parameters.Add(new SqlParameter("@sexoId", SexoId));
                parameters.Add(new SqlParameter("@statusId", StatusId));
                

                acessoDAO.Executar(sql.ToString(), parameters);

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
