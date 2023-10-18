using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SectionManagement.Application.Interfaces;
using SectionManagement.Application.Interfaces.Authentication;
using SectionManagement.Application.Interfaces.Common;
using SectionManagement.Core.Models;
using SectionManagement.Infrastructure.Authentication;
using SectionManagement.Infrastructure.Data;
using SectionManagement.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace SectionManagement.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfeastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        
        services.AddAuth(configuration);

        services.AddDbContext<AppDbContext>();
        services.AddScoped<IPortRepository, PortRepository>();
        services.AddScoped<ISectionRepository, SectionRepository>();
        services.AddScoped<ISectionSingleRepository, SectionSingleRepository>();
        services.AddScoped<IDeviceRepository, DeviceRepository>();

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDataTimeProvider, DataTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>();



        return services;
    }

    public static IServiceCollection AddAuth(this IServiceCollection services, ConfigurationManager configuration)
    {
        var jwtSettings = new JwtSettings();
        configuration.Bind(JwtSettings.SectionName, jwtSettings);
        services.AddSingleton(Options.Create(jwtSettings));
        // services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

        services.AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtSettings.Issuer,
                ValidAudience = jwtSettings.Audience,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(jwtSettings.Secret)
                )
            });
        return services;
    }
}
