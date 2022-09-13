using System;
using System.IO;

internal class Stream1 : Stream, IDisposable
{
	private long long_0;

	private Stream stream_0;

	public override bool CanRead => stream_0.CanRead;

	public override bool CanSeek => stream_0.CanSeek;

	public override bool CanWrite => false;

	public override long Length => stream_0.Length;

	public override long Position
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

	public Stream1(Stream s)
	{
		long_0 = s.Position;
		stream_0 = s;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return stream_0.Read(buffer, offset, count);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}

	public override void Flush()
	{
		stream_0.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return stream_0.Seek(long_0 + offset, origin) - long_0;
	}

	public override void SetLength(long value)
	{
		throw new NotImplementedException();
	}

	void IDisposable.Dispose()
	{
		Close();
	}

	public override void Close()
	{
		base.Close();
	}
}
