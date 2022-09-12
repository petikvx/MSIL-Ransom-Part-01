using System;
using System.Xml;

namespace ns0;

internal sealed class Class38 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class38(XmlWriter xmlWriter_1, string string_0)
	{
		xmlWriter_0 = xmlWriter_1;
		xmlWriter_0.WriteStartElement(string_0);
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
