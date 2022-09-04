using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyComputer : Computer
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2108)]
	private struct Struct0
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyComputer()
	{
		try
		{
			try
			{
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

	static MyComputer()
	{
		int num = default(int);
		char[] array = default(char[]);
		try
		{
			num = 0;
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			char_1 = new char[1054];
			array = new char[8];
			num = 5;
			array[0] = 'ሀ';
			array[5] = 'ԣ';
			array[6] = '\u0654';
			num = 3;
			array[3] = '㍘';
			array[1] = '㳂';
			array[7] = 'ᓘ';
			num = 2;
			array[2] = 'ዯ';
			array[4] = 'ም';
			string_0 = new string[42];
			num = 1;
			char_0 = array;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, array, num);
			throw;
		}
	}

	internal static string smethod_0(ref DateTime dateTime_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 33:
					return dateTime_0.ToString(string_1);
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, dateTime_0, string_1, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(FileDialog fileDialog_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 25:
					fileDialog_0.set_Title(string_1);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, fileDialog_0, string_1, int_0, int_1);
			throw;
		}
	}
}
