using Microsoft.EntityFrameworkCore;
using MrZhao_NetCorePro_Entity;
using System;

namespace MrZhao_NetCorePro_DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=NetCoreDB;User ID=sa;Password=8;MultipleActiveResultSets=true");
           // base.OnConfiguring(optionsBuilder);
        }

        public DbSet<WebSite> WebSites { get; set; }

    }
}
