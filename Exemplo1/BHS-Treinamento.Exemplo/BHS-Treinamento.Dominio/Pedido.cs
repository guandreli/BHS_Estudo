using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHS_Treinamento.Dominio
{
    public class Pedido : DominioBase
    {
        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public decimal ValorTotal { get; set; }

        public bool Valido { get; set; }

        public int IDUsuario { get; set; }
    }
}
