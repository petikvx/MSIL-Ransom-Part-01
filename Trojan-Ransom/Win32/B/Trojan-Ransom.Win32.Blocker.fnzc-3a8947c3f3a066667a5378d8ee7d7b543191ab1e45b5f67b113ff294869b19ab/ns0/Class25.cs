using System;
using System.Security;
using System.Xml;

namespace ns0;

internal sealed class Class25 : IDisposable
{
	internal XmlWriter xmlWriter_0;

	public Class25(XmlWriter xmlWriter_1, string string_0)
	{
		XmlWriter xmlWriter = (xmlWriter_0 = xmlWriter_1);
		Class32.smethod_0(xmlWriter_0, string_0, 890, 833);
	}

	public void Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}

	[SecuritySafeCritical]
	static Class25()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static Type smethod_0(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 36:
				return exception_0.GetType();
			}
		}
	}
}
