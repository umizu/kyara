using Asp.Versioning;
using Kyara.Api.Data;
using Kyara.Api.Endpoints;
using Kyara.Api.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

builder.Host.UseSerilog((ctx, config) =>
    config.ReadFrom.Configuration(ctx.Configuration));
services.AddApiVersioning(opts =>
{
    opts.DefaultApiVersion = new ApiVersion(1);
    opts.AssumeDefaultVersionWhenUnspecified = true;
    opts.ApiVersionReader = new UrlSegmentApiVersionReader();
    opts.ReportApiVersions = true;
});
services.AddDbContext<AppDbContext>(opts =>
    opts.UseNpgsql(builder.Configuration["Database:ConnectionString"]));
services.AddHealthChecks();
services.AddScoped<CharacterService>();

var app = builder.Build();
app.UseHealthChecks("/_health");
app.UseCharacterEndpoints();
app.Run();
