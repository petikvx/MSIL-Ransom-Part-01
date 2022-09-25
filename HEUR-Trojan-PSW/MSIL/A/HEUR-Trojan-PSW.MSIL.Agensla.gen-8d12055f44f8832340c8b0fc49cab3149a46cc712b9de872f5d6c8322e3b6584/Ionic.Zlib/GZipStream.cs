using System;
using System.IO;
using System.Text;

namespace Ionic.Zlib;

public class GZipStream : Stream
{
	public DateTime? LastModified;

	private int _headerByteCount;

	internal ZlibBaseStream _baseStream;

	private bool _disposed;

	private bool _firstReadDone;

	private string _FileName;

	private string _Comment;

	private int _Crc32;

	internal static readonly DateTime _unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	internal static readonly Encoding iso8859dash1 = Encoding.GetEncoding("iso-8859-1");

	public string Comment
	{
		get
		{
			return _Comment;
		}
		set
		{
			if (_disposed)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			_Comment = value;
		}
	}

	public string FileName
	{
		get
		{
			return _FileName;
		}
		set
		{
			if (_disposed)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			_FileName = value;
			if (_FileName != null)
			{
				if (_FileName.IndexOf("/") != -1)
				{
					_FileName = _FileName.Replace("/", "\\");
				}
				if (_FileName.EndsWith("\\"))
				{
					throw new Exception("Illegal filename");
				}
				if (_FileName.IndexOf("\\") != -1)
				{
					_FileName = Path.GetFileName(_FileName);
				}
			}
		}
	}

	public int Crc32 => _Crc32;

	public override bool CanRead
	{
		get
		{
			if (_disposed)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			return _baseStream._stream.CanRead;
		}
	}

	public override bool CanSeek => false;

	public override bool CanWrite
	{
		get
		{
			if (_disposed)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			return _baseStream._stream.CanWrite;
		}
	}

	public override long Length
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override long Position
	{
		get
		{
			if (_baseStream._streamMode == ZlibBaseStream.StreamMode.Writer)
			{
				return _baseStream._z.TotalBytesOut + _headerByteCount;
			}
			if (_baseStream._streamMode == ZlibBaseStream.StreamMode.Reader)
			{
				return _baseStream._z.TotalBytesIn + _baseStream._gzipHeaderByteCount;
			}
			return 0L;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public GZipStream(Stream stream, CompressionMode mode)
		: this(stream, mode, CompressionLevel.Default, leaveOpen: false)
	{
	}

	public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level)
		: this(stream, mode, level, leaveOpen: false)
	{
	}

	public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
	{
		_baseStream = new ZlibBaseStream(stream, mode, level, ZlibStreamFlavor.GZIP, leaveOpen);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!_disposed)
			{
				if (disposing && _baseStream != null)
				{
					_baseStream.Dispose();
					_Crc32 = _baseStream.Crc32;
				}
				_disposed = true;
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public override void Flush()
	{
		if (_disposed)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		_baseStream.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (_disposed)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		int result = _baseStream.Read(buffer, offset, count);
		if (!_firstReadDone)
		{
			_firstReadDone = true;
			FileName = _baseStream._GzipFileName;
			Comment = _baseStream._GzipComment;
		}
		return result;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotImplementedException();
	}

	public override void SetLength(long value)
	{
		throw new NotImplementedException();
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (_disposed)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		if (_baseStream._streamMode == ZlibBaseStream.StreamMode.Undefined)
		{
			if (!_baseStream._wantCompress)
			{
				throw new InvalidOperationException();
			}
			_headerByteCount = EmitHeader();
		}
		_baseStream.Write(buffer, offset, count);
	}

	private int EmitHeader()
	{
		byte[] array = ((Comment == null) ? null : iso8859dash1.GetBytes(Comment));
		byte[] array2 = ((FileName == null) ? null : iso8859dash1.GetBytes(FileName));
		int num = ((Comment != null) ? (array.Length + 1) : 0);
		int num2 = ((FileName != null) ? (array2.Length + 1) : 0);
		byte[] array3 = new byte[10 + num + num2];
		int num3 = 0;
		num3 = 1;
		array3[0] = 31;
		num3 = 2;
		array3[1] = 139;
		num3 = 3;
		array3[2] = 8;
		byte b = 0;
		if (Comment != null)
		{
			b = (byte)(b ^ 0x10u);
		}
		if (FileName != null)
		{
			b = (byte)(b ^ 8u);
		}
		array3[num3++] = b;
		if (!LastModified.HasValue)
		{
			LastModified = DateTime.Now;
		}
		Array.Copy(BitConverter.GetBytes((int)(LastModified.Value - _unixEpoch).TotalSeconds), 0, array3, num3, 4);
		num3 += 4;
		array3[num3++] = 0;
		array3[num3++] = byte.MaxValue;
		if (num2 != 0)
		{
			Array.Copy(array2, 0, array3, num3, num2 - 1);
			num3 += num2 - 1;
			array3[num3++] = 0;
		}
		if (num != 0)
		{
			Array.Copy(array, 0, array3, num3, num - 1);
			num3 += num - 1;
			array3[num3++] = 0;
		}
		_baseStream._stream.Write(array3, 0, array3.Length);
		return array3.Length;
	}
}
