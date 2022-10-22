var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddMemoryCache();
builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(10); });
builder.Services.AddControllers();
builder.Services.AddSingleton<Database>();
builder.Services.AddSingleton<DatabaseHandler>();
var app = builder.Build();

app.UseSession();
app.MapControllers();
app.Run();
