using Libs;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.CoffeeShop.Orm.Configuration
{
    internal class EmployeeConfiguration
    {
        public class TodoConfiguration : IEntityTypeConfiguration<Employee>
        {
            public void Configure(EntityTypeBuilder<Employee> builder)
            {
                builder.ToTable("Employee");

                builder.HasKey(employee => employee.ID);

                builder.Property(employee => employee.ID).ValueGeneratedOnAdd();
                builder.Property(employee => employee.Name).HasMaxLength(50).IsRequired(true);
                builder.Property(employee => employee.Surname).HasMaxLength(50).IsRequired(true);
            }
        }
    }
}
