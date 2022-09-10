using System;
using System.Xml;

namespace ns6;

internal sealed class Class36 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class36(XmlWriter xmlWriter, string name)
	{
		xmlWriter_0 = xmlWriter;
		xmlWriter_0.WriteStartElement(name);
	}

	public void Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
