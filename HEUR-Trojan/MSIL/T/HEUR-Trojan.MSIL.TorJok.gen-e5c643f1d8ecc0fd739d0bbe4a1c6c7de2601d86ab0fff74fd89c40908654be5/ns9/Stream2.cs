using System;
using System.IO;

namespace ns9;

internal sealed class Stream2 : Stream, IDisposable
{
	private long long_0;

	private Stream stream_0;

	bool Stream.CanRead => stream_0.CanRead;

	bool Stream.CanSeek => stream_0.CanSeek;

	bool Stream.CanWrite => false;

	long Stream.Length => stream_0.Length;

	long Stream.Position
	{
		get
		{
			return stream_0.Position - long_0;
		}
		set
		{
			stream_0.Position = long_0 + value;
		}
	}

	public Stream2(Stream stream_1)
	{
		long_0 = stream_1.Position;
		stream_0 = stream_1;
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		return stream_0.Read(buffer, offset, count);
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}

	void Stream.Flush()
	{
		stream_0.Flush();
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		return stream_0.Seek(long_0 + offset, origin) - long_0;
	}

	void Stream.SetLength(long value)
	{
		throw new NotImplementedException();
	}

	void IDisposable.Dispose()
	{
		Close();
	}

	void Stream.Close()
	{
		base.Close();
	}
}
