using BestProjects.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestProjects.CrossCutting.DependencyGroups
{
    public class DataDependencyInjection
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<SqlDataContext, SqlDataContext>();

            //serviceCollection.AddTransient<ICategoriaSorteioRepository, CategoriaSorteioRepository>();
        }
    }
}
