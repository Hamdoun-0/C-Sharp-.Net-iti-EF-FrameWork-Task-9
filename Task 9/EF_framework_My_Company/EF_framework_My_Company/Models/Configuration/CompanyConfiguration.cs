using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_framework_My_Company.Models.Configuration
{
    public class CompanyConfiguration :IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("tblCompany");
            builder.HasKey(c => c.Companyid);
            builder.Property(c => c.name).IsRequired().HasMaxLength(150);
            builder.Property(c => c.Address).IsRequired().HasMaxLength(200);

        }
    }
}
