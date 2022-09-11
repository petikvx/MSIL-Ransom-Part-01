using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using C3554254475;

namespace C3904355907;

public sealed class C878818188
{
	public static readonly Random C3554254475 = new Random();

	private C878818188()
	{
	}

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	public static void C3554254475(ref byte[] byte_0)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] = (byte)C878818188.C3554254475.Next(0, 255);
		}
	}

	public unsafe static void C3554254475(ref string string_0)
	{
		if (string_0 == null)
		{
			return;
		}
		int length = string_0.Length;
		fixed (char* ptr = string_0)
		{
			for (int i = 0; i < length; i++)
			{
				ptr[i] = (char)C878818188.C3554254475.Next(0, 255);
			}
		}
	}

	public static void C3554254475(ref string string_0, ref global::C3554254475.C2181537457 c2181537457_0)
	{
		string_0 = c2181537457_0.C112844655();
	}

	public static bool C3554254475(FileInfo fileInfo_0)
	{
		bool result = true;
		using FileStream fileStream = File.OpenRead(fileInfo_0.FullName);
		byte[] array = new byte[C3110715001.C3904355907];
		fileStream.Read(array, 0, array.Length);
		for (int i = 0; i < C3110715001.C3904355907; i++)
		{
			if (array[i] != C3110715001.C3554254475[i])
			{
				return false;
			}
		}
		return result;
	}

	public static bool C3554254475(string string_0)
	{
		if (C3110715001.C3554254475 == null)
		{
			return true;
		}
		string text = string_0.ToUpper(CultureInfo.CurrentCulture);
		string[] c3554254475 = C3110715001.C3554254475;
		int num = 0;
		while (true)
		{
			if (num < c3554254475.Length)
			{
				string value = c3554254475[num];
				if (text.Contains(value))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool C3904355907(string string_0)
	{
		string text = string_0.ToUpper(CultureInfo.CurrentCulture);
		string[] c3904355907 = C3110715001.C3904355907;
		int num = 0;
		while (true)
		{
			if (num < c3904355907.Length)
			{
				string text2 = c3904355907[num];
				if (text == text2)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static void C3554254475(string string_0, ref global::C3554254475.C2181537457 c2181537457_0)
	{
		using FileStream fileStream = File.OpenRead(string_0);
		byte[] byte_ = new byte[fileStream.Length];
		fileStream.Read(byte_, 0, byte_.Length);
		string string_ = Encoding.ASCII.GetString(byte_);
		C3554254475(ref byte_);
		byte[] byte_2 = global::C3554254475.C1130791706.C1255198513().GetBytes(string_);
		C3554254475(ref string_);
		c2181537457_0 = new global::C3554254475.C2181537457(bool_0: true, byte_2);
		C3554254475(ref byte_2);
	}

	public static void C3904355907(string string_0, ref global::C3554254475.C2181537457 c2181537457_0)
	{
		using FileStream fileStream = new FileStream(string_0, FileMode.Create);
		byte[] byte_ = Encoding.ASCII.GetBytes(c2181537457_0.C112844655());
		fileStream.Write(byte_, 0, byte_.Length);
		C3554254475(ref byte_);
		fileStream.Flush();
	}
}
