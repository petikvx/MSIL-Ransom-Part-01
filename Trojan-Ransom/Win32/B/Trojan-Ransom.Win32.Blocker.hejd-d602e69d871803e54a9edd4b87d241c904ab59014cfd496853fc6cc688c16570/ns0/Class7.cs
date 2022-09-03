using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0;

internal class Class7
{
	internal static byte[] smethod_0(Stream stream_0)
	{
		byte b = (byte)stream_0.ReadByte();
		byte[] array = new byte[stream_0.Length - 1L];
		stream_0.Read(array, 0, array.Length);
		if (((uint)b & (true ? 1u : 0u)) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] array2 = new byte[8];
			Buffer.BlockCopy(array, 0, array2, 0, 8);
			dESCryptoServiceProvider.IV = array2;
			byte[] array3 = new byte[8];
			Buffer.BlockCopy(array, 8, array3, 0, 8);
			bool flag = true;
			byte[] array4 = array3;
			for (int i = 0; i < array4.Length; i++)
			{
				if (array4[i] != 0)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				array3 = Assembly.GetExecutingAssembly().GetName().GetPublicKeyToken();
			}
			dESCryptoServiceProvider.Key = array3;
			array = dESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, 16, array.Length - 16);
		}
		if ((b & 2u) != 0)
		{
			try
			{
				MemoryStream memoryStream = new MemoryStream(array);
				DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress);
				MemoryStream memoryStream2 = new MemoryStream((int)memoryStream.Length * 2);
				int num = 1000;
				byte[] buffer = new byte[1000];
				int num2;
				do
				{
					num2 = deflateStream.Read(buffer, 0, num);
					if (num2 > 0)
					{
						memoryStream2.Write(buffer, 0, num2);
					}
				}
				while (num2 >= num);
				array = memoryStream2.ToArray();
				return array;
			}
			catch (Exception)
			{
				return array;
			}
		}
		return array;
	}
}
