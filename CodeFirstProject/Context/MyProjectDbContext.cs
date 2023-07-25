using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstProject.Context
{
    public class MyProjectDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MyProject;User Id=rchn;Password=1234;Encrypt=False;TrustServerCertificate=False;");
        }
    }
    public class Start
    {
        public static void Main(string[] args)
        {
        }
    }
}
