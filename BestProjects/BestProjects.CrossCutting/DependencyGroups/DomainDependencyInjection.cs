using BestProjects.Domain.IBusiness.Migration;
using BestProjects.Migration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestProjects.CrossCutting.DependencyGroups
{
    public class DomainDependencyInjection
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IMigrationBusiness, MigrationBusiness>();

            //serviceCollection.AddTransient<ICategoriaSorteioBusiness, CategoriaSorteioBusiness>();
        }
    }
}
