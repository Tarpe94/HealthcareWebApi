using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Models.EntityModels.DoctorsTimeOff
{
    public class DoctorTimeOffConfiguration : IEntityTypeConfiguration<DoctorsTimeOff>
    {
        public void Configure(EntityTypeBuilder<DoctorsTimeOff> builder)
        {

            builder.HasOne(d => d.Doctor)
                .WithMany()
                .HasForeignKey(a => a.DoctorId);

        }
    }
}
