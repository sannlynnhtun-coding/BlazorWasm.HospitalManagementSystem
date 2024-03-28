namespace BlazorWasm.HospitalManagementSystem.Models;

public class DoctorModel
{
    public int Id { get; set; }
    public string DoctorName { get; set; }
    public string Email { get; set; }
    public string MobileNumber { get; set; }
    public string StartDuty { get; set; }
    public string EndDuty { get; set; }
    public Specialist Specialist { get; set; }
}
public class Specialist
{
    public int Id { get; set; }
    public string Name { get; set; }
}