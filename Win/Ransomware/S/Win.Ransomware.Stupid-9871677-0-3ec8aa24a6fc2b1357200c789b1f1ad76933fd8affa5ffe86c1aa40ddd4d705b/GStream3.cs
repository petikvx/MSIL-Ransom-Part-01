using System;
using System.IO;
using Ionic.Zlib;

public class GStream3 : Stream
{
	internal Stream0 stream0_0;

	private bool bool_0;

	public virtual FlushType FlushMode
	{
		get
		{
			return stream0_0.flushType_0;
		}
		set
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("ZlibStream");
			}
			stream0_0.flushType_0 = value;
		}
	}

	public int Int32_0
	{
		get
		{
			return stream0_0.int_0;
		}
		set
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("ZlibStream");
			}
			if (stream0_0.byte_0 != null)
			{
				throw new GException0("The working buffer is already set.");
			}
			if (value < 1024)
			{
				throw new GException0($"Don't be silly. {value} bytes?? Use a bigger buffer, at least {1024}.");
			}
			stream0_0.int_0 = value;
		}
	}

	public virtual long TotalIn => stream0_0.gclass5_0.long_0;

	public virtual long TotalOut => stream0_0.gclass5_0.long_1;

	public override bool CanRead
	{
		get
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("ZlibStream");
			}
			return stream0_0.stream_0.CanRead;
		}
	}

	public override bool CanSeek => false;

	public override bool CanWrite
	{
		get
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("ZlibStream");
			}
			return stream0_0.stream_0.CanWrite;
		}
	}

	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public override long Position
	{
		get
		{
			if (stream0_0.enum4_0 == Stream0.Enum4.const_0)
			{
				return stream0_0.gclass5_0.long_1;
			}
			if (stream0_0.enum4_0 == Stream0.Enum4.const_1)
			{
				return stream0_0.gclass5_0.long_0;
			}
			return 0L;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public GStream3(Stream stream, CompressionMode mode)
		: this(stream, mode, CompressionLevel.Default, leaveOpen: false)
	{
	}

	public GStream3(Stream stream, CompressionMode mode, CompressionLevel level)
		: this(stream, mode, level, leaveOpen: false)
	{
	}

	public GStream3(Stream stream, CompressionMode mode, bool leaveOpen)
		: this(stream, mode, CompressionLevel.Default, leaveOpen)
	{
	}

	public GStream3(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
	{
		stream0_0 = new Stream0(stream, mode, level, ZlibStreamFlavor.ZLIB, leaveOpen);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!bool_0)
			{
				if (disposing && stream0_0 != null)
				{
					stream0_0.Close();
				}
				bool_0 = true;
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public override void Flush()
	{
		if (bool_0)
		{
			throw new ObjectDisposedException("ZlibStream");
		}
		stream0_0.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (bool_0)
		{
			throw new ObjectDisposedException("ZlibStream");
		}
		return stream0_0.Read(buffer, offset, count);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (bool_0)
		{
			throw new ObjectDisposedException("ZlibStream");
		}
		stream0_0.Write(buffer, offset, count);
	}

	public static byte[] smethod_0(string string_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Stream stream_ = new GStream3(memoryStream, CompressionMode.Compress, CompressionLevel.BestCompression);
		Stream0.smethod_0(string_0, stream_);
		return memoryStream.ToArray();
	}

	public static byte[] smethod_1(byte[] byte_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		Stream stream_ = new GStream3(memoryStream, CompressionMode.Compress, CompressionLevel.BestCompression);
		Stream0.smethod_1(byte_0, stream_);
		return memoryStream.ToArray();
	}

	public static string smethod_2(byte[] byte_0)
	{
		using MemoryStream stream = new MemoryStream(byte_0);
		Stream stream_ = new GStream3(stream, CompressionMode.Decompress);
		return Stream0.smethod_2(byte_0, stream_);
	}

	public static byte[] smethod_3(byte[] byte_0)
	{
		using MemoryStream stream = new MemoryStream(byte_0);
		Stream stream_ = new GStream3(stream, CompressionMode.Decompress);
		return Stream0.smethod_3(byte_0, stream_);
	}
}
