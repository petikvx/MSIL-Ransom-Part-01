using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using eZGOhwHsUbVjUNjdZQ;

internal class Class2
{
	internal class Attribute0 : Attribute
	{
		internal class Class3<T>
		{
			public Class3()
			{
				Class5.SUi8phazhjLmk();
				base._002Ector();
			}
		}

		[Attribute0(typeof(ebjl5iduDGjiB8jAyt_002FebNkJCKLpIQ7WNEyry_002FeqCFI34cEJo0UnCQSg<object>[]))]
		public Attribute0(object object_0)
		{
			Class5.SUi8phazhjLmk();
			base._002Ector();
		}
	}

	internal class Class4
	{
		[Attribute0(typeof(ebjl5iduDGjiB8jAyt_002FebNkJCKLpIQ7WNEyry_002FeqCFI34cEJo0UnCQSg<object>[]))]
		internal static void ce4DmfsmSrOT856tDgfrkMb()
		{
			if (smethod_0(Convert.ToBase64String(typeof(Class2).Assembly.GetName().GetPublicKeyToken()), " ") != "  ")
			{
				while (true)
				{
					ce4DmfsmSrOT856tDgfrkMb();
				}
			}
		}

		[Attribute0(typeof(ebjl5iduDGjiB8jAyt_002FebNkJCKLpIQ7WNEyry_002FeqCFI34cEJo0UnCQSg<object>[]))]
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			MD5 mD = new MD5CryptoServiceProvider();
			byte[] iV = mD.ComputeHash(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			Rijndael rijndael = Rijndael.Create();
			rijndael.Key = key;
			rijndael.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		public Class4()
		{
			Class5.SUi8phazhjLmk();
			base._002Ector();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate1([MarshalAs(UnmanagedType.U8)] ref ulong classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, ref IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate2();

	internal struct Struct0
	{
		internal bool bool_0;

		internal byte[] byte_0;
	}

	[Flags]
	private enum Enum0
	{

	}

	private static byte[] byte_0;

	private static byte[] byte_1;

	private static byte[] byte_2;

	private static byte[] byte_3;

	private static IntPtr intptr_0;

	private static IntPtr intptr_1;

	private static string[] string_0;

	private static int[] ejUxboxZt;

	private static int int_0;

	private static bool bool_0;

	private static SortedList sortedList_0;

	private static int int_1;

	private static long long_0;

	internal static Delegate1 delegate1_0;

	internal static Delegate1 delegate1_1;

	private static long long_1;

	private static int int_2;

	private static bool bool_1;

	private static bool bool_2;

	private static int int_3;

	private static IntPtr intptr_2;

	internal static Hashtable hashtable_0;

	static Class2()
	{
		byte_0 = new byte[0];
		byte_1 = new byte[0];
		byte_2 = new byte[0];
		byte_3 = new byte[0];
		intptr_0 = IntPtr.Zero;
		intptr_1 = IntPtr.Zero;
		string_0 = new string[0];
		ejUxboxZt = new int[0];
		int_0 = 1;
		bool_0 = false;
		sortedList_0 = new SortedList();
		int_1 = 0;
		long_0 = 0L;
		delegate1_0 = null;
		delegate1_1 = null;
		long_1 = 0L;
		int_2 = 0;
		bool_1 = false;
		bool_2 = false;
		int_3 = 0;
		intptr_2 = IntPtr.Zero;
		hashtable_0 = new Hashtable();
	}

	private void iHM8phagT5tph()
	{
	}

	[Attribute0(typeof(ebjl5iduDGjiB8jAyt_002FebNkJCKLpIQ7WNEyry_002FeqCFI34cEJo0UnCQSg<object>[]))]
	internal static string smethod_0(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[DllImport("kernel32.dll")]
	private static extern void RtlZeroMemory(IntPtr intptr_3, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int VirtualProtect(ref IntPtr intptr_3, int int_4, int int_5, ref int int_6);

	[DllImport("kernel32.dll")]
	public static extern IntPtr FindResource(IntPtr intptr_3, string string_1, uint uint_0);

	private static IntPtr smethod_1(IntPtr intptr_3, int int_4)
	{
		if (IntPtr.Size == 4)
		{
			return (IntPtr)smethod_2(intptr_3, int_4);
		}
		return (IntPtr)smethod_3(intptr_3, int_4);
	}

	private unsafe static int smethod_2(IntPtr intptr_3, int int_4)
	{
		try
		{
			byte* ptr = (byte*)intptr_3.ToPointer() + int_4;
			if (((int)ptr & 3) == 0)
			{
				return *(int*)ptr;
			}
			int result = default(int);
			byte* ptr2 = (byte*)(&result);
			*ptr2 = *ptr;
			ptr2[1] = ptr[1];
			ptr2[2] = ptr[2];
			ptr2[3] = ptr[3];
			return result;
		}
		catch (NullReferenceException)
		{
			throw new AccessViolationException();
		}
	}

	private unsafe static long smethod_3(IntPtr intptr_3, int int_4)
	{
		try
		{
			byte* ptr = (byte*)intptr_3.ToPointer() + int_4;
			if (((int)ptr & 7) == 0)
			{
				return *(long*)ptr;
			}
			long result = default(long);
			byte* ptr2 = (byte*)(&result);
			*ptr2 = *ptr;
			ptr2[1] = ptr[1];
			ptr2[2] = ptr[2];
			ptr2[3] = ptr[3];
			ptr2[4] = ptr[4];
			ptr2[5] = ptr[5];
			ptr2[6] = ptr[6];
			ptr2[7] = ptr[7];
			return result;
		}
		catch (NullReferenceException)
		{
			throw new AccessViolationException();
		}
	}

	private static void smethod_4(IntPtr intptr_3, int int_4, IntPtr intptr_4)
	{
		if (IntPtr.Size == 4)
		{
			smethod_5(intptr_3, int_4, (int)intptr_4);
		}
		else
		{
			smethod_6(intptr_3, int_4, (long)intptr_4);
		}
	}

	private unsafe static void smethod_5(IntPtr intptr_3, int int_4, int int_5)
	{
		try
		{
			byte* ptr = (byte*)intptr_3.ToPointer() + int_4;
			if (((int)ptr & 3) == 0)
			{
				*(int*)ptr = int_5;
				return;
			}
			byte* ptr2 = (byte*)(&int_5);
			*ptr = *ptr2;
			ptr[1] = ptr2[1];
			ptr[2] = ptr2[2];
			ptr[3] = ptr2[3];
		}
		catch (NullReferenceException)
		{
			throw new AccessViolationException();
		}
	}

	private unsafe static void smethod_6(IntPtr intptr_3, int int_4, long long_2)
	{
		try
		{
			byte* ptr = (byte*)intptr_3.ToPointer() + int_4;
			if (((int)ptr & 7) == 0)
			{
				*(long*)ptr = long_2;
				return;
			}
			byte* ptr2 = (byte*)(&long_2);
			*ptr = *ptr2;
			ptr[1] = ptr2[1];
			ptr[2] = ptr2[2];
			ptr[3] = ptr2[3];
			ptr[4] = ptr2[4];
			ptr[5] = ptr2[5];
			ptr[6] = ptr2[6];
			ptr[7] = ptr2[7];
		}
		catch (NullReferenceException)
		{
			throw new AccessViolationException();
		}
	}

	private static void smethod_7()
	{
	}

	private static void smethod_8()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	internal static object smethod_9(Assembly assembly_0)
	{
		try
		{
			if (File.Exists(assembly_0.Location))
			{
				return assembly_0.Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_0.GetName().CodeBase!.ToString().Replace("file:///", "")))
			{
				return assembly_0.GetName().CodeBase!.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_0.GetType().GetProperty("Location")!.GetValue(assembly_0, new object[0])!.ToString()))
			{
				return assembly_0.GetType().GetProperty("Location")!.GetValue(assembly_0, new object[0])!.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_3, string string_1);

	[DllImport("kernel32.dll")]
	private static extern int WriteProcessMemory(IntPtr intptr_3, IntPtr intptr_4, [In][Out] byte[] byte_4, uint uint_0, out IntPtr intptr_5);

	[DllImport("kernel32.dll")]
	private static extern int ReadProcessMemory(IntPtr intptr_3, IntPtr intptr_4, [In][Out] byte[] byte_4, uint uint_0, out IntPtr intptr_5);

	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	private static extern int VirtualProtect_1(IntPtr intptr_3, int int_4, int int_5, ref int int_6);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint uint_0, int int_4, uint uint_1);

	[DllImport("kernel32.dll")]
	private static extern int CloseHandle(IntPtr intptr_3);

	[Attribute0(typeof(ebjl5iduDGjiB8jAyt_002FebNkJCKLpIQ7WNEyry_002FeqCFI34cEJo0UnCQSg<object>[]))]
	private static byte[] smethod_10(string string_1)
	{
		using FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		long length = fileStream.Length;
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	[Attribute0(typeof(ebjl5iduDGjiB8jAyt_002FebNkJCKLpIQ7WNEyry_002FeqCFI34cEJo0UnCQSg<object>[]))]
	private static byte[] smethod_11(byte[] byte_4)
	{
		MemoryStream memoryStream = new MemoryStream();
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = new byte[32]
		{
			123, 5, 74, 12, 244, 156, 221, 154, 121, 221,
			183, 41, 121, 65, 9, 43, 67, 81, 23, 43,
			74, 63, 64, 23, 95, 185, 226, 244, 45, 194,
			211, 43
		};
		rijndael.IV = new byte[16]
		{
			117, 254, 41, 121, 65, 52, 9, 43, 221, 154,
			12, 54, 68, 241, 68, 66
		};
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_4, 0, byte_4.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	private byte[] method_0()
	{
		string text = "{11111-22222-10001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] method_1()
	{
		string text = "{11111-22222-10001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] method_2()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] method_3()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] method_4()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] method_5()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_6()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_7()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_8()
	{
		return null;
	}

	internal byte[] method_9()
	{
		return null;
	}
}
