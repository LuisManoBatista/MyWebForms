using Microsoft.Owin;
using Owin;
using System.Web.Optimization;
using System.Web.Routing;

[assembly: OwinStartup(typeof(MyWebForms.Startup))]
namespace MyWebForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            RegisterRoutes(RouteTable.Routes);
            RegisterBundles(BundleTable.Bundles);
            RegisterServices();
        }
    }
}