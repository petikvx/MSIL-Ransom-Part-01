using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using RAccPass;

namespace ___codefort;

internal class Class1 : Class0
{
	public static int smethod_0(string string_0)
	{
		int result = 0;
		if (string_0.Contains(".exe+"))
		{
			int num = int.Parse(string_0.Substring(string_0.IndexOf(".exe+") + 5), NumberStyles.HexNumber);
			string processName = string_0.Replace(num.ToString("X"), null).Replace("+", null).Replace(".exe", null)
				.Trim();
			Process[] processesByName = Process.GetProcessesByName(processName);
			if (processesByName.Length == 0)
			{
				return 0;
			}
			result = processesByName[0].MainModule!.BaseAddress.ToInt32() + num;
		}
		else if (!int.TryParse(string_0, out result))
		{
			result = 0;
		}
		return result;
	}

	public static byte smethod_1(int int_0)
	{
		byte[] array = new byte[1];
		if (Class0.ReadProcessMemory(frmMain.Process_0[0].Handle, (IntPtr)int_0, array, (IntPtr)1, out var _))
		{
			return array[0];
		}
		return 0;
	}

	public static int smethod_2(int int_0)
	{
		byte[] array = new byte[4];
		if (Class0.ReadProcessMemory(frmMain.Process_0[0].Handle, (IntPtr)int_0, array, (IntPtr)4, out var _))
		{
			return BitConverter.ToInt32(array, 0);
		}
		return 0;
	}

	public static string smethod_3(int int_0, IntPtr intptr_0)
	{
		byte[] array = new byte[(int)intptr_0];
		if (Class0.ReadProcessMemory(frmMain.Process_0[0].Handle, (IntPtr)int_0, array, intptr_0, out var _))
		{
			return Encoding.ASCII.GetString(array);
		}
		return "null";
	}

	static Class1()
	{
		Class3.smethod_0();
	}
}
