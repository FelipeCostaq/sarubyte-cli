using Sarubyte.Core.Shared.Warnings;
using Sarubyte.Core.Tools.Convert.Model;

namespace Sarubyte.Core.Tools.Convert.Formats;

public interface IFormatWriter
{
    DataFormat Format { get; }

    Task WriteAsync(Node node, Stream output, IWarningSink warnings, CancellationToken ct = default);
}