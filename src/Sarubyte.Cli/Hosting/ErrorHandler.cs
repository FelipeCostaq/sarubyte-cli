namespace Sarubyte.Cli.Hosting;

internal sealed class ErrorHandler(TextWriter error)
{
    public int Handle(Exception exception, bool verbose)
    {
        var info = ErrorTranslator.Translate(exception);
        
        error.WriteLine($"error: {info.Message}");

        if (verbose)
        {
            error.WriteLine(exception);
        }

        return info.ExitCode;
    }
}