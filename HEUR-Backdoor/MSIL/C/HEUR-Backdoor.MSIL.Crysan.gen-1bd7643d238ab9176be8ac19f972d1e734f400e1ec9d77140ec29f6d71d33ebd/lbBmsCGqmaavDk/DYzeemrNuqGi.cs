using System;
using System.IO;
using System.IO.Compression;

namespace lbBmsCGqmaavDk;

public static class DYzeemrNuqGi
{
	public static byte[] KLKwzFgHTWV(byte[] sORHGzRrmkZrG)
	{
		using MemoryStream memoryStream = new MemoryStream(sORHGzRrmkZrG);
		byte[] array = new byte[4];
		memoryStream.Read(array, 0, 4);
		int num = BitConverter.ToInt32(array, 0);
		using GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array2 = new byte[num];
		gZipStream.Read(array2, 0, num);
		return array2;
	}

	public static byte[] pUmeTuMGuRTB(byte[] TUsrFtTZRwqt)
	{
		using MemoryStream memoryStream = new MemoryStream();
		byte[] bytes = BitConverter.GetBytes(TUsrFtTZRwqt.Length);
		memoryStream.Write(bytes, 0, 4);
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			gZipStream.Write(TUsrFtTZRwqt, 0, TUsrFtTZRwqt.Length);
			gZipStream.Flush();
		}
		return memoryStream.ToArray();
	}
}
