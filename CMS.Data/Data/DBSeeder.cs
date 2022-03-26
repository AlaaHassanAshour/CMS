using CMS.Data;
using CMS.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CMS.Data
{
    public static class DBSeeder
    {
        public static IHost SeedDb(this IHost webHost)
        {
            using (var scope = webHost.Services.CreateScope())
            {
                try
                {

                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<CMS.Data.Models.User>>();
                    userManager.SeedUser().Wait();

                    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    context.SeedCategory().Wait();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
            return webHost;
        }

        public static async Task SeedUser(this UserManager<CMS.Data.Models.User> userManager)
        {
            if (await userManager.Users.AnyAsync())
            {
                return;
            }

            var user = new CMS.Data.Models.User
            {
                Email = "CMS@portal.com",
                FirstName = "CMS",
                LastName = "User",
                UserName = "CMS@portal.com",
                PhoneNumber = "0595555555",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true
            };

            await userManager.CreateAsync(user, "CMSAdmin2020$$");

        }

        public static async Task SeedCategory(this ApplicationDbContext context)
        {

            if (await context.Categories.AnyAsync())
            {
                return;
            }

            var category = new CategoryDbEntity();
            category.Name = "A1";
            category.CreatedAt = DateTime.Now;

            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();

        }
    }
}
