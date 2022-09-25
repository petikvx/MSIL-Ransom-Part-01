using System;
using System.IO;

namespace Ionic.Zip;

internal class OffsetStream : Stream, IDisposable
{
	private long _originalPosition;

	private Stream _innerStream;

	public override bool CanRead => _innerStream.CanRead;

	public override bool CanSeek => _innerStream.CanSeek;

	public override bool CanWrite => false;

	public override long Length => _innerStream.Length;

	public override long Position
	{
		get
		{
			return _innerStream.Position - _originalPosition;
		}
		set
		{
			_innerStream.Position = _originalPosition + value;
		}
	}

	public OffsetStream(Stream s)
	{
		_originalPosition = s.Position;
		_innerStream = s;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return _innerStream.Read(buffer, offset, count);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}

	public override void Flush()
	{
		_innerStream.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return _innerStream.Seek(_originalPosition + offset, origin) - _originalPosition;
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
