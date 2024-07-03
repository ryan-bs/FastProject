using FastProject.Data;
using Microsoft.EntityFrameworkCore;

namespace FastProject.Extensions;

public static class MigrationExtensions
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();

        using ProjectContext context =
            scope.ServiceProvider.GetRequiredService<ProjectContext>();

        context.Database.Migrate();
    }
}
