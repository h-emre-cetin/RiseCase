using Microsoft.EntityFrameworkCore;
using RiseCase.Models;
using System.Reflection;

namespace RiseCase.Repositories.EntityFramework
{
    public class RiseStudyContext : DbContext
    {

        public RiseStudyContext() : base()
        {

        }

        public RiseStudyContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<ContactModel> Contacts { get; set; }

        public DbSet<ContactInfoModel> ContactsInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=contact;Integrated Security=True";


                optionsBuilder.UseSqlServer(connStr, opt =>
                {
                    opt.EnableRetryOnFailure();
                });
            }
        }
    }
}
