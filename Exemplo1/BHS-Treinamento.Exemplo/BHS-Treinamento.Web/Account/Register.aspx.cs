using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using BHS_Treinamento.Web.Models;
using BHS_Treinamento.Dominio;
using BHS_Treinamento.Negocio;

namespace BHS_Treinamento.Web.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario
            {
                Nome = Nome.Text,
                Email = Email.Text,
                Senha = Password.Text
            };

            var usuarioBO = new UsuarioBO();
            if (usuarioBO.Create(u) > 0)
                Response.Redirect("~/Usuarios.aspx");
        }
    }
}