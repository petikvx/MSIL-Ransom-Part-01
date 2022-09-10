using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ns1;

internal static class Class1
{
	public static string smethod_0(string string_0, string string_1)
	{
		byte[] array = smethod_1();
		byte[] array2 = smethod_1();
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_1, array, 1000);
		byte[] bytes2 = rfc2898DeriveBytes.GetBytes(32);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.BlockSize = 256;
		rijndaelManaged.Mode = CipherMode.CBC;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes2, array2);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		byte[] first = array;
		first = first.Concat(array2).ToArray();
		first = first.Concat(memoryStream.ToArray()).ToArray();
		memoryStream.Close();
		cryptoStream.Close();
		return Convert.ToBase64String(first);
	}

	private static byte[] smethod_1()
	{
		byte[] array = new byte[32];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}
}
