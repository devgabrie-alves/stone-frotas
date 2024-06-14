using GerenciadorFrotas.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GerenciadorFrotas.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        public Usuario()
        {
            Id = 0;
            Login = string.Empty;
            Nome = string.Empty;
            Email = string.Empty;
            Senha = string.Empty;
            Ativo = false;
        }

        AcessoDAO acessoDAO = new AcessoDAO();
        DataTable dt = new DataTable();
        List<SqlParameter> parameters = new List<SqlParameter>();
        string sql = string.Empty;

        public DataTable Consultar()
        {
            try
            {
                parameters.Clear();
                sql = "select id, login, nome, email, senha, ativo \n";
                sql += "from tblUsuario \n";

                if (Id != 0)
                {
                    sql += "where id = @id \n";
                    parameters.Add(new SqlParameter("@id", Id));

                } else if (Login != string.Empty)
                {
                    sql += "where login = @Login \n";
                    parameters.Add(new SqlParameter("@Login", Login));

                } else if (Nome != string.Empty)
                {
                    sql += "where nome like @nome \n";
                    parameters.Add(new SqlParameter("@nome", '%' + Nome + '%'));
                }
                dt = acessoDAO.Consultar(sql, parameters);

                if (Id != 0 || Login != string.Empty && dt.Rows.Count == 1)
                {
                    Id = Convert.ToInt32(dt.Rows[0]["id"]);
                    Login = dt.Rows[0]["login"].ToString();
                    Email = dt.Rows[0]["email"].ToString();
                    Nome = dt.Rows[0]["nome"].ToString();
                    Senha = dt.Rows[0]["Senha"].ToString();
                    Ativo = Convert.ToBoolean(dt.Rows[0]["ativo"]);
                }

                return dt;
            } catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public bool Autenticar(string senha)
        {
            return senha == Senha;
        }

        public void Gravar()
        {
            try
            {
                parameters.Clear();

                if (Id == 0)
                {
                    sql = "INSERT INTO tblUsuario \n";
                    sql += "(login, nome, email, senha, ativo) \n";
                    sql += "VALUES \n";
                    sql += "(@login, @nome, @email, @senha, @ativo) \n";

                } else
                {
                    sql = "UPDATE tblUsuario \n";
                    sql += "SET \n";
                    sql += "login       = @login, \n";
                    sql += "nome        = @nome, \n";
                    sql += "email       = @email, \n";
                    sql += "senha       = @senha, \n";
                    sql += "ativo       = @ativo \n";
                    sql += "WHERE id = @id \n";

                    parameters.Add(new SqlParameter("@id", Id));
                }

                parameters.Add(new SqlParameter("@login", Login));
                parameters.Add(new SqlParameter("@nome", Nome));
                parameters.Add(new SqlParameter("@email", Email));
                parameters.Add(new SqlParameter("@senha", Senha));
                parameters.Add(new SqlParameter("@ativo", Ativo));

                acessoDAO.Executar(sql, parameters);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
