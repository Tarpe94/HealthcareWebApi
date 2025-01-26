using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EntityModels.Doctors;

namespace Models.EntityModels.DoctorsTimeOff
{
    public class DoctorsTimeOff
    {
        [Key]
        public long Id { get; set; }
        public long DoctorId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Status { get; set; }
        public Doctor Doctor { get; set; }

    }
}
