namespace Rhythm.IO;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Rhythm.IO.Files;

/// <summary>
/// Extension methods for registering dependencies.
/// </summary>
public static class DependencyInjectionExtensions
{
    /// <summary>
    /// Adds dependencies for Rhythm IO to the current <see cref="WebApplicationBuilder"/>.
    /// </summary>
    /// <param name="builder">The builder.</param>
    /// <returns>The current <see cref="WebApplicationBuilder"/>.</returns>
    public static WebApplicationBuilder AddRhythmIO(this WebApplicationBuilder builder)
    {
        builder.Services.AddRhythmIO();

        return builder;
    }

    /// <summary>
    /// Adds dependencies for Rhythm IO to the current <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The services.</param>
    /// <returns>The current <see cref="IServiceCollection"/>.</returns>
    public static IServiceCollection AddRhythmIO(this IServiceCollection services)
    {
        return services.AddFilesDependencies();
    }
}
