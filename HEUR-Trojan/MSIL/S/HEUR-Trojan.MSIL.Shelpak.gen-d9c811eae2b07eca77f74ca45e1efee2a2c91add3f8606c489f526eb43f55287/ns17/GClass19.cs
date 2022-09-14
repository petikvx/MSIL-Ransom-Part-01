using System;
using System.IO;
using System.IO.Compression;

namespace ns17;

public static class GClass19
{
	public static byte[] smethod_0(byte[] byte_0)
	{
		using MemoryStream memoryStream = new MemoryStream(byte_0);
		byte[] array = new byte[4];
		memoryStream.Read(array, 0, 4);
		int num = BitConverter.ToInt32(array, 0);
		using GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array2 = new byte[num];
		gZipStream.Read(array2, 0, num);
		return array2;
	}

	public static byte[] smethod_1(byte[] byte_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		byte[] bytes = BitConverter.GetBytes(byte_0.Length);
		memoryStream.Write(bytes, 0, 4);
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			gZipStream.Write(byte_0, 0, byte_0.Length);
			gZipStream.Flush();
		}
		return memoryStream.ToArray();
	}
}
