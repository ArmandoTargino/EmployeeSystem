using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationEF.Models;

namespace WebApplicationEF.DataAccess
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options): base(options) { }
        public DbSet<Department> Company { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Vacation> Vacation { get; set; }
    }
}
