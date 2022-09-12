using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.IO;

public class InputStream : Stream
{
	private bool _seekable;

	private nsISeekableStream _seekableStream;

	internal nsIInputStream _inputStream;

	public override bool CanRead => true;

	public override bool CanSeek => _seekable;

	public override bool CanWrite => false;

	public override long Length
	{
		get
		{
			if (_seekable)
			{
				return _seekableStream.Tell() + _inputStream.Available();
			}
			return _inputStream.Available();
		}
	}

	public override long Position
	{
		get
		{
			return _seekable ? _seekableStream.Tell() : 0;
		}
		set
		{
			if (_seekable)
			{
				_seekableStream.Seek(0, (int)value);
			}
		}
	}

	public long Available => _inputStream.Available();

	internal InputStream(nsIInputStream inputStream)
	{
		_inputStream = inputStream;
		_seekableStream = Xpcom.QueryInterface<nsISeekableStream>(inputStream);
		_seekable = _seekableStream != null;
	}

	protected override void Dispose(bool disposing)
	{
		Xpcom.FreeComObject(ref _seekableStream);
		Xpcom.FreeComObject(ref _inputStream);
		base.Dispose(disposing);
	}

	public override void Flush()
	{
	}

	public override void Close()
	{
		_inputStream.Close();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		_seekableStream.Seek((int)origin, offset);
		return _seekableStream.Tell();
	}

	public override void SetLength(long value)
	{
		int num = _seekableStream.Tell();
		_seekableStream.Seek(0, (int)value);
		_seekableStream.SetEOF();
		if (num < value)
		{
			_seekableStream.Seek(0, num);
		}
	}

	public unsafe override int Read(byte[] buffer, int offset, int count)
	{
		if (offset < 0 || count <= 0)
		{
			return 0;
		}
		if (offset + count > buffer.Length)
		{
			return 0;
		}
		uint result;
		fixed (byte* ptr = buffer)
		{
			byte* value = ptr + offset;
			result = _inputStream.Read(new IntPtr(value), (uint)count);
		}
		return (int)result;
	}

	public unsafe override int ReadByte()
	{
		byte b = default(byte);
		byte* value = &b;
		return (_inputStream.Read(new IntPtr(value), 1u) == 0) ? (-1) : b;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("InputStream can only read data :)");
	}

	public string ReadLine()
	{
		StringBuilder stringBuilder = new StringBuilder(64);
		uint num = _inputStream.Available();
		for (int i = 0; i < num; i++)
		{
			int num2 = ReadByte();
			if (num2 >= 0)
			{
				char c = (char)(byte)num2;
				switch (c)
				{
				default:
					stringBuilder.Append(c);
					continue;
				case '\r':
					continue;
				case '\n':
					break;
				}
			}
			break;
		}
		return stringBuilder.ToString();
	}

	public static InputStream Create(nsIInputStream stream)
	{
		nsIMIMEInputStream nsIMIMEInputStream = Xpcom.QueryInterface<nsIMIMEInputStream>(stream);
		if (nsIMIMEInputStream != null)
		{
			Marshal.ReleaseComObject(stream);
			return new MimeInputStream(nsIMIMEInputStream);
		}
		nsIStringInputStream nsIStringInputStream = Xpcom.QueryInterface<nsIStringInputStream>(stream);
		if (nsIStringInputStream != null)
		{
			Marshal.ReleaseComObject(stream);
			return new StringInputStream(nsIStringInputStream);
		}
		return new InputStream(stream);
	}
}
