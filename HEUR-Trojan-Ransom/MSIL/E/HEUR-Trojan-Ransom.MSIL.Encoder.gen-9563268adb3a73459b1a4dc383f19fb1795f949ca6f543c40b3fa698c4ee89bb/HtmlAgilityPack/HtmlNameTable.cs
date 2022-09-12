using System.Xml;

namespace HtmlAgilityPack;

internal class HtmlNameTable : XmlNameTable
{
	private NameTable _nametable = new NameTable();

	public override string Add(string array)
	{
		return _nametable.Add(array);
	}

	public override string Add(char[] array, int offset, int length)
	{
		return _nametable.Add(array, offset, length);
	}

	public override string Get(string array)
	{
		return _nametable.Get(array);
	}

	public override string Get(char[] array, int offset, int length)
	{
		return _nametable.Get(array, offset, length);
	}

	internal string GetOrAdd(string array)
	{
		string text = Get(array);
		if (text == null)
		{
			return Add(array);
		}
		return text;
	}
}
