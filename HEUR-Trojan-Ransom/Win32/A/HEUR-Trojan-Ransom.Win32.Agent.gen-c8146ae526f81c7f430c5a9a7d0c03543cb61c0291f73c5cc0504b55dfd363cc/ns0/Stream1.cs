using System;
using System.IO;

namespace ns0;

internal class Stream1 : Stream
{
	private static Class3 class3_0 = new Class3();

	protected byte[] byte_0;

	protected Class12 class12_0;

	protected Stream stream_0;

	public override bool CanRead => stream_0.CanRead;

	public override bool CanSeek => stream_0.CanSeek;

	public override bool CanWrite => stream_0.CanWrite;

	public override long Length => stream_0.Length;

	public override long Position
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

	public Stream1(Stream stream_1)
		: this(stream_1, new Class12(), 512)
	{
	}

	public Stream1(Stream stream_1, Class12 class12_1)
		: this(stream_1, class12_1, 512)
	{
	}

	public Stream1(Stream stream_1, Class12 class12_1, int int_0)
	{
		stream_0 = stream_1;
		if (int_0 <= 0)
		{
			throw new InvalidOperationException(Class32.smethod_0(613720115, 1665377855, 1780518820));
		}
		byte_0 = new byte[int_0];
		class12_0 = class12_1;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return stream_0.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		stream_0.SetLength(value);
	}

	public override int ReadByte()
	{
		return stream_0.ReadByte();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return stream_0.Read(buffer, offset, count);
	}

	protected void method_0()
	{
		while (!class12_0.method_7())
		{
			int num = class12_0.method_13(byte_0, 0, byte_0.Length);
			if (num <= 0)
			{
				break;
			}
			stream_0.Write(byte_0, 0, num);
		}
		if (!class12_0.method_7())
		{
			throw new ApplicationException(Class32.smethod_0(482718266, 1665377887, 1780518796));
		}
	}

	public override void Flush()
	{
		class12_0.method_4();
		method_0();
		stream_0.Flush();
	}

	public virtual void vmethod_0()
	{
		class12_0.method_5();
		while (!class12_0.method_6())
		{
			int num = class12_0.method_13(byte_0, 0, byte_0.Length);
			if (num <= 0)
			{
				break;
			}
			stream_0.Write(byte_0, 0, num);
		}
		if (!class12_0.method_6())
		{
			throw new ApplicationException(Class32.smethod_0(1431405723, 1665377903, 1780518796));
		}
		stream_0.Flush();
	}

	public override void Close()
	{
		vmethod_0();
		stream_0.Close();
	}

	public override void WriteByte(byte value)
	{
		Write(new byte[1] { value }, 0, 1);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		class12_0.method_9(buffer, offset, count);
		method_0();
	}
}
