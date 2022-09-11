using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Shareware;

public class Compression
{
	public static string CompressedData(string Text)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(Text);
		MemoryStream memoryStream = new MemoryStream();
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true))
		{
			gZipStream.Write(bytes, 0, bytes.Length);
		}
		memoryStream.Position = 0L;
		new MemoryStream();
		checked
		{
			byte[] array = new byte[(int)(memoryStream.Length - 1L) + 1];
			memoryStream.Read(array, 0, array.Length);
			byte[] array2 = new byte[array.Length + 3 + 1];
			Buffer.BlockCopy(array, 0, array2, 4, array.Length);
			Buffer.BlockCopy(BitConverter.GetBytes(bytes.Length), 0, array2, 0, 4);
			return Convert.ToBase64String(array2);
		}
	}

	public static string DecompressData(string CompressedText)
	{
		byte[] array = Convert.FromBase64String(CompressedText);
		checked
		{
			using MemoryStream memoryStream = new MemoryStream();
			int num = BitConverter.ToInt32(array, 0);
			memoryStream.Write(array, 4, array.Length - 4);
			byte[] array2 = new byte[num - 1 + 1];
			memoryStream.Position = 0L;
			using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
			{
				gZipStream.Read(array2, 0, array2.Length);
			}
			return Encoding.Unicode.GetString(array2, 0, array2.Length);
		}
	}
}
