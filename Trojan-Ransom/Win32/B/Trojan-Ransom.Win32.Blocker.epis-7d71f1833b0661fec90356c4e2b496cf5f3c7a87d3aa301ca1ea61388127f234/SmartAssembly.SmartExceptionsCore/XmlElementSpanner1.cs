using System;
using System.Xml;

namespace SmartAssembly.SmartExceptionsCore;

internal class XmlElementSpanner1 : IDisposable
{
	private readonly XmlWriter m_XmlWriter;

	public XmlElementSpanner1(XmlWriter xmlWriter, string name)
	{
		m_XmlWriter = xmlWriter;
		m_XmlWriter.WriteStartElement(name);
	}

	public void Dispose()
	{
		m_XmlWriter.WriteEndElement();
	}
}
