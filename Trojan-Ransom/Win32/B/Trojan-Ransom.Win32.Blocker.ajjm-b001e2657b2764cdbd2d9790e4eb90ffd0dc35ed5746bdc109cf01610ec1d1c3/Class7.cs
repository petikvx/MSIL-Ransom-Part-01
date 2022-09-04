using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using wRwWgOOmBcPMiIlyaF;

internal class Class7
{
	internal class Attribute0 : Attribute
	{
		internal class Class8<T>
		{
		}

		[Attribute0(typeof(I9BCjQixwBWVctLvJ1_002FMTX5qtLGPtCegwBdGf_002FwfHfuIQ1qGRFSXYhhn<object>[]))]
		public Attribute0(object object_0)
		{
		}
	}

	internal class Class9
	{
		[Attribute0(typeof(I9BCjQixwBWVctLvJ1_002FMTX5qtLGPtCegwBdGf_002FwfHfuIQ1qGRFSXYhhn<object>[]))]
		internal static void ce4DmfsmSrOT856tDgfrkMb()
		{
			if (smethod_0(Convert.ToBase64String(typeof(Class7).Assembly.GetName().GetPublicKeyToken()), " ") != "  ")
			{
				while (true)
				{
					ce4DmfsmSrOT856tDgfrkMb();
				}
			}
		}

		[Attribute0(typeof(I9BCjQixwBWVctLvJ1_002FMTX5qtLGPtCegwBdGf_002FwfHfuIQ1qGRFSXYhhn<object>[]))]
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

	private static int[] int_0;

	private static int int_1;

	private static bool bool_0;

	private static SortedList sortedList_0;

	private static int int_2;

	private static long long_0;

	internal static Delegate1 delegate1_0;

	internal static Delegate1 delegate1_1;

	private static long long_1;

	private static int int_3;

	private static bool bool_1;

	private static int int_4;

	private static IntPtr intptr_2;

	internal static Hashtable hashtable_0;

	static Class7()
	{
		byte_0 = new byte[0];
		byte_1 = new byte[0];
		byte_2 = new byte[0];
		byte_3 = new byte[0];
		intptr_0 = IntPtr.Zero;
		intptr_1 = IntPtr.Zero;
		string_0 = new string[0];
		int_0 = new int[0];
		int_1 = 1;
		bool_0 = false;
		sortedList_0 = new SortedList();
		int_2 = 0;
		long_0 = 0L;
		delegate1_0 = null;
		delegate1_1 = null;
		long_1 = 0L;
		int_3 = 0;
		bool_1 = false;
		int_4 = 0;
		intptr_2 = IntPtr.Zero;
		hashtable_0 = new Hashtable();
	}

	private void TYTXOJ9iv06nZ()
	{
	}

	[Attribute0(typeof(I9BCjQixwBWVctLvJ1_002FMTX5qtLGPtCegwBdGf_002FwfHfuIQ1qGRFSXYhhn<object>[]))]
	internal static string smethod_0(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[DllImport("kernel32.dll")]
	private static extern void RtlZeroMemory(IntPtr intptr_3, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int VirtualProtect(ref IntPtr intptr_3, int int_5, int int_6, ref int int_7);

	[DllImport("kernel32.dll")]
	public static extern IntPtr FindResource(IntPtr intptr_3, string string_1, uint uint_0);

	private static void smethod_1()
	{
	}

	private static void smethod_2()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	internal static object smethod_3(Assembly assembly_0)
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
	private static extern int VirtualProtect_1(IntPtr intptr_3, int int_5, int int_6, ref int int_7);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint uint_0, int int_5, uint uint_1);

	[DllImport("kernel32.dll")]
	private static extern int CloseHandle(IntPtr intptr_3);

	[Attribute0(typeof(I9BCjQixwBWVctLvJ1_002FMTX5qtLGPtCegwBdGf_002FwfHfuIQ1qGRFSXYhhn<object>[]))]
	private static byte[] smethod_4(string string_1)
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

	[Attribute0(typeof(I9BCjQixwBWVctLvJ1_002FMTX5qtLGPtCegwBdGf_002FwfHfuIQ1qGRFSXYhhn<object>[]))]
	private static byte[] smethod_5(byte[] byte_4)
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
