using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0;

internal sealed class Class4
{
	internal sealed class Class5
	{
		internal static byte[] smethod_0(byte[] byte_0, RijndaelManaged rijndaelManaged_0, byte[] byte_1)
		{
			using ICryptoTransform transform = rijndaelManaged_0.CreateDecryptor(byte_1, rijndaelManaged_0.IV);
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
	}

	internal static Assembly smethod_0(AppDomain appDomain_0)
	{
		return appDomain_0.Load(Class0.smethod_0(new byte[35]
		{
			57, 49, 9, 59, 188, 159, 53, 107, 24, 145,
			109, 152, 58, 119, 56, 71, 65, 67, 106, 129,
			19, 26, 69, 199, 76, 28, 207, 32, 114, 1,
			30, 90, 135, 36, 136
		}));
	}
}
