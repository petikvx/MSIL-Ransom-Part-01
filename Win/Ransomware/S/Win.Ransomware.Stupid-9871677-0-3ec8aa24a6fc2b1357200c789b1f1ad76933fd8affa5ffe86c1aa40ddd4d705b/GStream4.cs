using System;
using System.IO;

public class GStream4 : Stream
{
	private Stream stream_0;

	private long long_0;

	private long long_1;

	private long long_2;

	public Stream Stream_0 => stream_0;

	public long Int64_0 => long_0;

	public long Int64_1 => long_1;

	public override bool CanRead => stream_0.CanRead;

	public override bool CanSeek => stream_0.CanSeek;

	public override bool CanWrite => stream_0.CanWrite;

	public override long Length => stream_0.Length;

	public long Int64_2 => long_2 + long_0;

	public override long Position
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

	public GStream4(Stream stream)
	{
		stream_0 = stream;
		try
		{
			long_2 = stream_0.Position;
		}
		catch
		{
			long_2 = 0L;
		}
	}

	public void method_0(long long_3)
	{
		long_0 -= long_3;
		if (long_0 < 0L)
		{
			throw new InvalidOperationException();
		}
		if (stream_0 is GStream4)
		{
			((GStream4)stream_0).method_0(long_3);
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num = stream_0.Read(buffer, offset, count);
		long_1 += num;
		return num;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (count != 0)
		{
			stream_0.Write(buffer, offset, count);
			long_0 += count;
		}
	}

	public override void Flush()
	{
		stream_0.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return stream_0.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		stream_0.SetLength(value);
	}
}
