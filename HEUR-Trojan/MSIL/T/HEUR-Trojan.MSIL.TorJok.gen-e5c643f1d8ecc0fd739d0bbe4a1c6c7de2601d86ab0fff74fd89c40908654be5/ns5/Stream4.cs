using System.IO;

namespace ns5;

internal sealed class Stream4 : Stream
{
	internal Stream stream_0;

	internal long long_0;

	internal long long_1;

	internal long long_2;

	bool Stream.CanRead => stream_0.CanRead;

	bool Stream.CanSeek => stream_0.CanSeek;

	bool Stream.CanWrite => stream_0.CanWrite;

	long Stream.Length => stream_0.Length;

	long Stream.Position
	{
		get
		{
			return stream_0.Position;
		}
		set
		{
			stream_0.Seek(value, SeekOrigin.Begin);
		}
	}

	public Stream4(Stream stream_1)
	{
		stream_0 = stream_1;
		try
		{
			long_2 = stream_0.Position;
		}
		catch
		{
			long_2 = 0L;
		}
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		int num = stream_0.Read(buffer, offset, count);
		long_1 += num;
		return num;
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		if (count != 0)
		{
			stream_0.Write(buffer, offset, count);
			long_0 += count;
		}
	}

	void Stream.Flush()
	{
		stream_0.Flush();
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		return stream_0.Seek(offset, origin);
	}

	void Stream.SetLength(long value)
	{
		stream_0.SetLength(value);
	}
}
