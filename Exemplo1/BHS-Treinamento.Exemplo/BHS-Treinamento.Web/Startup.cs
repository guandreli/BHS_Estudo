using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BHS_Treinamento.Web.Startup))]
namespace BHS_Treinamento.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
