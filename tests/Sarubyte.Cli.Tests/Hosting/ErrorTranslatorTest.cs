using Sarubyte.Cli.Hosting;
using Sarubyte.Core.Shared.Errors;
using Xunit;

namespace Sarubyte.Cli.Tests.Hosting;

public class ErrorTranslatorTest
{
    [Fact]
    public void SarubyteExceptionKeepsItsMessageAndExitCode()
    {
        var info = ErrorTranslator.Translate(new DataFormatException("Invalid JSON."));

        Assert.Equal("Invalid JSON.", info.Message);
        Assert.Equal(ExitCodes.Data, info.ExitCode);
    }

    [Fact]
    public void IoExceptionMapsToIoExitCode()
    {
        var info = ErrorTranslator.Translate(new IOException("Disk Full."));
        
        Assert.Equal(ExitCodes.Io, info.ExitCode);
    }

    [Fact]
    public void UnknownExceptionMapsToInternalExitCode()
    {
        var info = ErrorTranslator.Translate(new InvalidOperationException("Invalid Operation."));
        
        Assert.Equal(ExitCodes.Internal, info.ExitCode);
    }
}