namespace TreehouseDefense;

internal class OutOfBoundsException : TreehouseDefenseException
{
	public OutOfBoundsException()
	{
	}

	public OutOfBoundsException(string message)
		: base(message)
	{
	}
}
