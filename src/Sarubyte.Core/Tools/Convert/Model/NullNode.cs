namespace Sarubyte.Core.Tools.Convert.Model;

public sealed record NullNode : Node
{
    public static NullNode Instance { get; } = new();
}