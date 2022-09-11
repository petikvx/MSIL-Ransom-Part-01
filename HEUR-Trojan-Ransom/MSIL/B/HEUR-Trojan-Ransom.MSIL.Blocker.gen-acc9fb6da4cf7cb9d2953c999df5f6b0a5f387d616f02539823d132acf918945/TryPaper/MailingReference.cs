using System;

namespace TryPaper;

public class MailingReference
{
	public string Id { get; set; }

	public BatchReference Batch { get; set; }

	public DateTime CreateDateUtc { get; set; }

	public MailingReference()
	{
		Batch = new BatchReference();
	}
}
