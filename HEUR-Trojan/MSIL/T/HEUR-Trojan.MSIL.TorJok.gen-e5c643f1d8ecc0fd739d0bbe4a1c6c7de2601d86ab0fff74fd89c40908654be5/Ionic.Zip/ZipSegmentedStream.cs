using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns5;

namespace Ionic.Zip;

internal sealed class ZipSegmentedStream : Stream
{
	internal enum RwMode
	{
		None,
		ReadOnly,
		Write
	}

	internal RwMode rwMode_0;

	internal bool bool_0;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal string string_3;

	internal uint uint_0;

	internal uint uint_1;

	internal int int_0;

	internal Stream stream_0;

	[CompilerGenerated]
	private bool bool_1;

	bool Stream.CanRead
	{
		get
		{
			if (rwMode_0 == RwMode.ReadOnly && stream_0 != null)
			{
				return stream_0.CanRead;
			}
			return false;
		}
	}

	bool Stream.CanSeek
	{
		get
		{
			if (stream_0 != null)
			{
				return stream_0.CanSeek;
			}
			return false;
		}
	}

	bool Stream.CanWrite
	{
		get
		{
			if (rwMode_0 == RwMode.Write && stream_0 != null)
			{
				return stream_0.CanWrite;
			}
			return false;
		}
	}

	long Stream.Length => stream_0.Length;

	long Stream.Position
	{
		get
		{
			return stream_0.Position;
		}
		set
		{
			stream_0.Position = value;
		}
	}

	internal ZipSegmentedStream()
	{
		bool_0 = false;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_0()
	{
		return bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(bool bool_2)
	{
		bool_1 = bool_2;
	}

	string object.ToString()
	{
		return string.Format("{0}[{1}][{2}], pos=0x{3:X})", "ZipSegmentedStream", Class6.smethod_649(this), rwMode_0.ToString(), Position);
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		if (rwMode_0 != RwMode.ReadOnly)
		{
			bool_0 = true;
			throw new InvalidOperationException("Stream Error: Cannot Read.");
		}
		int num = stream_0.Read(buffer, offset, count);
		int num2 = num;
		while (true)
		{
			if (num2 != count)
			{
				if (stream_0.Position == stream_0.Length)
				{
					if (uint_0 + 1 == uint_1)
					{
						break;
					}
					Class6.smethod_395(this, uint_0 + 1);
					Class6.smethod_662(this);
					offset += num2;
					count -= num2;
					num2 = stream_0.Read(buffer, offset, count);
					num += num2;
					continue;
				}
				bool_0 = true;
				throw new ZipException($"Read error in file {Class6.smethod_649(this)}");
			}
			return num;
		}
		return num;
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		if (rwMode_0 != RwMode.Write)
		{
			bool_0 = true;
			throw new InvalidOperationException("Stream Error: Cannot Write.");
		}
		if (method_0())
		{
			if (stream_0.Position + count > int_0)
			{
				Class6.smethod_43(this, 1u);
			}
		}
		else
		{
			while (stream_0.Position + count > int_0)
			{
				int num = int_0 - (int)stream_0.Position;
				stream_0.Write(buffer, offset, num);
				Class6.smethod_43(this, 1u);
				count -= num;
				offset += num;
			}
		}
		stream_0.Write(buffer, offset, count);
	}

	void Stream.Flush()
	{
		stream_0.Flush();
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		return stream_0.Seek(offset, origin);
	}

	void Stream.SetLength(long value)
	{
		if (rwMode_0 != RwMode.Write)
		{
			bool_0 = true;
			throw new InvalidOperationException();
		}
		stream_0.SetLength(value);
	}

	void Stream.Dispose(bool disposing)
	{
		try
		{
			if (stream_0 != null)
			{
				stream_0.Dispose();
				if (rwMode_0 != RwMode.Write)
				{
				}
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}
}
