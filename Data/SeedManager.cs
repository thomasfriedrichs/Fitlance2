using Fitlance.Constants;
using Microsoft.AspNetCore.Identity;

namespace Fitlance.Data;

public static class SeedManager
{
    public static async Task Seed(IServiceProvider services)
    {
        await SeedRoles(services);
    }

    private static async Task SeedRoles(IServiceProvider services)
    {
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

        await roleManager.CreateAsync(new IdentityRole(RoleConstants.User));

        await roleManager.CreateAsync(new IdentityRole(RoleConstants.Trainer));
    }
}