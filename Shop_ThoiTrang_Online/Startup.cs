using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shop_ThoiTrang_Online.Startup))]
namespace Shop_ThoiTrang_Online
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
