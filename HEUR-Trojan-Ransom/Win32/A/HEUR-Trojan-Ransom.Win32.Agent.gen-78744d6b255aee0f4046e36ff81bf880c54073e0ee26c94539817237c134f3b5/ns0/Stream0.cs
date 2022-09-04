using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Stream0 : Stream
{
	protected Class23 class23_0;

	protected byte[] byte_0;

	protected int int_0;

	private byte[] byte_1 = new byte[1];

	protected Stream stream_0;

	protected byte[] byte_2;

	private uint[] uint_0;

	public override bool CanRead => stream_0.CanRead;

	public override bool CanSeek => stream_0.CanSeek;

	public override bool CanWrite => stream_0.CanWrite;

	public override long Length => int_0;

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

	public Stream0(Stream stream_1)
		: this(stream_1, new Class23(), 4096)
	{
	}

	public Stream0(Stream stream_1, Class23 class23_1)
		: this(stream_1, class23_1, 4096)
	{
	}

	public Stream0(Stream stream_1, Class23 class23_1, int int_1)
	{
		stream_0 = stream_1;
		class23_0 = class23_1;
		try
		{
			int_0 = (int)stream_1.Length;
		}
		catch (Exception)
		{
			int_0 = 0;
		}
		if (int_1 <= 0)
		{
			throw new ArgumentOutOfRangeException(Class33.smethod_0(1571433890, 891739013, 642129742));
		}
		byte_0 = new byte[int_1];
	}

	public override void Flush()
	{
		stream_0.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return stream_0.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		stream_0.SetLength(value);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		stream_0.Write(buffer, offset, count);
	}

	public override void WriteByte(byte value)
	{
		stream_0.WriteByte(value);
	}

	[SpecialName]
	public virtual int vmethod_0()
	{
		if (!class23_0.method_14())
		{
			return 1;
		}
		return 0;
	}

	public override void Close()
	{
		stream_0.Close();
	}

	protected void method_0()
	{
		int_0 = stream_0.Read(byte_0, 0, byte_0.Length);
		if (byte_2 != null)
		{
			method_3(byte_0, 0, byte_0.Length);
		}
		if (int_0 <= 0)
		{
			throw new ApplicationException(Class33.smethod_0(1073997991, 891738881, 642129770));
		}
		class23_0.method_9(byte_0, 0, int_0);
	}

	public override int ReadByte()
	{
		int num = Read(byte_1, 0, 1);
		if (num > 0)
		{
			return byte_1[0] & 0xFF;
		}
		return -1;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		while (true)
		{
			int num;
			try
			{
				num = class23_0.method_11(buffer, offset, count);
			}
			catch (Exception ex)
			{
				throw new Exception0(ex.ToString());
			}
			if (num <= 0)
			{
				if (!class23_0.method_13())
				{
					if (class23_0.method_14())
					{
						break;
					}
					if (class23_0.method_12())
					{
						method_0();
						continue;
					}
					throw new InvalidOperationException(Class33.smethod_0(370011929, 891738935, 642129782));
				}
				throw new Exception0(Class33.smethod_0(1238393955, 891738977, 642129790));
			}
			return num;
		}
		return 0;
	}

	public long method_1(long long_0)
	{
		if (long_0 < 0L)
		{
			throw new ArgumentOutOfRangeException(Class33.smethod_0(624956921, 891739011, 642129758));
		}
		int num = 2048;
		if (long_0 < 2048L)
		{
			num = (int)long_0;
		}
		byte[] array = new byte[num];
		return stream_0.Read(array, 0, array.Length);
	}

	protected byte method_2()
	{
		uint num = (uint_0[2] & 0xFFFFu) | 2u;
		return (byte)(num * (num ^ 1) >> 8);
	}

	protected void method_3(byte[] byte_3, int int_1, int int_2)
	{
		for (int i = int_1; i < int_1 + int_2; i++)
		{
			byte_3[i] ^= method_2();
			method_6(byte_3[i]);
		}
	}

	protected void method_4(string string_0)
	{
		uint_0 = new uint[3] { 305419896u, 591751049u, 878082192u };
		for (int i = 0; i < string_0.Length; i++)
		{
			method_6((byte)string_0[i]);
		}
	}

	private uint method_5(uint uint_1, byte byte_3)
	{
		return Class17.uint_1[(uint_1 ^ byte_3) & 0xFF] ^ (uint_1 >> 8);
	}

	protected void method_6(byte byte_3)
	{
		uint_0[0] = method_5(uint_0[0], byte_3);
		uint_0[1] = uint_0[1] + (byte)uint_0[0];
		uint_0[1] = uint_0[1] * 134775813 + 1;
		uint_0[2] = method_5(uint_0[2], (byte)(uint_0[1] >> 24));
	}
}
