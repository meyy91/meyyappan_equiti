using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Test.Interfaces;

namespace RESTful.Services.App_Start
{
    public static class AutoFacConfig
    {
        public static void Resolve()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<IFinanceBusinessLogics>().AsImplementedInterfaces();

            builder.RegisterType<IFinanceDataAccess>().AsImplementedInterfaces();
        }
    }
}