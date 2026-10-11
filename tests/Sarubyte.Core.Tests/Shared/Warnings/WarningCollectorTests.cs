using Sarubyte.Core.Shared.Warnings;

namespace Sarubyte.Core.Tests.Shared.Warnings;

public class WarningCollectorTests
{
    [Fact]
    public void StartsEmpty()
    {
        var collector = new WarningCollector();
        
        Assert.Empty(collector.Warnings);
    }

    [Fact]
    public void ReportKeepsWarningsInOrder()
    {
        var collector = new WarningCollector();
        
        collector.Report(new SarubyteWarning("a", "first"));
        collector.Report(new SarubyteWarning("b", "second"));
        
        Assert.Equal(new [] { "a", "b" }, collector.Warnings.Select(w => w.Code));
    }
}