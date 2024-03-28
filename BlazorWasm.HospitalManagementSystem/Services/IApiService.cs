namespace BlazorWasm.HospitalManagementSystem.Services
{
    public interface IApiService
    {
        Task Execute(string apiUrl, Method method, object? req = null);
        Task<T> Execute<T>(string apiUrl, Method method, object? req = null);
    }
}