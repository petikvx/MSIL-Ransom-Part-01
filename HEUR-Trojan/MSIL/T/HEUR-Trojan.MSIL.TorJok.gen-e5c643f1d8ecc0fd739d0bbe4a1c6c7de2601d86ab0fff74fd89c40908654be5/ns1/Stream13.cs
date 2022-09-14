using System;
using System.IO;
using ns0;
using ns5;

namespace ns1;

internal sealed class Stream13 : Stream, IDisposable
{
	private static readonly long long_0 = -99L;

	internal Stream stream_0;

	internal GClass3 gclass3_0;

	private long long_1 = -99L;

	private bool bool_0;

	bool Stream.CanRead => stream_0.CanRead;

	bool Stream.CanSeek => false;

	bool Stream.CanWrite => stream_0.CanWrite;

	long Stream.Length
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

	long Stream.Position
	{
		get
		{
			return gclass3_0.long_0;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public Stream13(Stream stream_1)
		: this(bool_1: true, long_0, stream_1, null)
	{
	}

	public Stream13(Stream stream_1, bool bool_1)
		: this(bool_1, long_0, stream_1, null)
	{
	}

	public Stream13(Stream stream_1, long long_2)
		: this(bool_1: true, long_2, stream_1, null)
	{
		if (long_2 < 0L)
		{
			throw new ArgumentException("length");
		}
	}

	private Stream13(bool bool_1, long long_2, Stream stream_1, GClass3 gclass3_1)
	{
		stream_0 = stream_1;
		gclass3_0 = gclass3_1 ?? new GClass3();
		long_1 = long_2;
		bool_0 = bool_1;
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		int count2 = count;
		if (long_1 != long_0)
		{
			if (gclass3_0.long_0 >= long_1)
			{
				return 0;
			}
			long num = long_1 - gclass3_0.long_0;
			if (num < count)
			{
				count2 = (int)num;
			}
		}
		int num2 = stream_0.Read(buffer, offset, count2);
		if (num2 > 0)
		{
			Class6.smethod_23(gclass3_0, buffer, offset, num2);
		}
		return num2;
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		if (count > 0)
		{
			Class6.smethod_23(gclass3_0, buffer, offset, count);
		}
		stream_0.Write(buffer, offset, count);
	}

	void Stream.Flush()
	{
		stream_0.Flush();
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	void Stream.SetLength(long value)
	{
		throw new NotSupportedException();
	}

	void IDisposable.Dispose()
	{
		Close();
	}

	void Stream.Close()
	{
		base.Close();
		if (!bool_0)
		{
			stream_0.Close();
		}
	}
}
