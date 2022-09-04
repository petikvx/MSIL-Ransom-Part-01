using System;
using System.Xml;

namespace SmartAssembly.SmartExceptionsCore;

internal class XmlElementSpanner : IDisposable
{
	private readonly XmlWriter m_XmlWriter;

	public XmlElementSpanner(XmlWriter xmlWriter_0, string string_0)
	{
		m_XmlWriter = xmlWriter_0;
		m_XmlWriter.WriteStartElement(string_0);
	}

	public void Dispose()
	{
		m_XmlWriter.WriteEndElement();
	}
}
