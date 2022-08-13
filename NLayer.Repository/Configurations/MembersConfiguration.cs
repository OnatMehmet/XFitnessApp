using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class MembersConfiguration : IEntityTypeConfiguration<Members>
    {
        public void Configure(EntityTypeBuilder<Members> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();  
            builder.Property(x=>x.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(x=>x.LastName).HasMaxLength(50).IsRequired();

            builder.ToTable("Members");

            builder.HasOne(x=>x.Category).WithMany(x=>x.Members).HasForeignKey(x=>x.CategoryId);
            
        }
    }
}
