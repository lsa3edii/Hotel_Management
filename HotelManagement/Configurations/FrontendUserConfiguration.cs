using Lab15.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Configurations
{
    class FrontendUserConfiguration : IEntityTypeConfiguration<FrontendUser>
    {
        public void Configure(EntityTypeBuilder<FrontendUser> builder)
        {
            builder.ToTable("Admins");

            builder.HasIndex(u => u.Username)
                    .IsUnique();

            builder.HasBaseType<User>();
        }

    }
}
