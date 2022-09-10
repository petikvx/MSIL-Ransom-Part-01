using System;
using System.IO;
using System.IO.Compression;

internal class Decompressed
{
	public static byte[] Decompress(byte[] bytData)
	{
		using (MemoryStream memoryStream = new MemoryStream(bytData))
		{
			using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
			{
				int num = 0;
				int num2;
				do
				{
					Array.Resize(ref bytData, num + 1024 - 1 + 1);
					num2 = Convert.ToInt32(gZipStream.Read(bytData, num, 1024));
					num += num2;
				}
				while (num2 >= 1024);
				Array.Resize(ref bytData, num - 1 + 1);
				gZipStream.Close();
			}
			memoryStream.Close();
		}
		return bytData;
	}
}
