namespace Sarubyte.Core.Tools.Convert.Model;

public sealed record ObjectNode(IReadOnlyList<Property> Properties) : Node;
