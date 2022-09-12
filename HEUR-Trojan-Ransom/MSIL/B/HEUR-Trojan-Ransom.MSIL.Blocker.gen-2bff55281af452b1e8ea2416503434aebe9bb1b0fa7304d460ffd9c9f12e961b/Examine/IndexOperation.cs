namespace Examine;

public class IndexOperation
{
	public IndexItem Item { get; set; }

	public IndexOperationType Operation { get; set; }

	public IndexOperation()
	{
	}

	public IndexOperation(IndexItem item, IndexOperationType operation)
	{
		Item = item;
		Operation = operation;
	}
}
