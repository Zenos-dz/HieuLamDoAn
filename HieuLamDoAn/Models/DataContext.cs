using Microsoft.EntityFrameworkCore;
namespace HieuLamDoAn.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<TeamMembers> TeamMembers { get; set; }
    }
}
