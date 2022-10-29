using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyApi.Dal.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        List<Guid> allowDataGroups = new List<Guid> { new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6") };
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasQueryFilter(x => allowDataGroups.Contains(x.DataGroup));
        }
    }
}
