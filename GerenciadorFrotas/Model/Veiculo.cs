using GerenciadorFrotas.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace GerenciadorFrotas.Model
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public decimal QuilometragemInicial { get; set; }
        public decimal QuilometragemAtual { get; set; }
        public bool Ativo { get; set; }

        public Veiculo()
        {
            Id = 0;
            Marca = string.Empty;
            Modelo = string.Empty;
            Placa = string.Empty;
            Chassi = string.Empty;
            QuilometragemInicial = 0;
            QuilometragemAtual = 0;
            Ativo = false;
        }

        AcessoDAO acessoDAO = new AcessoDAO();
        DataTable dataTable = new DataTable();
        List<SqlParameter> parameters = new List<SqlParameter>();
        string sql = string.Empty;

        public DataTable Consultar()
        {
            try
            {
                parameters.Clear();

                sql = "select \n";
                sql += "    id, \n";
                sql += "    marca, \n";
                sql += "    modelo, \n";
                sql += "    placa, \n";
                sql += "    chassi, \n";
                sql += "    quilometragemInicial, \n";
                sql += "    quilometragemAtual, \n";
                sql += "    ativo \n";
                sql += "from tblVeiculo  \n";

                if (Id != 0)
                {
                    sql += "where id = @id \n";
                    parameters.Add(new SqlParameter("@id", Id));
                }
                else if (Placa != string.Empty)
                {
                    sql += "where placa = @placa \n";
                    parameters.Add(new SqlParameter("@placa", Placa));
                }
                else if (Chassi != string.Empty)
                {
                    sql += "where chassi = @chassi \n";
                    parameters.Add(new SqlParameter("@chassi", Chassi));
                }

                dataTable = acessoDAO.Consultar(sql, parameters);

                if (Id != 0 || Placa != string.Empty && dataTable.Rows.Count == 1)
                {
                    Id = Convert.ToInt32(dataTable.Rows[0]["id"]);
                    Marca = dataTable.Rows[0]["marca"].ToString();
                    Modelo = dataTable.Rows[0]["modelo"].ToString();
                    Placa = dataTable.Rows[0]["placa"].ToString();
                    Chassi = dataTable.Rows[0]["chassi"].ToString();
                    QuilometragemInicial = Convert.ToInt32(dataTable.Rows[0]["quilometragemInicial"]);
                    QuilometragemAtual = Convert.ToInt32(dataTable.Rows[0]["quilometragemAtual"]);
                    Ativo = Convert.ToBoolean(dataTable.Rows[0]["ativo"]);
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
            try
            {
                using (TransactionScope transacao = new TransactionScope())
                {
                    parameters.Clear();

                    if (Id == 0)
                    {
                        sql = "INSERT INTO tblVeiculo \n";
                        sql += "(marca, modelo, placa, chassi, quilometragemInicial, quilometragemFinal, usuarioId) \n";
                        sql += "VALUES \n";
                        sql += "(@marca, @modelo, @placa, @chassi, @quilometragemInicial, @quilometragemFinal, @usuarioId); \n";
                        sql += "SELECT @@IDENTITY ";
                    }
                    else
                    {
                        sql = "UPDATE tblVeiculo \n";
                        sql += "SET \n";
                        sql += "marca                   = @marca, \n";
                        sql += "modelo                  = @modelo, \n";
                        sql += "placa                   = @placa, \n";
                        sql += "chassi                  = @chassi, \n";
                        sql += "quilometragemInicial    = @quilometragemInicial, \n";
                        sql += "quilometragemFinal      = @quilometragemFinal, \n";
                        sql += "usuarioId           = @usuarioId \n";
                        sql += "WHERE id = @id \n";

                        parameters.Add(new SqlParameter("@id", Id));
                    }

                    parameters.Add(new SqlParameter("@marca", Marca));
                    parameters.Add(new SqlParameter("@modelo", Modelo));
                    parameters.Add(new SqlParameter("@placa", Placa));
                    parameters.Add(new SqlParameter("@chassi", Chassi));
                    parameters.Add(new SqlParameter("@quilometragemInicial", QuilometragemInicial));
                    parameters.Add(new SqlParameter("@quilometragemFinal", QuilometragemAtual));
                    parameters.Add(new SqlParameter("@usuarioId", Id));

                    acessoDAO.Executar(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
