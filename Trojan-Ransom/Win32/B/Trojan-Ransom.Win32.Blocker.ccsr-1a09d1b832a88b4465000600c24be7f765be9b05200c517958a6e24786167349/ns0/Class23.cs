using System;
using System.Windows.Forms;
using System.Xml;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class23 : IDisposable
{
	internal XmlWriter xmlWriter_0;

	public Class23(XmlWriter xmlWriter_1, string string_0)
	{
		XmlWriter xmlWriter = (xmlWriter_0 = xmlWriter_1);
		ReportUsageAttribute.smethod_1(xmlWriter_0, string_0, 777, 869);
	}

	public void Dispose()
	{
		xmlWriter_0.WriteEndElement();
	}

	static Class23()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static void smethod_0(Control control_0, EventHandler eventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 32:
				control_0.add_Click(eventHandler_0);
				return;
			}
		}
	}
}
