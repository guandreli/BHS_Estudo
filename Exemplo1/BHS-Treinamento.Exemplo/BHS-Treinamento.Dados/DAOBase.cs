using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHS_Treinamento.Dados
{
    public class DAOBase
    {
        public string ConnectionString { get; set; }

        public DAOBase()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
    }
}
