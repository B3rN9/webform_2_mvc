using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_2_webform_mvc.Startup))]
namespace mvc_2_webform_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
