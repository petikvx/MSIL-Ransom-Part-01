namespace ns0;

internal class Class0 : Interface0
{
	public static int int_0;

	private string string_0;

	private int int_1;

	public string Name
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public int Counter => int_1;

	public Class0()
	{
		int_1 = ++int_0;
	}
}
