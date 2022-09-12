namespace Examine;

public class IndexedNode
{
	public int NodeId { get; set; }

	public string Type { get; set; }

	public override bool Equals(object obj)
	{
		return ((IndexedNode)obj).NodeId == NodeId;
	}

	public override int GetHashCode()
	{
		return NodeId.GetHashCode();
	}
}
