using MyProductsWebApp.Services;

var builder = WebApplication.CreateBuilder(args);

//var connectionString = "Endpoint=https://demoappconfigs071.azconfig.io;Id=fD19;Secret=Gm7Oek1DDlNlcL864ph4xT/9saTq4lwDBlAVfasoGE4=";

//builder.Host.ConfigureAppConfiguration(builder =>
//{
//    //Connect to your App Config Store using the connection string
//    builder.AddAzureAppConfiguration(connectionString);
//});

//DI Implimentation
builder.Services.AddTransient<IProductService, ProductService>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
