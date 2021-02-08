using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    class DeviceContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }

        public DeviceContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NS5SE09\\SQLEXPRESS;Database=MyDatabase;Trusted_Connection=True;");
        }

    }
}
