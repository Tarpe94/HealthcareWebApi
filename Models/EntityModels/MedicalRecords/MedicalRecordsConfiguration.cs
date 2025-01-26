using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Models.EntityModels.MedicalRecords
{
    public class MedicalRecordsConfiguration : IEntityTypeConfiguration<MedicalRecord>
    {
        public void Configure(EntityTypeBuilder<MedicalRecord> builder)
        {

            builder.HasOne(mr => mr.User)
                .WithMany()
                .HasForeignKey(mr => mr.UserId);

        }
    }
}
