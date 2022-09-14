using System;
using System.IO;
using ns1;
using ns3;
using ns4;
using ns5;

namespace ns8;

internal sealed class Stream7 : Stream
{
	[Flags]
	private enum Enum12 : uint
	{
		flag_0 = 0u,
		flag_1 = 1u,
		flag_2 = 2u,
		flag_3 = uint.MaxValue
	}

	private int int_0;

	private bool bool_0;

	internal Class32 class32_0;

	internal uint uint_0;

	internal Stream stream_0;

	internal Class31 class31_0;

	internal int int_1;

	private Enum12 enum12_0 = Enum12.flag_1 | Enum12.flag_2;

	bool Stream.CanRead => false;

	bool Stream.CanSeek => false;

	bool Stream.CanWrite
	{
		get
		{
			if (stream_0 == null)
			{
				throw new ObjectDisposedException("BZip2Stream");
			}
			return stream_0.CanWrite;
		}
	}

	long Stream.Length
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	long Stream.Position
	{
		get
		{
			return int_0;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public Stream7(Stream stream_1, bool bool_1)
		: this(stream_1, Class35.int_2, bool_1)
	{
	}

	public Stream7(Stream stream_1, int int_2, bool bool_1)
	{
		if (int_2 >= Class35.int_1 && int_2 <= Class35.int_2)
		{
			stream_0 = stream_1;
			if (!stream_0.CanWrite)
			{
				throw new ArgumentException("The stream is not writable.", "output");
			}
			class31_0 = new Class31(stream_0);
			int_1 = int_2;
			class32_0 = new Class32(class31_0, int_2);
			bool_0 = bool_1;
			uint_0 = 0u;
			Class6.smethod_672(this);
			return;
		}
		string message = $"blockSize={int_2} is out of range; must be between {Class35.int_1} and {Class35.int_2}";
		throw new ArgumentException(message, "blockSize");
	}

	void Stream.Close()
	{
		if (stream_0 != null)
		{
			Stream stream = stream_0;
			Class6.smethod_483(this);
			if (!bool_0)
			{
				stream.Close();
			}
		}
	}

	void Stream.Flush()
	{
		if (stream_0 != null)
		{
			Class6.smethod_304(class31_0);
			stream_0.Flush();
		}
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		if (offset < 0)
		{
			throw new IndexOutOfRangeException($"offset ({offset}) must be > 0");
		}
		if (count < 0)
		{
			throw new IndexOutOfRangeException($"count ({count}) must be > 0");
		}
		if (offset + count > buffer.Length)
		{
			throw new IndexOutOfRangeException($"offset({offset}) count({count}) bLength({buffer.Length})");
		}
		if (stream_0 == null)
		{
			throw new IOException("the stream is not open");
		}
		if (count == 0)
		{
			return;
		}
		int num = 0;
		int num2 = count;
		do
		{
			int num3 = Class6.smethod_166(class32_0, buffer, offset, num2);
			if (num3 != num2)
			{
				Class6.smethod_162(class32_0);
				uint_0 = (uint_0 << 1) | (uint_0 >> 31);
				uint_0 ^= class32_0.method_0();
				offset += num3;
			}
			num2 -= num3;
			num += num3;
		}
		while (num2 > 0);
		int_0 += num;
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		throw new NotImplementedException();
	}

	void Stream.SetLength(long value)
	{
		throw new NotImplementedException();
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}
}
