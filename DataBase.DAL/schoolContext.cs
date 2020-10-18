using Microsoft.EntityFrameworkCore;
using System;

namespace DataBase.DAL
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=True;Initial Catalog=firstweb;Data Source=NARGES");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }
    }
}
