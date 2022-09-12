using System;
using System.IO;

namespace Gecko.IO;

public sealed class OutputStream : Stream
{
	private bool _seekable;

	private nsISeekableStream _seekableStream;

	internal nsIOutputStream _outputStream;

	public override bool CanRead => false;

	public override bool CanSeek => _seekable;

	public override bool CanWrite => true;

	public override long Length => _seekableStream.Tell();

	public override long Position
	{
		get
		{
			return _seekableStream.Tell();
		}
		set
		{
			_seekableStream.Seek(0, (int)value);
		}
	}

	private OutputStream(nsIOutputStream outputStream)
	{
		_outputStream = outputStream;
		_seekableStream = Xpcom.QueryInterface<nsISeekableStream>(outputStream);
		_seekable = _seekableStream != null;
	}

	protected override void Dispose(bool disposing)
	{
		Xpcom.FreeComObject(ref _seekableStream);
		Xpcom.FreeComObject(ref _outputStream);
		base.Dispose(disposing);
	}

	public override void Close()
	{
		_outputStream.Close();
	}

	public override void Flush()
	{
		_outputStream.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		_seekableStream.Seek((int)origin, (int)offset);
		return _seekableStream.Tell();
	}

	public override void SetLength(long value)
	{
		int num = _seekableStream.Tell();
		_seekableStream.Seek(0, (int)value);
		_seekableStream.SetEOF();
		_seekableStream.Seek(0, num);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("OutputStream can only write data :)");
	}

	public unsafe override void WriteByte(byte value)
	{
		byte* value2 = &value;
		_outputStream.Write(new IntPtr(value2), 1u);
	}

	public unsafe override void Write(byte[] buffer, int offset, int count)
	{
		if (offset + count > buffer.Length)
		{
			throw new ArgumentOutOfRangeException();
		}
		fixed (byte* ptr = buffer)
		{
			byte* value = ptr + offset;
			_outputStream.Write(new IntPtr(value), (uint)count);
		}
	}

	public static OutputStream Create(nsIOutputStream stream)
	{
		return new OutputStream(stream);
	}
}
