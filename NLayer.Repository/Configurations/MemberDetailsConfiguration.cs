﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class MemberDetailsConfiguration : IEntityTypeConfiguration<MemberDetails>
    {
        public void Configure(EntityTypeBuilder<MemberDetails> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x=>x.Members).WithOne(x=>x.MemberDetails).HasForeignKey<MemberDetails>(x=>x.MemberId);

        }
    }
}
