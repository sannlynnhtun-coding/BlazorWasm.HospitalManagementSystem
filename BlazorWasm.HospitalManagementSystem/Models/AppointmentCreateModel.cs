namespace BlazorWasm.HospitalManagementSystem.Models
{
    public class AppointmentCreateModel
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public int RoomId { get; set; }
        public string Status { get; set; }
        public bool IsCancel { get; set; }
    }

}
