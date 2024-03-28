namespace BlazorWasm.HospitalManagementSystem.Models;

public class DoctorCreateModel
{
    public int Id { get; set; }
    public int SpecialistId { get; set; }
    public string DoctorName { get; set; }
    public string Email { get; set; }
    public string MobileNumber { get; set; }
    public string StartDuty { get; set; }
    public string EndDuty { get; set; }
}
