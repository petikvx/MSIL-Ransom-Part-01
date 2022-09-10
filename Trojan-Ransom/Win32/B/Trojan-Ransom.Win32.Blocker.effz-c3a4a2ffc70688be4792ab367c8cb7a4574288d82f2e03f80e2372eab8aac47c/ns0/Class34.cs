using System;
using System.Xml;

namespace ns0;

internal sealed class Class34 : IDisposable
{
	internal XmlWriter xmlWriter_0;

	public Class34(XmlWriter xmlWriter_1, string string_0)
	{
		XmlWriter xmlWriter = (xmlWriter_0 = xmlWriter_1);
		xmlWriter_0.WriteStartElement(string_0);
	}

	public void Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
