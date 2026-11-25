using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Tsebo.Repository
{
    public static class AppExtensionMethods
    {
        public static void AutoUpdateDatabase(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            dbContext.Database.Migrate();
        }
    }
}
