using System;

namespace TryPaper;

public class BatchReference
{
	public string Id { get; set; }

	public DateTime CreateDateUtc { get; set; }

	public string Status { get; set; }

	public BatchReference()
	{
	}

	public BatchReference(string id)
	{
		Id = id;
	}
}
