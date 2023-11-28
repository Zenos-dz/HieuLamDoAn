using HieuLamDoAn.Models;
using HieuLamDoAn.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
namespace HieuLamDoAn.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<TeamMembers> TeamMembers { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<AdminMenu> AdminMenu { get; set; }
        public DbSet<FoodMenu> FoodMenus { get; set; }
        public DbSet<TypeFood> TypeFood { get; set;}
    }
}
