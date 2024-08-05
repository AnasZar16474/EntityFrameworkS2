using EntityFrameworkS2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkS2.Data
{
    internal class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=EntityFrameWork2;Trusted_Connection=True;TrustServerCertificate=True");
        }
        DbSet<Employee> Employees { get; set; }
        DbSet<Depatment> Depatments { get; set; }
    }
}
