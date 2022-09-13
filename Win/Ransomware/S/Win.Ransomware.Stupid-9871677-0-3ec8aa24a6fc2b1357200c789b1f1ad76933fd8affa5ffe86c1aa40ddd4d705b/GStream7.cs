using System;
using System.IO;

public class GStream7 : Stream, IDisposable
{
	private static readonly long long_0 = -99L;

	internal Stream stream_0;

	private GClass12 gclass12_0;

	private long long_1 = -99L;

	private bool bool_0;

	public long Int64_0 => gclass12_0.Int64_0;

	public int Int32_0 => gclass12_0.Int32_0;

	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public override bool CanRead => stream_0.CanRead;

	public override bool CanSeek => false;

	public override bool CanWrite => stream_0.CanWrite;

	public override long Length
	{
		get
		{
			if (long_1 == long_0)
			{
				return stream_0.Length;
			}
			return long_1;
		}
	}

	public override long Position
	{
		get
		{
			return gclass12_0.Int64_0;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public GStream7(Stream stream)
		: this(leaveOpen: true, long_0, stream, null)
	{
	}

	public GStream7(Stream stream, bool leaveOpen)
		: this(leaveOpen, long_0, stream, null)
	{
	}

	public GStream7(Stream stream, long length)
		: this(leaveOpen: true, length, stream, null)
	{
		if (length < 0L)
		{
			throw new ArgumentException("length");
		}
	}

	public GStream7(Stream stream, long length, bool leaveOpen)
		: this(leaveOpen, length, stream, null)
	{
		if (length < 0L)
		{
			throw new ArgumentException("length");
		}
	}

	public GStream7(Stream stream, long length, bool leaveOpen, GClass12 crc32)
		: this(leaveOpen, length, stream, crc32)
	{
		if (length < 0L)
		{
			throw new ArgumentException("length");
		}
	}

	private GStream7(bool leaveOpen, long length, Stream stream, GClass12 crc32)
	{
		stream_0 = stream;
		gclass12_0 = crc32 ?? new GClass12();
		long_1 = length;
		bool_0 = leaveOpen;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int count2 = count;
		if (long_1 != long_0)
		{
			if (gclass12_0.Int64_0 >= long_1)
			{
				return 0;
			}
			long num = long_1 - gclass12_0.Int64_0;
			if (num < count)
			{
				count2 = (int)num;
			}
		}
		int num2 = stream_0.Read(buffer, offset, count2);
		if (num2 > 0)
		{
			gclass12_0.method_4(buffer, offset, num2);
		}
		return num2;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (count > 0)
		{
			gclass12_0.method_4(buffer, offset, count);
		}
		stream_0.Write(buffer, offset, count);
	}

	public override void Flush()
	{
		stream_0.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	void IDisposable.Dispose()
	{
		Close();
	}

	public override void Close()
	{
		base.Close();
		if (!bool_0)
		{
			stream_0.Close();
		}
	}
}
