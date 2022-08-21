using Alsi.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace Alsi.API.Data
{
    public class Seed
    {
        public static async Task SeedUsersAsync(DataContext context)
        {
            if (await context.Users.AnyAsync()) return;

            var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
            var users = JsonSerializer.Deserialize<List<GameUser>>(userData);

            foreach (var user in users)
            {
                context.Users.Add(user);
            }

            await context.SaveChangesAsync();
        }
    }
}
