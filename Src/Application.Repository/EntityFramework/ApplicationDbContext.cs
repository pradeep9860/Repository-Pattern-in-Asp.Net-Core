using Application.Core.Entity;
using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Application.Repository.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        } 

        //all dbset here
        public DbSet<MasterCompany> MasterCompany { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Division> Division { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
        }
    } 
}
