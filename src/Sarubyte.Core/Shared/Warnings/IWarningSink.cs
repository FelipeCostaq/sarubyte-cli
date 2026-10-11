namespace Sarubyte.Core.Shared.Warnings;

public interface IWarningSink
{
    void Report(SarubyteWarning warning);
}