using System;
using System.Xml;

namespace ns0;

internal sealed class Class35 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class35(XmlWriter CO_, string CO_)
	{
		xmlWriter_0 = CO_;
		xmlWriter_0.WriteStartElement(CO_);
	}

	public void Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
