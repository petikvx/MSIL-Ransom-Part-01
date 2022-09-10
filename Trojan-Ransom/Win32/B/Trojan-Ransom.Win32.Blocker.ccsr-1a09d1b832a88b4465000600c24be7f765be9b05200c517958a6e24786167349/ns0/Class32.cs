using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class32 : IDisposable
{
	internal XmlWriter xmlWriter_0;

	public Class32(XmlWriter xmlWriter_1, string string_0)
	{
		try
		{
			XmlWriter xmlWriter = (xmlWriter_0 = xmlWriter_1);
			SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_1(xmlWriter_0, string_0, 147, 255);
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

	static Class32()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static Graphics smethod_0(Control control_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 32:
				return control_0.CreateGraphics();
			}
		}
	}

	internal static int smethod_1(ref Rectangle rectangle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 60:
				return rectangle_0.Top;
			}
		}
	}

	internal static void smethod_2(Control control_0, Cursor cursor_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 74:
				control_0.set_Cursor(cursor_0);
				return;
			}
		}
	}

	internal static string smethod_3(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 99:
				return string_0.ToLower();
			}
		}
	}

	internal static object smethod_4(Array array_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 1:
				return array_0.GetValue(int_0);
			}
		}
	}
}
