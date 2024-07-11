using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Models;

namespace WarehouseApp.Data
{
    public class WarehouseDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Participant> Participants { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }  

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=;database=warehouse_app";
            var serverVersion = new MySqlServerVersion(new Version(10, 4, 27));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

    }
}
