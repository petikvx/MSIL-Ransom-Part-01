internal class Class13
{
	private string string_0;

	public string String_0
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

	public Class13(string string_1)
	{
		string_0 = string_1;
	}

	internal static int smethod_0(int int_0)
	{
		return int_0 switch
		{
			87 => 8, 
			83 => 7, 
			80 => 14, 
			_ => -1, 
		};
	}
}
