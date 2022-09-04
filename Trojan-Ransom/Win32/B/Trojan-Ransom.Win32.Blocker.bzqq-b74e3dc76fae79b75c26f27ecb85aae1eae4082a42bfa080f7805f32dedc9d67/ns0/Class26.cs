using System;
using System.Diagnostics;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class26 : IDisposable
{
	internal XmlWriter xmlWriter_0;

	public Class26(XmlWriter xmlWriter_1, string string_0)
	{
		XmlWriter o = default(XmlWriter);
		try
		{
			o = (xmlWriter_0 = xmlWriter_1);
			Class28.smethod_4(xmlWriter_0, string_0, 889, 880);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, o, this, xmlWriter_1, string_0);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			StackFrameHelper.smethod_2(xmlWriter_0, 118, 52);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static Class26()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static int smethod_0(ref IntPtr intptr_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 9:
					return intptr_0.ToInt32();
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, intptr_0, int_0, int_1);
			throw;
		}
	}

	internal static Process smethod_1(string string_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 36:
					return Process.Start(string_0, string_1);
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, string_0, string_1, int_0, int_1);
			throw;
		}
	}
}
