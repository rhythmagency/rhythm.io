namespace Rhythm.IO.Files.Implementations;

using Microsoft.AspNetCore.Hosting;
using Rhythm.IO.Files;
using System.IO;
using System.Threading.Tasks;

/// <summary>
/// The default implementation of <see cref="IFileTextHelper"/> using <see cref="IWebHostEnvironment"/>.
/// </summary>
/// <remarks>This implementation only supports files on the file system and within the Web Root of the current application.</remarks>
internal sealed class WebHostEnvironmentFileTextHelper : IFileTextHelper
{
    private readonly IWebHostEnvironment _environment;

    /// <summary>
    /// Constructs a new <see cref="WebHostEnvironmentFileTextHelper"/> instance.
    /// </summary>
    /// <param name="webHostEnvironment">The web host environment.</param>
    public WebHostEnvironmentFileTextHelper(IWebHostEnvironment webHostEnvironment)
    {
        _environment = webHostEnvironment;
    }

    /// <inheritdoc/>
    public async Task<string?> GetTextAsync(string path, CancellationToken cancellationToken)
    {
        var fullPath = GetFullPath(path);

        if (File.Exists(fullPath) is false)
        {
            throw new FileAccessException(fullPath, "File path does not exist");
        }

        return await File.ReadAllTextAsync(fullPath, cancellationToken);
    }

    private string GetFullPath(string path)
    {
        if (Path.IsPathFullyQualified(path))
        {
            throw new FileAccessException(path, "Path is already fully qualified. Path must be relative to the environment web root.");
        }

        var newPath = path.Replace('/', Path.DirectorySeparatorChar).Replace('\\', Path.DirectorySeparatorChar);

        return Path.Combine(_environment.WebRootPath, newPath.TrimStart('\\'));
    }
}
