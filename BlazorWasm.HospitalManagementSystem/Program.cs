var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddFluentUIComponents();

string backendUrl = "https://hospital-management-system-backend-7fee.vercel.app/api/v1/";
//string backendUrl = "https://hospital-management-system-backend.vercel.app/api/v1/";

builder.Services.AddSingleton<Loading>();
builder.Services.AddSingleton<DialogService>();
builder.Services.AddSingleton<InjectService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(backendUrl) });
builder.Services.AddScoped<IApiService, HttpClientService>();

await builder.Build().RunAsync();
