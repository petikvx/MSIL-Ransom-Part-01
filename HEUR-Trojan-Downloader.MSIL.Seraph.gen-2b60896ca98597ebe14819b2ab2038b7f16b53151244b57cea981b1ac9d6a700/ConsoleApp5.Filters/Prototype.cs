namespace ConsoleApp5.Filters;

internal sealed class Prototype
{
	private bool record;

	internal bool WriteInitializer()
	{
		return record;
	}

	internal void CompareInitializer(bool isinfo)
	{
		record = isinfo;
	}
}
