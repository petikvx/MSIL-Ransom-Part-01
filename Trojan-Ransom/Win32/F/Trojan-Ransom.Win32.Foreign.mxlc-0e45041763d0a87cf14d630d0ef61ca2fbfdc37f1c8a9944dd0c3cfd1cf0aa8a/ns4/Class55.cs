using System;
using System.Xml;

namespace ns4;

internal class Class55 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class55(XmlWriter xmlWriter_1, string string_0)
	{
		xmlWriter_0 = xmlWriter_1;
		xmlWriter_0.WriteStartElement(string_0);
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
