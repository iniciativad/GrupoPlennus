using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GrupoPlennus.HabitacaoMvc.Startup))]
namespace GrupoPlennus.HabitacaoMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
