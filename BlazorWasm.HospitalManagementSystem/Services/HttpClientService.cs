using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace BlazorWasm.HospitalManagementSystem.Services
{
    public class HttpClientService
    {
        private readonly HttpClient _httpClient;

        public HttpClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> Execute<T>(string apiUrl, 
            object? req = null,
            Method method = Method.Get)
        {
            T? model = default;
            HttpResponseMessage? response = null;
            try
            {
                HttpContent? content = null;                                
                if(req is not null)
                {
                    content = new StringContent(JsonConvert.SerializeObject(req), Encoding.UTF8, Application.Json);
                }
                switch (method)
                {
                    case Method.Get:
                        response = await _httpClient.GetAsync(apiUrl);
                        break;
                    case Method.Post:
                        response = await _httpClient.PostAsync(apiUrl, content);
                        break;
                    case Method.Put:
                        response = await _httpClient.PostAsync(apiUrl, content);
                        break;
                    case Method.Delete:
                        response = await _httpClient.DeleteAsync(apiUrl);
                        break;
                    case Method.None:
                    default:
                        throw new ArgumentOutOfRangeException(nameof(method), method, null);
                }

                var jsonStr = await response.Content.ReadAsStringAsync();
                model = JsonConvert.DeserializeObject<T>(jsonStr) ??
                        throw new Exception("Eba2c2pHttpClientService GetAsync json string is null.");
            }
            catch
            {
                throw;
            }

            return model!;
        }
    }

    public enum Method
    {
        None,
        Get,
        Post,
        Put,
        Delete,
    }
}
