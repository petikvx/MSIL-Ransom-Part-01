using System;
using System.IO;
using System.IO.Compression;

namespace MlfWmjHrDtM;

public static class JHJqnZOmgeGMD
{
	public static byte[] porHVDREaXWlJc(byte[] tCLbwgCwCwxQo)
	{
		using MemoryStream memoryStream = new MemoryStream(tCLbwgCwCwxQo);
		byte[] array = new byte[4];
		memoryStream.Read(array, 0, 4);
		int num = BitConverter.ToInt32(array, 0);
		using GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array2 = new byte[num];
		gZipStream.Read(array2, 0, num);
		return array2;
	}

	public static byte[] EjySUgKXdylXp(byte[] KFQETxdAAGyU)
	{
		using MemoryStream memoryStream = new MemoryStream();
		byte[] bytes = BitConverter.GetBytes(KFQETxdAAGyU.Length);
		memoryStream.Write(bytes, 0, 4);
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			gZipStream.Write(KFQETxdAAGyU, 0, KFQETxdAAGyU.Length);
			gZipStream.Flush();
		}
		return memoryStream.ToArray();
	}
}
