using System.Xml;

internal class Class37 : XmlNameTable
{
	private NameTable nameTable_0 = new NameTable();

	public override string Add(string array)
	{
		return nameTable_0.Add(array);
	}

	public override string Add(char[] array, int offset, int length)
	{
		return nameTable_0.Add(array, offset, length);
	}

	public override string Get(string array)
	{
		return nameTable_0.Get(array);
	}

	public override string Get(char[] array, int offset, int length)
	{
		return nameTable_0.Get(array, offset, length);
	}

	internal string method_0(string string_0)
	{
		string text = Get(string_0);
		if (text == null && 0 == 0)
		{
			return Add(string_0);
		}
		return text;
	}
}
