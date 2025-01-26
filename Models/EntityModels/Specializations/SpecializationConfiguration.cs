using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Models.EntityModels.Specializations
{
    public class SpecializationConfiguration : IEntityTypeConfiguration<Specialization>
    {
        public void Configure(EntityTypeBuilder<Specialization> builder)
        {
            // Relationship with Doctor
            builder.HasMany(s => s.Doctors)
                .WithOne(d => d.Specialization)
                .HasForeignKey(d => d.SpecializationId);
        }
    }
}
