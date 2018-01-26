using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHS_Treinamento.Dados
{
    public class PedidoDAO : DAOBase
    {
        //public DataTable GetAll()
        //{
        //    using (var connection = new SqlConnection(ConnectionString))
        //    {
        //        connection.Open();

        //        using (var command = new SqlCommand())
        //        {
        //            command.Connection = connection;
        //            command.CommandText = @"SELECT p.[ID]
        //                                      ,p.[Descricao]
        //                                      ,p.[Quantidade]
        //                                      ,p.[ValorTotal]
        //                                      ,u.[Nome] as 'Usuário'
        //                                FROM [dbo].[Pedido] p
        //                                    JOIN [dbo].[Usuario] u ON p.IDUsuario = u.ID";

        //            var da = new SqlDataAdapter(command);
        //            var dt = new DataTable();
        //            da.Fill(dt);

        //            return dt;
        //        }
        //    }
        //}

        public DataTable GetAll()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "GetAllPedidos";
                    command.CommandType = CommandType.StoredProcedure;

                    var da = new SqlDataAdapter(command);
                    var dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
        }
    }
}
