using System;
using System.Xml;

namespace ns10;

internal sealed class Class44 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class44(XmlWriter xmlWriter_1, string string_0)
	{
		xmlWriter_0 = xmlWriter_1;
		xmlWriter_0.WriteStartElement(string_0);
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
