namespace TryPaper;

public class Mailing
{
	public BatchReference Batch { get; set; }

	public string ReturnAddressId { get; set; }

	public string Id { get; set; }

	public IAddress Recipient { get; set; }

	public IContent Content { get; set; }
}
