namespace BlazorWasm.HospitalManagementSystem.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }
        public bool IsCancel { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Room Room { get; set; }
    }

    public class Doctor
    {
        public int Id { get; set; }
        public string DoctorName { get; set; }
        public Specialist Specialist { get; set; }
    }

    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
