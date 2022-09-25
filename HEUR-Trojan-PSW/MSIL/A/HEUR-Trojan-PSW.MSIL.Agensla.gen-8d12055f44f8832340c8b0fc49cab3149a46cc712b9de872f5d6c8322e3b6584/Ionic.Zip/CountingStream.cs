using System;
using System.IO;

namespace Ionic.Zip;

public class CountingStream : Stream
{
	private Stream _s;

	private long _bytesWritten;

	private long _bytesRead;

	private long _initialOffset;

	public Stream WrappedStream => _s;

	public long BytesWritten => _bytesWritten;

	public long BytesRead => _bytesRead;

	public override bool CanRead => _s.CanRead;

	public override bool CanSeek => _s.CanSeek;

	public override bool CanWrite => _s.CanWrite;

	public override long Length => _s.Length;

	public long ComputedPosition => _initialOffset + _bytesWritten;

	public override long Position
	{
		get
		{
			return _s.Position;
		}
		set
		{
			_s.Seek(value, SeekOrigin.Begin);
		}
	}

	public CountingStream(Stream stream)
	{
		_s = stream;
		try
		{
			_initialOffset = _s.Position;
		}
		catch
		{
			_initialOffset = 0L;
		}
	}

	public void Adjust(long delta)
	{
		_bytesWritten -= delta;
		if (_bytesWritten < 0L)
		{
			throw new InvalidOperationException();
		}
		if (_s is CountingStream)
		{
			((CountingStream)_s).Adjust(delta);
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num = _s.Read(buffer, offset, count);
		_bytesRead += num;
		return num;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (count != 0)
		{
			_s.Write(buffer, offset, count);
			_bytesWritten += count;
		}
	}

	public override void Flush()
	{
		_s.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return _s.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		_s.SetLength(value);
	}
}
