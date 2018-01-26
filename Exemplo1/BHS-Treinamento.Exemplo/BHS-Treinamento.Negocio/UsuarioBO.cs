using BHS_Treinamento.Dados;
using BHS_Treinamento.Dominio;
using System.Data;

namespace BHS_Treinamento.Negocio
{
    public class UsuarioBO
    {
        public DataTable GetAll()
        {
            var usuarioDAO = new UsuarioDAO();
            return usuarioDAO.GetAll();
        }

        public int Create(Usuario usuario)
        {
            //if (usuario.Email.EndsWith("crmmg.com.br"))
            //{
                var usuarioDAO = new UsuarioDAO();
                return usuarioDAO.Create(usuario);
            //}
            //else
            //{
            //    return 0;
            //}
        }
    }
}
