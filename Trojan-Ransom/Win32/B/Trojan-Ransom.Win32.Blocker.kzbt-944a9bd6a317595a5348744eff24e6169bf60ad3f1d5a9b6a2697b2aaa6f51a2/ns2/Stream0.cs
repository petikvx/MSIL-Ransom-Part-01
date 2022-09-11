using System;
using System.IO;
using ns3;
using ns4;

namespace ns2;

internal class Stream0 : Stream
{
	protected internal Class12 class12_0;

	protected internal byte[] byte_0;

	protected internal int int_0;

	private byte[] byte_1 = new byte[1];

	protected internal Stream stream_0;

	protected internal byte[] byte_2 = null;

	internal uint[] uint_0 = null;

	bool Stream.CanRead => stream_0.CanRead;

	bool Stream.CanSeek => stream_0.CanSeek;

	bool Stream.CanWrite => stream_0.CanWrite;

	long Stream.Length => int_0;

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
		stream_0.SetLength(value);
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		stream_0.Write(buffer, offset, count);
	}

	void Stream.WriteByte(byte value)
	{
		stream_0.WriteByte(value);
	}

	public Stream0(Stream stream_1)
		: this(stream_1, new Class12(), 4096)
	{
	}

	public Stream0(Stream stream_1, Class12 class12_1, int int_1)
	{
		stream_0 = stream_1;
		class12_0 = class12_1;
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
			throw new ArgumentOutOfRangeException("size <= 0");
		}
		byte_0 = new byte[checked((uint)int_1)];
	}

	void Stream.Close()
	{
		stream_0.Close();
	}

	int Stream.ReadByte()
	{
		int num = Read(byte_1, 0, 1);
		if (num > 0)
		{
			return byte_1[0] & 0xFF;
		}
		return -1;
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		while (true)
		{
			int num;
			try
			{
				num = Class33.smethod_108(class12_0, buffer, offset, count);
			}
			catch (Exception ex)
			{
				throw new Exception0(ex.ToString());
			}
			if (num <= 0)
			{
				if (!Class33.smethod_111(class12_0))
				{
					if (!Class33.smethod_93(class12_0))
					{
						if (!Class33.smethod_95(class12_0))
						{
							break;
						}
						Class33.smethod_107(this);
						continue;
					}
					return 0;
				}
				throw new Exception0("Need a dictionary");
			}
			return num;
		}
		throw new InvalidOperationException("Don't know what to do");
	}
}
