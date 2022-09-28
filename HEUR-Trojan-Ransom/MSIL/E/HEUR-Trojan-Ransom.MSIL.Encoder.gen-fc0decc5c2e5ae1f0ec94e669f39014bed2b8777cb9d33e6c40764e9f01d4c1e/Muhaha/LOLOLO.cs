using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Muhaha;

public static class LOLOLO
{
	public static string CompressToBase64(this string data)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(data).Compress());
	}

	public static string DecompressFromBase64(this string data)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(data).Decompress());
	}

	public static byte[] Compress(this byte[] data)
	{
		using MemoryStream stream = new MemoryStream(data);
		using MemoryStream memoryStream = new MemoryStream();
		stream.CompressTo(memoryStream);
		return memoryStream.ToArray();
	}

	public static byte[] Decompress(this byte[] data)
	{
		using MemoryStream stream = new MemoryStream(data);
		using MemoryStream memoryStream = new MemoryStream();
		stream.DecompressTo(memoryStream);
		return memoryStream.ToArray();
	}

	public static void CompressTo(this Stream stream, Stream outputStream)
	{
		using GZipStream gZipStream = new GZipStream(outputStream, CompressionMode.Compress);
		stream.CopyTo(gZipStream);
		gZipStream.Flush();
	}

	public static void DecompressTo(this Stream stream, Stream outputStream)
	{
		using GZipStream gZipStream = new GZipStream(stream, CompressionMode.Decompress);
		gZipStream.CopyTo(outputStream);
	}
}
