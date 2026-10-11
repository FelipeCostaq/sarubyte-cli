namespace Sarubyte.Core.Shared.Warnings;

public sealed class WarningCollector : IWarningSink
{
    private readonly List<SarubyteWarning> _warnings = [];

    public IReadOnlyList<SarubyteWarning> Warnings => _warnings;

    public void Report(SarubyteWarning warning) => _warnings.Add(warning);
}