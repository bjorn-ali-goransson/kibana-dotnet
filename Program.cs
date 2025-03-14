using Elastic.Apm.NetCoreAll;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddControllers();

var app = builder.Build();

// Configure APM
app.UseAllElasticApm(builder.Configuration);

// Configure the HTTP request pipeline
app.UseRouting();

app.MapGet("/", () => "Hello from .NET API!");

app.Run(); 