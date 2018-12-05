using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WelathArchitect_Presenter.Startup))]
namespace WelathArchitect_Presenter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
