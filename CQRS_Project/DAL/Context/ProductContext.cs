using CQRS_Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Project.DAL.Context
{
    public class ProductContext:DbContext
	{

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:127.0.0.1,1433;Database=CQRSProject;MultipleActiveResultSets=true;User=SA;Password=MyPass@word;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<University> Universities { get; set; }

    }
}

