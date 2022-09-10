using System;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class32 : IDisposable
{
	internal XmlWriter xmlWriter_0;

	public Class32(XmlWriter xmlWriter_1, string string_0)
	{
		try
		{
			XmlWriter xmlWriter = (xmlWriter_0 = xmlWriter_1);
			xmlWriter_0.WriteStartElement(string_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, xmlWriter_1, string_0);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			xmlWriter_0.WriteEndElement();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}
}
