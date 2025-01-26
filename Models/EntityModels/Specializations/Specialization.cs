using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EntityModels.Doctors;

namespace Models.EntityModels.Specializations
{
    public class Specialization
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }

        // Navigation property for related Doctors
        public ICollection<Doctor> Doctors { get; set; }
    }
}
