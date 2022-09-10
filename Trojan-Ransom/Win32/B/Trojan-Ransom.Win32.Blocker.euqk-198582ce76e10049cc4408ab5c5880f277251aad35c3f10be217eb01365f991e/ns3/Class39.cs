using System;
using System.Xml;

namespace ns3;

internal class Class39 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class39(XmlWriter xmlWriter, string name)
	{
		xmlWriter_0 = xmlWriter;
		xmlWriter_0.WriteStartElement(name);
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
