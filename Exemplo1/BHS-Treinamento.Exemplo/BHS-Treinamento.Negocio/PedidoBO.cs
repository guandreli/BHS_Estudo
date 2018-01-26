using BHS_Treinamento.Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHS_Treinamento.Negocio
{
    public class PedidoBO
    {
        public DataTable GetAll()
        {
            var pedidoDAO = new PedidoDAO();
            return pedidoDAO.GetAll();
        }
    }
}
