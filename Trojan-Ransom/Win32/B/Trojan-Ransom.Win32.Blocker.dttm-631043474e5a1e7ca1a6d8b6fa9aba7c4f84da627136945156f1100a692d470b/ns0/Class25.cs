using System;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class25 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class25(XmlWriter xmlWriter_1, string string_0)
	{
		try
		{
			xmlWriter_0 = xmlWriter_1;
			xmlWriter_0.WriteStartElement(string_0);
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException3(exception_, this, xmlWriter_1, string_0);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			xmlWriter_0.WriteEndElement();
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException1(exception_, this);
			throw;
		}
	}
}
