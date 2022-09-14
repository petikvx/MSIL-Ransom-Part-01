using System;
using System.IO;
using ns0;
using ns13;
using ns5;

namespace ns1;

internal sealed class Stream5 : Stream
{
	private Class21 class21_0;

	private Stream stream_0;

	private Enum5 enum5_0;

	bool Stream.CanRead => enum5_0 == Enum5.const_1;

	bool Stream.CanSeek => false;

	bool Stream.CanWrite => enum5_0 == Enum5.const_0;

	long Stream.Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	long Stream.Position
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public Stream5(Stream stream_1, Class21 class21_1, Enum5 enum5_1)
	{
		class21_0 = class21_1;
		stream_0 = stream_1;
		enum5_0 = enum5_1;
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		if (enum5_0 == Enum5.const_0)
		{
			throw new NotSupportedException("This stream does not encrypt via Read()");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		byte[] array = new byte[count];
		int num = stream_0.Read(array, 0, count);
		byte[] array2 = Class6.smethod_505(array, num, class21_0);
		for (int i = 0; i < num; i++)
		{
			buffer[offset + i] = array2[i];
		}
		return num;
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		if (enum5_0 == Enum5.const_1)
		{
			throw new NotSupportedException("This stream does not Decrypt via Write()");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (count == 0)
		{
			return;
		}
		byte[] array = null;
		if (offset != 0)
		{
			array = new byte[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = buffer[offset + i];
			}
		}
		else
		{
			array = buffer;
		}
		byte[] array2 = Class6.smethod_300(class21_0, array, count);
		stream_0.Write(array2, 0, array2.Length);
	}

	void Stream.Flush()
	{
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	void Stream.SetLength(long value)
	{
		throw new NotSupportedException();
	}
}
