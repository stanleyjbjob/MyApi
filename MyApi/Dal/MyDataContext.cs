using Microsoft.EntityFrameworkCore;
using MyApi.Dal.Configuration;
using System.Reflection;

namespace MyApi.Dal
{
    public class MyDataContext : DbContext
    {
        protected MyDataContext()
        {

        }

        public MyDataContext(DbContextOptions<MyDataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<DataGroup> DataGroup { get; set; }

    }
}
