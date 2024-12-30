using Microsoft.EntityFrameworkCore;
using RIRA.Core.IoC;
using RIRA.Core.Mapper;
using RIRA.Core.Services;
using RIRA.Data.DatabseContext;
using RIRA.GRPC.GRPCServices;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


//builder.Services.AddEndpointsApiExplorer();
//var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
//var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);


//builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MyMapper));
//builder.Configuration.AddEnvironmentVariables();
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("RIRAConnectionString"));
});

builder.Services.Injector();
// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();
var app = builder.Build();
app.MapGrpcService<UserGRPCService>();
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//}
// Configure the HTTP request pipeline.
app.MapGrpcService<UserService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
