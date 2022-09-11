using System;
using System.Xml;

namespace ns8;

internal sealed class Class50 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class50(XmlWriter xmlWriter, string name)
	{
		xmlWriter_0 = xmlWriter;
		xmlWriter_0.WriteStartElement(name);
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
