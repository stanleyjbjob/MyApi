using Microsoft.EntityFrameworkCore;

namespace MyApi.Dal
{
    public class MyDataContext : DbContext
    {
        protected MyDataContext()
        {

        }

        public MyDataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }

    }
}
