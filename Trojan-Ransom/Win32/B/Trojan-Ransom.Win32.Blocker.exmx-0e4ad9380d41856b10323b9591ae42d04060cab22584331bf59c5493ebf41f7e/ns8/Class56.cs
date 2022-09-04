using System;
using System.Xml;

namespace ns8;

internal class Class56 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class56(XmlWriter xmlWriter_1, string string_0)
	{
		xmlWriter_0 = xmlWriter_1;
		xmlWriter_0.WriteStartElement(string_0);
	}

	public void Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
