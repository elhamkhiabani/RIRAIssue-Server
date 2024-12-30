
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RIRA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIRA.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.ID);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(500);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(500);
            builder.Property(x => x.NID).HasMaxLength(10);
            builder.Property(x => x.BirthDate).HasMaxLength(10);
            builder.Property(x => x.IsActive);
            builder.Property(x => x.IsDelete);
            builder.Property(x=>x.CreationDateTime);
            builder.Property(x => x.CreatorID);
            builder.Property(x => x.ModifierDateTime);
            builder.Property(x => x.ModifierID);

        }
    }
}
