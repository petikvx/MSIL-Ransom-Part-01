using System;
using System.Xml;

namespace ns7;

internal sealed class Class33 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class33(XmlWriter xmlWriter_1, string string_0)
	{
		xmlWriter_0 = xmlWriter_1;
		xmlWriter_0.WriteStartElement(string_0);
	}

	public void Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
