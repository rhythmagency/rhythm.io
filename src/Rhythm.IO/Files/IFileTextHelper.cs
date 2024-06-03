namespace Rhythm.IO.Files;

/// <summary>
/// A contract for creating a helper that gets text from a file path.
/// </summary>
public interface IFileTextHelper
{
    /// <summary>
    /// Attempts to get a <see cref="string"/> from a path.
    /// </summary>
    /// <param name="path">The path to the resource.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A <see cref="string"/> if successful or <see langword="default"/> if not.</returns>
    Task<string?> GetTextAsync(string path, CancellationToken cancellationToken);
}
