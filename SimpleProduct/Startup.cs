using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleProduct.Startup))]
namespace SimpleProduct
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
