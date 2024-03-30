namespace BlazorWasm.HospitalManagementSystem.Models;

public class MedicalRecordModel
{
    public int Id { get; set; }
    public int PatientID { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Diagnosis { get; set; }
    public string Note { get; set; }
    public string Treatment { get; set; }
}

public class MedicalRecordViewModel
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public string PatientName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Diagnosis { get; set; }
    public string Note { get; set; }
    public string Treatment { get; set; }
    public List<DiseaseModel> Diseases { get; set; }
}