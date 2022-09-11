namespace TryPaper;

public class ReturnAddress
{
	public string Id { get; set; }

	public IAddress Address { get; set; }

	public ReturnAddress()
	{
		Address = new Address();
	}
}
