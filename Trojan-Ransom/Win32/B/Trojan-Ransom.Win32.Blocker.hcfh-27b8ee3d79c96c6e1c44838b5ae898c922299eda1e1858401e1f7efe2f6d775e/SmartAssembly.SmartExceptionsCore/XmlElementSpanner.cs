using System;
using System.Xml;

namespace SmartAssembly.SmartExceptionsCore;

internal sealed class XmlElementSpanner : IDisposable
{
	private readonly XmlWriter m_XmlWriter;

	public XmlElementSpanner(XmlWriter xmlWriter, string name)
	{
		m_XmlWriter = xmlWriter;
		m_XmlWriter.WriteStartElement(name);
	}

	public void Dispose()
	{
		m_XmlWriter.WriteEndElement();
	}
}
