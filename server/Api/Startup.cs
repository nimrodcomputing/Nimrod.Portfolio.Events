﻿using Microsoft.Owin;
using Nimrod.Portfolio.Events.Api;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Nimrod.Portfolio.Events.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
