namespace Sarubyte.Core.Shared.Errors;

public class SarubyteException(string message, int exitCode, Exception? inner = null) : Exception(message, inner)
{
    public int ExitCode { get; } = exitCode;
}