using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class35 : IDisposable
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1676)]
	private struct Struct28
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal XmlWriter xmlWriter_0;

	public Class35(XmlWriter xmlWriter_1, string string_1)
	{
		XmlWriter o = default(XmlWriter);
		try
		{
			try
			{
				o = (xmlWriter_0 = xmlWriter_1);
				Class28.smethod_4(xmlWriter_0, string_1, 290, 299);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, this, xmlWriter_1, string_1);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException4(exception2, o, this, xmlWriter_1, string_1);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			try
			{
				StackFrameHelper.smethod_2(xmlWriter_0, 316, 382);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException1(exception2, this);
			throw;
		}
	}

	static Class35()
	{
		int num = default(int);
		char[] array = default(char[]);
		try
		{
			num = 2;
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			char_1 = new char[838];
			array = new char[8];
			num = 3;
			array[6] = '\u0654';
			array[3] = '㍘';
			array[4] = 'ም';
			num = 1;
			array[2] = 'ዯ';
			array[1] = '㳂';
			array[5] = 'ԣ';
			num = 7;
			array[7] = 'ᓘ';
			array[0] = 'ሀ';
			string_0 = new string[53];
			num = 0;
			char_0 = array;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, array, num);
			throw;
		}
	}

	internal static void smethod_0(Control control_0, Size size_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 79:
					control_0.set_MaximumSize(size_0);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, size_0, int_0, int_1);
			throw;
		}
	}

	internal static char smethod_1(string string_1, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 105:
					return string_1[int_0];
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, string_1, int_0, int_1, int_2);
			throw;
		}
	}

	internal static string smethod_2(Control control_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 31:
					return control_0.get_Text();
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, control_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_3(ref ulong ulong_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 83:
					return ulong_0.ToString(string_1);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, ulong_0, string_1, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_4(CheckBox checkBox_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 64:
					return checkBox_0.get_Checked();
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, checkBox_0, int_0, int_1);
			throw;
		}
	}
}
