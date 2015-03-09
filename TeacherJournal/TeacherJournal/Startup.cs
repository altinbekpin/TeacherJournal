using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeacherJournal.Startup))]
namespace TeacherJournal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
