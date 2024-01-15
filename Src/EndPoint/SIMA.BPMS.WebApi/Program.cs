using SIMA.BPMS.Persistance.EF.ConfigurationExtentions;
using System.Globalization;
using SIMA.BPMS.Application.ConfigurationExtensions;
using SIMA.Framework.WebApi.ConfigurationExtention;

var builder = WebApplication.CreateBuilder(args);
const string AllowEveryThingPolicy = "AllowEveryThing";
// Add services to the container.

builder.Services.AddControllers();
builder.Services.RegisterWriteDbContext(builder.Configuration)
    .AddCommandHandlerServices()
    .RegisterCommandMappers()
    .AddSimaSwagger()
    ;

var app = builder.Build();
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;


// Configure the HTTP request pipeline.

app.UseAuthorization();
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors(AllowEveryThingPolicy);
app.MapControllers();

app.Run();
