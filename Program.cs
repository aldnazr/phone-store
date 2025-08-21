using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PhoneStore;
using Blazored.LocalStorage;
using PhoneStore.Data.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://backendtokohp.me/api/")
});

builder.Services.AddScoped(typeof(ICrudService<>), typeof(CrudService<>));

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


// Tambahkan LocalStorage service
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<CartService>(); // Service keranjang
await builder.Build().RunAsync();
