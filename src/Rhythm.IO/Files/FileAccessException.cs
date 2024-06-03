namespace Rhythm.IO.Files;

using System;

/// <summary>
/// An exception which represents there being an issue when accessing a file.
/// </summary>
[Serializable]
public sealed class FileAccessException : Exception
{
    /// <summary>
    /// Constructs a new instance of <see cref="FileAccessException"/>.
    /// </summary>
    /// <param name="filePath">The file path being accessed.</param>
    /// <param name="reason">The reason access was unsuccessful.</param>
    public FileAccessException(string filePath, string reason) : base(reason)
    {
        FilePath = filePath;
        Reason = reason;
    }

    /// <summary>
    /// Gets the file path of the file being accessed.
    /// </summary>
    public string FilePath { get; }

    /// <summary>
    /// Gets the reason access was unsuccessful.
    /// </summary>
    public string Reason { get; }
}
