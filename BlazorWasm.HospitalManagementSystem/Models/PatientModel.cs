namespace BlazorWasm.HospitalManagementSystem.Models;

public class PatientModel
{
    public int id { get; set; }
    public string name { get; set; }
    public string gender { get; set; }
    public string phoneNumber { get; set; }
    public string email { get; set; }
    public string bloodType { get; set; }
    public DateTime birthDate { get; set; }
    public string address { get; set; }
}
