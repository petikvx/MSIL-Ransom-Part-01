using System;
using System.Xml;

namespace SmartAssembly.SmartExceptionsCore;

internal sealed class XmlElementSpanner1 : IDisposable
{
	private readonly XmlWriter m_XmlWriter;

	public XmlElementSpanner1(XmlWriter xmlWriter, string name)
	{
		try
		{
			m_XmlWriter = xmlWriter;
			m_XmlWriter.WriteStartElement(name);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, xmlWriter, name);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			m_XmlWriter.WriteEndElement();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}
}
