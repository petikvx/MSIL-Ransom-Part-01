using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;

namespace VjMQkoKRLykc;

public class GClass2
{
	private bool bool_0;

	private Stream stream_0;

	private const string K1MyI2uETaAiCRZ4dTSb2ilgF9YlFV4vHnEeDvy1hw74 = "";

	private const string string_0 = "";

	private const string string_1 = "";

	private const int int_0 = -2147286960;

	private const FileMode fileMode_0 = FileMode.Create;

	private const FileAccess fileAccess_0 = FileAccess.ReadWrite;

	private const FileShare fileShare_0 = FileShare.None;

	private const FileMode fileMode_1 = FileMode.Open;

	internal bool bool_1;

	internal bool bool_2;

	internal string string_2;

	internal static string String_0 => "";

	internal static string String_1 => "";

	private static void smethod_0(GEnum0 genum0_0)
	{
		if (genum0_0 != 0 && genum0_0 != GEnum0.const_1 && genum0_0 != GEnum0.const_2)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "", new object[1] { (int)genum0_0 }));
		}
	}

	internal GClass2(string string_3, Class6 class6_0)
	{
		if (string_3 == null)
		{
			throw new ArgumentNullException("");
		}
	}

	internal GClass2(Stream stream_1, Class6 class6_0)
	{
	}

	internal GClass2(string string_3, Stream stream_1, Class6 class6_0)
	{
		if (string_3 == null)
		{
			throw new ArgumentNullException("");
		}
		if (stream_1 == null)
		{
			throw new ArgumentNullException("");
		}
	}

	public static void smethod_1(byte[] byte_0, GEnum0 genum0_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("");
		}
		if (Environment.OSVersion.Platform == PlatformID.Win32Windows)
		{
			throw new NotSupportedException("");
		}
		if (byte_0.Length != 0 && byte_0.Length % 16L == 0L)
		{
			try
			{
				return;
			}
			catch (EntryPointNotFoundException)
			{
				throw new NotSupportedException("");
			}
		}
		throw new CryptographicException("");
	}

	internal GClass2(Stream stream_1, Stream stream_2, Class6 class6_0)
	{
	}

	internal GClass2(string string_3, FileAccess fileAccess_1, FileShare fileShare_1)
	{
	}

	internal GClass2(Stream stream_1)
	{
		if (stream_1 == null)
		{
			throw new ArgumentNullException("");
		}
	}

	public static GClass2 smethod_2(string string_3)
	{
		return smethod_4(string_3, FileAccess.ReadWrite, FileShare.None);
	}

	public static GClass2 smethod_3(string string_3, FileAccess fileAccess_1)
	{
		return smethod_4(string_3, fileAccess_1, FileShare.None);
	}

	public static GClass2 smethod_4(string string_3, FileAccess fileAccess_1, FileShare fileShare_1)
	{
		return new GClass2(string_3, fileAccess_1, fileShare_1);
	}

	public static GClass2 smethod_5(Stream stream_1)
	{
		return new GClass2(stream_1);
	}

	public static bool smethod_6(string string_3)
	{
		return false;
	}

	public static bool smethod_7(Stream stream_1)
	{
		return false;
	}

	public void method_0()
	{
		if (stream_0 != null)
		{
			stream_0.Flush();
		}
	}

	public void method_1()
	{
		method_2();
	}

	public void method_2()
	{
		GC.SuppressFinalize(this);
	}

	internal Stream method_3()
	{
		return stream_0;
	}
}
