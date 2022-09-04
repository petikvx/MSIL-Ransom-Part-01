using System;
using System.Xml;

namespace ns4;

internal class Class16 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class16(XmlWriter xmlWriter_1, string string_0)
	{
		xmlWriter_0 = xmlWriter_1;
		xmlWriter_0.WriteStartElement(string_0);
	}

	public void Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
