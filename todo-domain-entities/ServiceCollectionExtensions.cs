using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using todo_domain_entities.Context;

namespace todo_domain_entities
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ToDoContext>(opts =>
                opts.UseSqlServer(configuration.GetConnectionString("ToDoListConnection")));
            return services;
        }
    }
}
