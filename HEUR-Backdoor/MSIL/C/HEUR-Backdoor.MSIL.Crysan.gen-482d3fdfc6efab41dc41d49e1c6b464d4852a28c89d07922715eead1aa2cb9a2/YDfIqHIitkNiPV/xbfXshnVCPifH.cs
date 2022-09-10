using System;
using System.IO;
using System.IO.Compression;

namespace YDfIqHIitkNiPV;

public static class xbfXshnVCPifH
{
	public static byte[] emiUIBjFUmzH(byte[] NpPotewkzUjWHC)
	{
		using MemoryStream memoryStream = new MemoryStream(NpPotewkzUjWHC);
		byte[] array = new byte[4];
		memoryStream.Read(array, 0, 4);
		int num = BitConverter.ToInt32(array, 0);
		using GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array2 = new byte[num];
		gZipStream.Read(array2, 0, num);
		return array2;
	}

	public static byte[] IENiPWJnbCwq(byte[] gFURIufNxl)
	{
		using MemoryStream memoryStream = new MemoryStream();
		byte[] bytes = BitConverter.GetBytes(gFURIufNxl.Length);
		memoryStream.Write(bytes, 0, 4);
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			gZipStream.Write(gFURIufNxl, 0, gFURIufNxl.Length);
			gZipStream.Flush();
		}
		return memoryStream.ToArray();
	}
}
