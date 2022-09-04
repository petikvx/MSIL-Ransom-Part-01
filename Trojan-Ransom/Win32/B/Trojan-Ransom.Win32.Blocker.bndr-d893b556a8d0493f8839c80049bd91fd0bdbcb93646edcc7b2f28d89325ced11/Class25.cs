using System;
using System.Xml;

internal class Class25 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class25(XmlWriter xmlWriter_1, string string_0)
	{
		xmlWriter_0 = xmlWriter_1;
		xmlWriter_0.WriteStartElement(string_0);
	}

	public void Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
