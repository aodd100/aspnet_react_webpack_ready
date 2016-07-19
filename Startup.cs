using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BisterGram.Startup))]
namespace BisterGram
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
