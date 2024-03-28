namespace BlazorWasm.HospitalManagementSystem.Services;

public static class ApiUrl
{
    public static string Diseases { get; } = "Diseases";
    public static string Rooms { get; } = "Rooms";
    public static string DoctorSpecialistRole { get; } = "doctor-specialist";
    public static string DoctorSpecialistRoleCreate { get; } = "doctor-specialist/create";
    public static string DoctorSpecialistRoleEdit { get; } = "doctor-specialist/edit";
    public static string DoctorSpecialistRoleDelete { get; } = "doctor-specialist/delete";
    public static string Patient { get; } = "patients";
    public static string Doctor { get; } = "doctors";
    public static string DoctorSpecialists { get; } = "doctor-specialists";
}
