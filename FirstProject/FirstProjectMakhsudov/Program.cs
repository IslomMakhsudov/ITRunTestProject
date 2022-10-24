using PetShop.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddMemoryCache();
builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(10); });
builder.Services.AddControllers();
builder.Services.AddSingleton<Database>();
builder.Services.AddTransient<DatabaseHandler>();
builder.Services.AddTransient<LoginService>();
builder.Services.AddTransient<RegistrationService>();

var app = builder.Build();

app.UseSession();
app.UseMiddleware<SessionGuidMiddleware>();
app.MapControllers();
app.Run();
