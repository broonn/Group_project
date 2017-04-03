using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookStoreWebApp.Startup))]
namespace BookStoreWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
