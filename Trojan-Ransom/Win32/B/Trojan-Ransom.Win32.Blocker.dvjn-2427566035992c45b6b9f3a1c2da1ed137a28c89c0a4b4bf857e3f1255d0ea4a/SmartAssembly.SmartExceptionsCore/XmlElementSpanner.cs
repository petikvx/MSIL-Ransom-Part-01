using System;
using System.Xml;

namespace SmartAssembly.SmartExceptionsCore;

internal class XmlElementSpanner : IDisposable
{
	private readonly XmlWriter m_XmlWriter;

	public XmlElementSpanner(XmlWriter xmlWriter, string name)
	{
		Class2.l4t8M9wzGUypc();
		base._002Ector();
		m_XmlWriter = xmlWriter;
		m_XmlWriter.WriteStartElement(name);
	}

	public void Dispose()
	{
		m_XmlWriter.WriteEndElement();
	}
}
