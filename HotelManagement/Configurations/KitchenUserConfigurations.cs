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
    class KitchenUserConfigurations : IEntityTypeConfiguration<KitchenUser>
    {
        public void Configure(EntityTypeBuilder<KitchenUser> builder)
        {
            builder.HasIndex(u => u.Username)
                       .IsUnique();

            builder.HasBaseType<User>();
        }

    }
}
