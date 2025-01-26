using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Models.EntityModels.Doctors;
using Models.EntityModels.Ordinations;
using Models.EntityModels.Users;

namespace Models.EntityModels.Appointments
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public long UserId { get; set; }
        public long DoctorId { get; set; }
        public long OrdinationId { get; set; }
        public DateTime ScheduledStart {  get; set; }
        public DateTime ScheduledEnd {  get; set; }
        public int Status {  get; set; }
        public string ReasonForVisit { get; set; }  
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User User { get; set; }
        public Doctor Doctor { get; set; }
        public Ordination Ordination { get; set; }

    }
}
