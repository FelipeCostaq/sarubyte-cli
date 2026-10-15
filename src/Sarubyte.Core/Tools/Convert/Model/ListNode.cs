namespace Sarubyte.Core.Tools.Convert.Model;

public sealed record ListNode(IReadOnlyList<Node> Items) : Node;