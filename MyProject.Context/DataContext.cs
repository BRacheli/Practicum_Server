using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyProject.Repositories;
using MyProject.Repositories.Entities;

namespace MyProject.Context
{
    public class DataContext : DbContext, IContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=UsersProject;Trusted_Connection=True;");
        }
    }
}