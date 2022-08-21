using Alsi.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Alsi.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<GameUser> Users { get; set; }
    }
}