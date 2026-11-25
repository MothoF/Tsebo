using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Tsebo.Repository;
using Tsebo.Services;

namespace Tsebo.Tests
{
    internal class CustomWebApplicationFactory : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseEnvironment("Development");

            builder.ConfigureServices((context, services) => {
                var connectionString = context.Configuration.GetConnectionString("TseboTestDb");

                services.RemoveAll<DbContextOptions<ApplicationDbContext>>();
                services.RemoveAll<ApplicationDbContext>();
                services.RemoveAll<IApplicationRepositoryService>();
                services.RemoveAll<AppRepositoryServiceImpl>();

                services.AddScoped<IApplicationRepositoryService, AppRepositoryServiceImpl>();
                services.AddNpgsql<ApplicationDbContext>(connectionString); 
            });
        }
    }
}
