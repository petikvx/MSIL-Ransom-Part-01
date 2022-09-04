using System;
using System.Xml;

internal class Class33 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class33(XmlWriter xmlWriter_1, string string_0)
	{
		Class52.KPUgGmhz2nAeI();
		base._002Ector();
		xmlWriter_0 = xmlWriter_1;
		xmlWriter_0.WriteStartElement(string_0);
	}

	public void Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}
}
