using System;
using System.IO;
using System.IO.Compression;

namespace yKFnPcLKLkIvyuyev;

public static class NGisxejvQwVr
{
	public static byte[] qIWGxapWynhKI(byte[] wEznOWoxYtiiYnc)
	{
		using MemoryStream memoryStream = new MemoryStream(wEznOWoxYtiiYnc);
		byte[] array = new byte[4];
		memoryStream.Read(array, 0, 4);
		int num = BitConverter.ToInt32(array, 0);
		using GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array2 = new byte[num];
		gZipStream.Read(array2, 0, num);
		return array2;
	}

	public static byte[] erJxJWuxfPFAW(byte[] mgSClWtxYU)
	{
		using MemoryStream memoryStream = new MemoryStream();
		byte[] bytes = BitConverter.GetBytes(mgSClWtxYU.Length);
		memoryStream.Write(bytes, 0, 4);
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			gZipStream.Write(mgSClWtxYU, 0, mgSClWtxYU.Length);
			gZipStream.Flush();
		}
		return memoryStream.ToArray();
	}
}
