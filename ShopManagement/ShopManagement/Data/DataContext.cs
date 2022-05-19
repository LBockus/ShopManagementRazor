using Microsoft.EntityFrameworkCore;
using ShopManagement.Models;

namespace ShopManagement.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ShopItem> shopItems { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
