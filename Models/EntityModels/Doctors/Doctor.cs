using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Models.EntityModels.Specializations;
using Models.EntityModels.Users;

namespace Models.EntityModels.Doctors
{
    public class Doctor
    {
        [Key]
        public long Id { get; set; }
        public string LicenceNumber { get; set; }
        public long SpecializationId { get; set; }
        public long UserId {  get; set; }
        public int YearsOfExpirience {  get; set; }
        public User User { get; set; }
        public Specialization Specialization { get; set; }

    }
}
