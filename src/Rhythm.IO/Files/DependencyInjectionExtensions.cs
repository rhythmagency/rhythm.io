namespace Rhythm.IO.Files;

using Microsoft.Extensions.DependencyInjection;
using Rhythm.IO.Files.Implementations;

/// <summary>
/// Extension methods for <see cref="IServiceCollection"/>.
/// </summary>
public static class DependencyInjectionExtensions
{
    /// <summary>
    /// Adds dependencies for the <see cref="Files"/> namespace to the current <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The services.</param>
    /// <returns>The current <see cref="IServiceCollection"/>.</returns>
    public static IServiceCollection AddFilesDependencies(this IServiceCollection services)
    {
        return services
            .AddSingleton<IFileTextHelper, WebHostEnvironmentFileTextHelper>();
    }
}
