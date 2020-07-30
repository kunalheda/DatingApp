using Microsoft.EntityFrameworkCore;
using Dating1App.api.Modules;
namespace Dating1App.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<Value> val   { get; set; }

        public DbSet<User> Users {get; set;} 
    }
}