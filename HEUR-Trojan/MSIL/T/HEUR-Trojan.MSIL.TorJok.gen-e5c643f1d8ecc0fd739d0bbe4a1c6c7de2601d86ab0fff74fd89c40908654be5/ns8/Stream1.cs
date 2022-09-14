using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns1;
using ns5;

namespace ns8;

internal sealed class Stream1 : Stream
{
	internal Stream stream_0;

	internal GClass0 gclass0_0;

	internal bool bool_0;

	internal Stream13 stream13_0;

	internal long long_0;

	internal string string_0;

	private long long_1;

	private string string_1;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	[CompilerGenerated]
	private int int_0;

	bool Stream.CanRead => true;

	bool Stream.CanSeek => stream_0.CanSeek;

	bool Stream.CanWrite => false;

	long Stream.Length => stream_0.Length;

	long Stream.Position
	{
		get
		{
			return stream_0.Position;
		}
		set
		{
			Seek(value, SeekOrigin.Begin);
		}
	}

	string object.ToString()
	{
		return $"ZipInputStream::{string_1}(leaveOpen({bool_1})))";
	}

	[SpecialName]
	[CompilerGenerated]
	public int method_0()
	{
		return int_0;
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		if (bool_2)
		{
			bool_4 = true;
			throw new InvalidOperationException("The stream has been closed.");
		}
		if (bool_0)
		{
			Class6.smethod_521(this);
		}
		if (long_0 == 0L)
		{
			return 0;
		}
		int count2 = (int)((long_0 > count) ? count : long_0);
		int num = stream13_0.Read(buffer, offset, count2);
		long_0 -= num;
		if (long_0 == 0L)
		{
			int num2 = Class6.smethod_336(stream13_0);
			Class6.smethod_453(num2, gclass0_0);
			stream_0.Seek(long_1, SeekOrigin.Begin);
		}
		return num;
	}

	void Stream.Dispose(bool disposing)
	{
		if (bool_2)
		{
			return;
		}
		if (disposing)
		{
			if (bool_4)
			{
				return;
			}
			if (!bool_1)
			{
				stream_0.Dispose();
			}
		}
		bool_2 = true;
	}

	void Stream.Flush()
	{
		throw new NotSupportedException("Flush");
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("Write");
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		bool_3 = true;
		return stream_0.Seek(offset, origin);
	}

	void Stream.SetLength(long value)
	{
		throw new NotSupportedException();
	}
}
