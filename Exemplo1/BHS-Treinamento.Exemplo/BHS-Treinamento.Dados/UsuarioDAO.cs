using BHS_Treinamento.Dominio;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BHS_Treinamento.Dados
{
    public class UsuarioDAO : DAOBase
    {
        public DataTable GetAll()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT [ID]
                                              ,[Nome]
                                              ,[Email]
                                        FROM [dbo].[Usuario]";

                    //var da = new SqlDataAdapter(command);
                    var dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Nome");
                    dt.Columns.Add("Email");
                    //da.Fill(dt);

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var dr = dt.NewRow();
                        dr["ID"] = reader["ID"];
                        dr["Nome"] = reader["Nome"];
                        dr["Email"] = reader["Email"];

                        dt.Rows.Add(dr);
                    }

                    return dt;
                }
            }
        }

        public int Create(Usuario usuario)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //command.CommandText = @"INSERT INTO Usuario VALUES(@Nome, @Email, @Senha)";
                    command.CommandText = "sp_CriarUsuario";
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter[] parameters = new[]
                    {
                        new SqlParameter("@Nome", usuario.Nome),
                        new SqlParameter("@Email", usuario.Email),
                        new SqlParameter("@Senha", usuario.Senha)
                    };
                    //command.Parameters.AddWithValue("@Nome", usuario.Nome);
                    //command.Parameters.AddWithValue("@Email", usuario.Email);
                    //command.Parameters.AddWithValue("@Senha", usuario.Senha);

                    command.Parameters.AddRange(parameters);
                    //var ret = command.ExecuteNonQuery();
                    var ret = command.ExecuteScalar();

                    return Convert.ToInt32(ret);
                }
            }
        }
    }
}
