namespace BlazorWasm.HospitalManagementSystem.Services;

public static class PageSettingService
{
    public static string Get<T>(this IEnumerable<T> lst, T detail)
    {
        return (lst.ToList().IndexOf(detail) + 1).ToString();
    }
}