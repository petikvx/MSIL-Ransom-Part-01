using System;
using System.Xml;
using ns3;

namespace ns9;

internal sealed class Class53 : IDisposable
{
	private readonly XmlWriter xmlWriter_0;

	public Class53(XmlWriter xmlWriter_1, string string_0)
	{
		try
		{
			xmlWriter_0 = xmlWriter_1;
			xmlWriter_0.WriteStartElement(string_0);
		}
		catch (Exception exception_)
		{
			Class38.smethod_3(exception_, this, xmlWriter_1, string_0);
			throw;
		}
	}

	void IDisposable.Dispose()
	{
		try
		{
			xmlWriter_0.WriteEndElement();
		}
		catch (Exception exception_)
		{
			Class38.smethod_1(exception_, this);
			throw;
		}
	}
}
