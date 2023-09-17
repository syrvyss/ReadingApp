using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ReadingApp;
using Supabase;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services
  .AddBlazorise(options => { options.Immediate = true; })
  .AddBootstrap5Providers()
  .AddFontAwesomeIcons();

/*
builder.Services.AddScoped<Supabase.Client>(_ =>
    new Supabase.Client(
        builder.Configuration["SupabaseUrl"],
        builder.Configuration["SupabaseKey"],
        new SupabaseOptions
        {
            AutoRefreshToken = true,
            AutoConnectRealtime = true
        }));
        */

var supabaseOptions = new SupabaseOptions
{
  ApiKey = "YOUR_SUPABASE_API_KEY",
  ApiUrl = "https://your-project-id.supabase.co" // Replace with your project URL
};

var supabase = new SupabaseClient(supabaseOptions);

builder.Services.AddSingleton(supabase);

// _______


builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();