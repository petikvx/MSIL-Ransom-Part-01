using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class34 : IDisposable
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2046)]
	private struct Struct18
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal XmlWriter xmlWriter_0;

	public Class34(XmlWriter xmlWriter_1, string string_1)
	{
		try
		{
			XmlWriter xmlWriter = (xmlWriter_0 = xmlWriter_1);
			Class32.smethod_0(xmlWriter_0, string_1, 544, 539);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, xmlWriter_1, string_1);
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

	[SecuritySafeCritical]
	static Class34()
	{
		Class32.smethod_1();
		char_1 = new char[1023];
		char[] array = new char[8];
		array[3] = 'ܣ';
		array[5] = 'ᕾ';
		array[0] = '⦅';
		array[6] = 'ጧ';
		array[7] = 'ȡ';
		array[1] = '\u12c7';
		array[4] = '⌙';
		array[2] = '㯌';
		string_0 = new string[51];
		char_0 = array;
	}

	[SecuritySafeCritical]
	internal static Delegate smethod_0(Delegate delegate_0, Delegate delegate_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 79:
				return Delegate.Combine(delegate_0, delegate_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static AppDomain smethod_1(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 107:
				return AppDomain.CurrentDomain;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Graphics smethod_2(PaintEventArgs paintEventArgs_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 48:
				return paintEventArgs_0.get_Graphics();
			}
		}
	}
}
