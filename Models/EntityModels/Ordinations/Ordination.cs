using System.ComponentModel.DataAnnotations;
using Models.EntityModels.Appointments;

namespace Models.EntityModels.Ordinations
{
    public class Ordination
    {
        [Key]

        public long Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public string RoomNumber { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
