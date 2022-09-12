using System;
using System.IO;

namespace FileUtils;

public static class StreamExtensions
{
	private const int DefaultBufferSize = 16777216;

	public static long CopyTo(this Stream source, Stream destination)
	{
		return source.CopyTo(destination, 16777216, delegate
		{
		});
	}

	public static long CopyTo(this Stream source, Stream destination, int bufferSize)
	{
		return source.CopyTo(destination, bufferSize, delegate
		{
		});
	}

	public static long CopyTo(this Stream source, Stream destination, Action<long> reportProgress)
	{
		return source.CopyTo(destination, 16777216, reportProgress);
	}

	public static long CopyTo(this Stream source, Stream destination, int bufferSize, Action<long> reportProgress)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (reportProgress == null)
		{
			throw new ArgumentNullException("reportProgress");
		}
		byte[] array = new byte[bufferSize];
		long num = 0L;
		for (int num2 = source.Read(array, 0, array.Length); num2 > 0; num2 = source.Read(array, 0, array.Length))
		{
			num += num2;
			reportProgress(num);
			destination.Write(array, 0, num2);
		}
		destination.Flush();
		return num;
	}
}
