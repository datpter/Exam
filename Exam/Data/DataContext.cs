using Exam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data
{
    public class DataContext : DbContext
    {
        private readonly string _connectionString = "Server=LAPTOP-HP52IBIJ\\SQLEXPRESS; Database=Exam; User Id=sa; Password=12345678; Trusted_Connection=True; TrustServerCertificate=True;MultipleActiveResultSets=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        // Day la cac bang ma EF se tao cho minh trong SQL Server
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
