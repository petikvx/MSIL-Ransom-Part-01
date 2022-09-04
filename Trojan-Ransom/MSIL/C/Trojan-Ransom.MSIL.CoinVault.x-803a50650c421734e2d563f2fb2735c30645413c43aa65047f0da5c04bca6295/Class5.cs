internal class Class5
{
	private string string_0;

	private string string_1;

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

	public string String_1
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public Class5(string key, string iv)
	{
		string_0 = key;
		string_1 = iv;
	}
}
