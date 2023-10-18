
using SectionManagement.Api.Extensions;
using SectionManagement.Infrastructure.Data;
using SectionManagement.Application.Services.PortService.Queries;
using Microsoft.EntityFrameworkCore;
using SectionManagement.Application;
using SectionManagement.Infrastructure;
using SectionManagement.Api.Groups;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using SectionManagement.Application.Services.DeviceService.Query;
using SectionManagement.Application.Services.DeviceService.Common;

var builder = WebApplication.CreateBuilder(args);


builder.Services
    .AddApplication()
    .AddInfeastructure(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("NormalUser", policy => policy.RequireRole("NormalUser"));
});

var app = builder.Build();



app.MapGet("/aaa", () => Results.Ok(new Message() { Text = "Hello World!" }))
    .Produces<Message>();

app.MapGet("/aaa2", () => TypedResults.Ok(new Message() { Text = "Hello World!" }));

app.MapGet("/aaa3", async (IDeviceQueryService _deviceQueryService) =>
{
    var result = await _deviceQueryService.GetAllDevicesQuerryAsyncService();
    return Results.Ok(result);
}).Produces<DeviceRequest>();

app.UseExceptionHandler("/error");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();





app.MapPortApi();
app.MapErrorApi();
app.MapAddDataApi();
app.MapSectionApi();
app.MapSectionSingleApi();
app.MapAuthenticationApi();

app.MapGroup("").GroupDeviceApi().WithTags("Device");
app.MapGroup("").GroupPortApi().WithTags("Port");

app.Run();

// public partial class Program { }
