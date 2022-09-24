internal sealed class Class17
{
	private string string_0;

	private string string_1;

	private string string_2;

	public Class17(string string_3 = null, string string_4 = null)
	{
		method_1(string_3);
		method_3(string_4);
	}

	public string method_0()
	{
		return string_0;
	}

	public void method_1(string string_3)
	{
		string_0 = string_3;
	}

	public string method_2()
	{
		return string_1;
	}

	public void method_3(string string_3)
	{
		string_1 = string_3;
	}

	public string method_4()
	{
		return string_2;
	}

	public void method_5(string string_3)
	{
		string_2 = string_3;
	}

	public override string ToString()
	{
		return string_1;
	}
}
