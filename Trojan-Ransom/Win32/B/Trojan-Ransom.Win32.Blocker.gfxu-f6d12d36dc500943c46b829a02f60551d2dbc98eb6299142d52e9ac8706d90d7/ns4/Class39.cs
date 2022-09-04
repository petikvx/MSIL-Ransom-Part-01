using System;
using System.Xml;

namespace ns4;

internal class Class39 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class39(XmlWriter xmlWriter_1, string string_0)
	{
		Class42.hMqjKD0znI7T7();
		base._002Ector();
		xmlWriter_0 = xmlWriter_1;
		xmlWriter_0.WriteStartElement(string_0);
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
