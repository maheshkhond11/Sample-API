using DTOs;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Infrastructure;
using System.Reflection.Emit;

namespace Models.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           Database.EnsureCreated();
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Brand>? Brands { get; set; }
        public DbSet<Phone>? Phones { get; set; }
        public DbSet<Sale>? Sales { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<TempDTO> QRecords { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TempDTO>().HasNoKey();
        }


    }
}
