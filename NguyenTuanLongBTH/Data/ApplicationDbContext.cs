using NguyenTuanLongBTH_02.Models;
using System.Collections.Generic;

namespace NguyenTuanLongBTH_02.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<NguyenTuanLongBTH_02.Models.Employee> Employee { get; set; }
        public DbSet<NguyenTuanLongBTH_02.Models.Student> Student { get; set; }
        public DbSet<NguyenTuanLongBTH_02.Models.Customer> Customer { get; set; }
        public DbSet<NguyenTuanLongBTH_02.Models.Person> Person { get; set; }
    }
}