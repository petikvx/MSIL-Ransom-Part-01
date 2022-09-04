using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Stream0 : Stream
{
	protected Class33 class33_0;

	protected byte[] byte_0;

	protected int int_0;

	private byte[] byte_1 = new byte[1];

	protected Stream stream_0;

	protected byte[] byte_2;

	private uint[] uint_0;

	public override bool CanRead
	{
		get
		{
			try
			{
				return stream_0.CanRead;
			}
			catch (Exception exception_)
			{
				Class14.smethod_22(exception_, this);
				throw;
			}
		}
	}

	public override bool CanSeek
	{
		get
		{
			try
			{
				return stream_0.CanSeek;
			}
			catch (Exception exception_)
			{
				Class14.smethod_22(exception_, this);
				throw;
			}
		}
	}

	public override bool CanWrite
	{
		get
		{
			try
			{
				return stream_0.CanWrite;
			}
			catch (Exception exception_)
			{
				Class14.smethod_22(exception_, this);
				throw;
			}
		}
	}

	public override long Length
	{
		get
		{
			try
			{
				return int_0;
			}
			catch (Exception exception_)
			{
				Class14.smethod_22(exception_, this);
				throw;
			}
		}
	}

	public override long Position
	{
		get
		{
			try
			{
				return stream_0.Position;
			}
			catch (Exception exception_)
			{
				Class14.smethod_22(exception_, this);
				throw;
			}
		}
		set
		{
			try
			{
				stream_0.Position = value;
			}
			catch (Exception exception_)
			{
				Class14.smethod_23(exception_, this, value);
				throw;
			}
		}
	}

	public Stream0(Stream stream_1)
		: this(stream_1, new Class33(), 4096)
	{
	}

	public Stream0(Stream stream_1, Class33 class33_1)
		: this(stream_1, class33_1, 4096)
	{
	}

	public Stream0(Stream stream_1, Class33 class33_1, int int_1)
	{
		stream_0 = stream_1;
		class33_0 = class33_1;
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
			throw new ArgumentOutOfRangeException(Class43.smethod_0(1687732995, 2095934937, 886135659));
		}
		byte_0 = new byte[int_1];
	}

	public override void Flush()
	{
		try
		{
			stream_0.Flush();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		try
		{
			return stream_0.Seek(offset, origin);
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, offset, origin);
			throw;
		}
	}

	public override void SetLength(long value)
	{
		try
		{
			stream_0.SetLength(value);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, value);
			throw;
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		try
		{
			stream_0.Write(buffer, offset, count);
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, buffer, offset, count);
			throw;
		}
	}

	public override void WriteByte(byte value)
	{
		try
		{
			stream_0.WriteByte(value);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, value);
			throw;
		}
	}

	[SpecialName]
	public virtual int vmethod_0()
	{
		try
		{
			if (!class33_0.method_14())
			{
				return 1;
			}
			return 0;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public override void Close()
	{
		try
		{
			stream_0.Close();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	protected void method_0()
	{
		try
		{
			int_0 = stream_0.Read(byte_0, 0, byte_0.Length);
			if (byte_2 != null)
			{
				method_3(byte_0, 0, byte_0.Length);
			}
			if (int_0 <= 0)
			{
				throw new ApplicationException(Class43.smethod_0(1683941778, 2095934813, 886135631));
			}
			class33_0.method_9(byte_0, 0, int_0);
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public override int ReadByte()
	{
		int num = default(int);
		try
		{
			num = Read(byte_1, 0, 1);
			if (num > 0)
			{
				return byte_1[0] & 0xFF;
			}
			return -1;
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, num);
			throw;
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num = default(int);
		Exception ex2 = default(Exception);
		try
		{
			while (true)
			{
				try
				{
					num = class33_0.method_11(buffer, offset, count);
				}
				catch (Exception ex)
				{
					ex2 = ex;
					throw new Exception0(ex2.ToString());
				}
				if (num <= 0)
				{
					if (!class33_0.method_13())
					{
						if (class33_0.method_14())
						{
							break;
						}
						if (class33_0.method_12())
						{
							method_0();
							continue;
						}
						throw new InvalidOperationException(Class43.smethod_0(804061169, 2095934827, 886135635));
					}
					throw new Exception0(Class43.smethod_0(1298952761, 2095934781, 886135643));
				}
				return num;
			}
			return 0;
		}
		catch (Exception exception_)
		{
			Class14.smethod_27(exception_, this, buffer, offset, count, num, ex2);
			throw;
		}
	}

	public long method_1(long long_0)
	{
		int num = default(int);
		byte[] array = default(byte[]);
		try
		{
			if (long_0 < 0)
			{
				throw new ArgumentOutOfRangeException(Class43.smethod_0(384345092, 2095934943, 886135675));
			}
			num = 2048;
			if (long_0 < num)
			{
				num = (int)long_0;
			}
			array = new byte[num];
			return stream_0.Read(array, 0, array.Length);
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, long_0, num, array);
			throw;
		}
	}

	protected byte method_2()
	{
		uint num = default(uint);
		try
		{
			num = (uint_0[2] & 0xFFFFu) | 2u;
			return (byte)(num * (num ^ 1) >> 8);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, num);
			throw;
		}
	}

	protected void method_3(byte[] byte_3, int int_1, int int_2)
	{
		int i = default(int);
		try
		{
			for (i = int_1; i < int_1 + int_2; i++)
			{
				byte_3[i] ^= method_2();
				method_6(byte_3[i]);
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_26(exception_, this, byte_3, int_1, int_2, i);
			throw;
		}
	}

	protected void method_4(string string_0)
	{
		int i = default(int);
		try
		{
			uint_0 = new uint[3] { 305419896u, 591751049u, 878082192u };
			for (i = 0; i < string_0.Length; i++)
			{
				method_6((byte)string_0[i]);
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, string_0, i);
			throw;
		}
	}

	private uint method_5(uint uint_1, byte byte_3)
	{
		try
		{
			return Class27.uint_1[(uint_1 ^ byte_3) & 0xFF] ^ (uint_1 >> 8);
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, uint_1, byte_3);
			throw;
		}
	}

	protected void method_6(byte byte_3)
	{
		try
		{
			uint_0[0] = method_5(uint_0[0], byte_3);
			uint_0[1] = uint_0[1] + (byte)uint_0[0];
			uint_0[1] = uint_0[1] * 134775813 + 1;
			uint_0[2] = method_5(uint_0[2], (byte)(uint_0[1] >> 24));
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, byte_3);
			throw;
		}
	}
}
