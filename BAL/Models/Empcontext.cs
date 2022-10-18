using IObjects;
using Microsoft.EntityFrameworkCore;
using BLL.Models;
namespace BLL.Models
{
    public class Empcontext : DbContext
    {
        public Empcontext(DbContextOptions options)
        : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmpId = 1,
                EmpName = "Jhon",
                Empgender = "Male",
                EmpDob = new DateTime(2000, 01, 01),
                EmpEmail = "jhon@gmail.com",
                EmpDep = "Devloper"


            });
        }
    }
}