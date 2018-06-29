using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using RESTful.Services.App_Start;

[assembly: OwinStartup(typeof(RESTful.Services.Startup))]

namespace RESTful.Services
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            AutoFacConfig.Resolve();
        }
    }
}
