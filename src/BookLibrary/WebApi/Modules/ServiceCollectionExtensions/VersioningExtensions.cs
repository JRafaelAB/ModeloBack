﻿using Microsoft.AspNetCore.Mvc;

namespace WebApi.Modules.ServiceCollectionExtensions;

internal static class VersioningExtensions
{
    public static IServiceCollection AddVersioning(this IServiceCollection services)
    {
        services
            .AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
            });

        services
            .AddVersionedApiExplorer(p =>
            {
                p.GroupNameFormat = "'v'VVV";
                p.SubstituteApiVersionInUrl = true;
            });

        return services;
    }
        
}
