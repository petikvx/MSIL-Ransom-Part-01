using System;
using System.Xml;

namespace ns7;

internal sealed class Class48 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class48(XmlWriter xmlWriter, string name)
	{
		xmlWriter_0 = xmlWriter;
		xmlWriter_0.WriteStartElement(name);
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
