using Sarubyte.Core.Shared.Errors;

namespace Sarubyte.Cli.Hosting;

internal static class ErrorTranslator
{
    public static ErrorInfo Translate(Exception exception) => exception switch
    {
        SarubyteException e => new (e.Message, e.ExitCode),
        
        // IoError
        IOException e => new ErrorInfo(e.Message, ExitCodes.Io),
        UnauthorizedAccessException => new ("Permission denied. Check the file permissions.", ExitCodes.Io),
        
        // Geral 
        _ => new("Something unexpected went wrong. Run again with --verbose for details.", ExitCodes.Internal)
    };
}