using System;
using System.Xml;

namespace ns11;

internal class Class59 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class59(XmlWriter xmlWriter, string name)
	{
		xmlWriter_0 = xmlWriter;
		xmlWriter_0.WriteStartElement(name);
	}

	void IDisposable.Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}

	internal static bool A3d3QdX2r3p2qs5xGHJ()
	{
		return true;
	}

	internal static bool JB6QaSXJURyiFqZXPhL()
	{
		return false;
	}
}
