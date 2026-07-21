using Microsoft.EntityFrameworkCore;
using University.Infrastructure.Data;

namespace University.APIs.Middlewares
{
    public static class ApplyMigrations
    {

        public static async Task ApplyMigrationAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            await dbContext.Database.MigrateAsync();
        }
    }
}
