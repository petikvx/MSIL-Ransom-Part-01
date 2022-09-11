using System;
using System.Xml;

namespace ns9;

internal class Class52 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class52(XmlWriter xmlWriter_1, string string_0)
	{
		xmlWriter_0 = xmlWriter_1;
		xmlWriter_0.WriteStartElement(string_0);
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}

	internal static bool t9W7RXGyw1P9n89kf9I()
	{
		return true;
	}

	internal static bool egOPvDGKhwI38ldLhRa()
	{
		return false;
	}
}
