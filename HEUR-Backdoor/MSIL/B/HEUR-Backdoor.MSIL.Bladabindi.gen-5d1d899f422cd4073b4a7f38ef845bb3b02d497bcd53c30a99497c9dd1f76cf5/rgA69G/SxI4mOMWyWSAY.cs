using System;
using System.IO;
using System.IO.Compression;

namespace rgA69G;

public static class SxI4mOMWyWSAY
{
	public static byte[] iKQRVJjO0lmN8Z(byte[] qz0GHg7)
	{
		using MemoryStream memoryStream = new MemoryStream(qz0GHg7);
		byte[] array = new byte[4];
		memoryStream.Read(array, 0, 4);
		int num = BitConverter.ToInt32(array, 0);
		using GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array2 = new byte[num];
		gZipStream.Read(array2, 0, num);
		return array2;
	}

	public static byte[] owEJxuSoVd4hJ(byte[] sEpLGIG8)
	{
		using MemoryStream memoryStream = new MemoryStream();
		byte[] bytes = BitConverter.GetBytes(sEpLGIG8.Length);
		memoryStream.Write(bytes, 0, 4);
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			gZipStream.Write(sEpLGIG8, 0, sEpLGIG8.Length);
			gZipStream.Flush();
		}
		return memoryStream.ToArray();
	}
}
