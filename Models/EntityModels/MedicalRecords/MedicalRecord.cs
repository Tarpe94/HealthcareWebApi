using System;
using System.ComponentModel.DataAnnotations;
using Models.EntityModels.Users;

namespace Models.EntityModels.MedicalRecords
{
    public class MedicalRecord
    {
            [Key]
            public long Id { get; set; }
            public long UserId { get; set; }
            public long DoctorId { get; set; }
            public string Diagnosis { get; set; }
            public string Perscription { get; set; }
            public string Notes { get; set; }
            public DateTime CreatedAt { get; set; }
            public User User { get; set; }

    }
}
