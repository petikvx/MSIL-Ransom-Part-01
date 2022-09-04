using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0;

internal sealed class Class8
{
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class Class9
	{
		internal IntPtr intptr_0;

		internal IntPtr intptr_1;

		internal IntPtr intptr_2;

		internal IntPtr intptr_3;

		internal IntPtr intptr_4;

		internal IntPtr intptr_5;
	}

	internal delegate int Delegate0(IntPtr ProcessHandle, int ProcessInformationClass, Class9 ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int Delegate1(IntPtr ProcessHandle, int ProcessInformationClass, out uint debugPort, uint ProcessInformationLength, out uint ReturnLength);

	internal delegate int Delegate2();

	internal delegate void Delegate3([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

	internal delegate int Delegate4(IntPtr hProcess, ref int pbDebuggerPresent);

	internal delegate int Delegate5(IntPtr wnd, IntPtr lParam);

	internal delegate int Delegate6(Delegate5 lpEnumFunc, IntPtr lParam);

	internal static uint uint_0;

	internal static uint uint_1;

	internal static int int_0;

	private static bool bool_0;

	[DllImport("kernel32.dll", ExactSpelling = true)]
	internal static extern void SetLastError(uint uint_2);

	[DllImport("kernel32.dll", ExactSpelling = true)]
	internal static extern int CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll", ExactSpelling = true)]
	internal static extern IntPtr OpenProcess(uint uint_2, int int_1, uint uint_3);

	[DllImport("kernel32.dll", ExactSpelling = true)]
	internal static extern uint GetCurrentProcessId();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true)]
	internal static extern Delegate0 GetProcAddress(IntPtr intptr_0, string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern Delegate1 GetProcAddress_1(IntPtr intptr_0, string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern Delegate4 GetProcAddress_2(IntPtr intptr_0, string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern Delegate2 GetProcAddress_3(IntPtr intptr_0, string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern Delegate3 GetProcAddress_4(IntPtr intptr_0, string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
	internal static extern Delegate6 GetProcAddress_5(IntPtr intptr_0, string string_0);

	private static int smethod_0(IntPtr intptr_0, IntPtr intptr_1)
	{
		string[] array = new string[1] { "OLLYDBG" };
		string string_ = smethod_1(intptr_0);
		string[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				string string_2 = array2[num];
				if (Delegate112.smethod_0(string_, string_2, bool_0: true) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return 1;
		}
		bool_0 = true;
		return 0;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_1);

	internal static string smethod_1(IntPtr intptr_0)
	{
		StringBuilder stringBuilder = Delegate353.smethod_0(260);
		GetClassName(intptr_0, stringBuilder, Delegate32.smethod_0(stringBuilder));
		return Delegate337.smethod_0(stringBuilder);
	}

	internal static void smethod_2()
	{
		if (smethod_3())
		{
			string object_ = "Debugger";
			throw Delegate58.smethod_0(Delegate62.smethod_0("{0} was found - this software cannot be executed under the {0}.", object_));
		}
	}

	internal static bool smethod_3()
	{
		try
		{
			if (Delegate84.smethod_0())
			{
				return true;
			}
			IntPtr intptr_ = LoadLibrary("kernel32.dll");
			Delegate2 procAddress_ = GetProcAddress_3(intptr_, "IsDebuggerPresent");
			if (procAddress_ != null && Delegate272.smethod_0(procAddress_) != 0)
			{
				return true;
			}
			uint currentProcessId = GetCurrentProcessId();
			IntPtr intptr_2 = OpenProcess(1024u, 0, currentProcessId);
			if (Delegate43.smethod_0(intptr_2, IntPtr.Zero))
			{
				try
				{
					Delegate4 procAddress_2 = GetProcAddress_2(intptr_, "CheckRemoteDebuggerPresent");
					if (procAddress_2 != null)
					{
						int num = 0;
						if (Delegate260.smethod_0(procAddress_2, intptr_2, ref num) != 0 && num != 0)
						{
							return true;
						}
					}
				}
				finally
				{
					CloseHandle(intptr_2);
				}
			}
			bool flag = false;
			try
			{
				CloseHandle(new IntPtr(305419896));
			}
			catch
			{
				flag = true;
			}
			if (flag)
			{
				return true;
			}
			try
			{
				IntPtr intptr_3 = LoadLibrary("user32.dll");
				Delegate6 procAddress_3 = GetProcAddress_5(intptr_3, "EnumWindows");
				if (procAddress_3 != null)
				{
					bool_0 = false;
					Delegate99.smethod_0(procAddress_3, smethod_0, IntPtr.Zero);
					if (bool_0)
					{
						return true;
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		return false;
	}
}
