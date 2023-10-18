using Microsoft.Extensions.DependencyInjection;
using SectionManagement.Application.Services.AuthenticationService.Command;
using SectionManagement.Application.Services.AuthenticationService.Query;
using SectionManagement.Application.Services.DeviceService.Query;
using SectionManagement.Application.Services.PortService.Command;
using SectionManagement.Application.Services.PortService.Queries;
using SectionManagement.Application.Services.SectionService.Queries;
using SectionManagement.Application.Services.SectionSingleService.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IPortQueryService, PortQueryService>();
        services.AddScoped<IPortCommandService, PortCommandService>();

        services.AddScoped<ISectionQueryService, SectionQueryService>();

        services.AddScoped<ISectionSingleQueryService, SectionSingleQueryService>();

        services.AddScoped<IDeviceQueryService, DeviceQueryService>();

        services.AddScoped<IAuthenticationQueryService, AuthenticationQueryService>();
        services.AddScoped<IAuthenticationCommandService, AuthenticationCommandService>();

        return services;
    }
}
