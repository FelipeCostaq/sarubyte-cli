using Sarubyte.Core.Shared.Warnings;
using Sarubyte.Core.Tools.Convert.Model;

namespace Sarubyte.Core.Tools.Convert.Formats;

public interface IFormatReader
{
    DataFormat Format { get; }

    Task<Node> ReadAsync(Stream input, IWarningSink warnings, CancellationToken ct = default);
}