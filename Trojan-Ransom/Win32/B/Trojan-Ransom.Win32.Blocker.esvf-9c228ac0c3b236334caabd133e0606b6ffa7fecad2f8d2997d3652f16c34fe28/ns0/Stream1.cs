using System;
using System.IO;

namespace ns0;

internal class Stream1 : Stream
{
	private static Class4 class4_0 = new Class4();

	protected byte[] byte_0;

	protected Class20 class20_0;

	protected Stream stream_0;

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
				return stream_0.Length;
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

	public Stream1(Stream stream_1)
		: this(stream_1, new Class20(), 512)
	{
	}

	public Stream1(Stream stream_1, Class20 class20_1)
		: this(stream_1, class20_1, 512)
	{
	}

	public Stream1(Stream stream_1, Class20 class20_1, int int_0)
	{
		stream_0 = stream_1;
		if (int_0 <= 0)
		{
			throw new InvalidOperationException(Class42.smethod_0(948922996, 66189692, 277613027));
		}
		byte_0 = new byte[int_0];
		class20_0 = class20_1;
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

	public override int ReadByte()
	{
		try
		{
			return stream_0.ReadByte();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		try
		{
			return stream_0.Read(buffer, offset, count);
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, buffer, offset, count);
			throw;
		}
	}

	protected void method_0()
	{
		int num = default(int);
		try
		{
			while (!class20_0.method_7())
			{
				num = class20_0.method_13(byte_0, 0, byte_0.Length);
				if (num <= 0)
				{
					break;
				}
				stream_0.Write(byte_0, 0, num);
			}
			if (!class20_0.method_7())
			{
				throw new ApplicationException(Class42.smethod_0(732515954, 66189596, 277613003));
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, num);
			throw;
		}
	}

	public override void Flush()
	{
		try
		{
			class20_0.method_4();
			method_0();
			stream_0.Flush();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public virtual void vmethod_0()
	{
		int num = default(int);
		try
		{
			class20_0.method_5();
			while (!class20_0.method_6())
			{
				num = class20_0.method_13(byte_0, 0, byte_0.Length);
				if (num <= 0)
				{
					break;
				}
				stream_0.Write(byte_0, 0, num);
			}
			if (!class20_0.method_6())
			{
				throw new ApplicationException(Class42.smethod_0(157045553, 66189612, 277613003));
			}
			stream_0.Flush();
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, num);
			throw;
		}
	}

	public override void Close()
	{
		try
		{
			vmethod_0();
			stream_0.Close();
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public override void WriteByte(byte value)
	{
		byte[] array = default(byte[]);
		try
		{
			array = new byte[1] { value };
			Write(array, 0, 1);
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, value, array);
			throw;
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		try
		{
			class20_0.method_9(buffer, offset, count);
			method_0();
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, buffer, offset, count);
			throw;
		}
	}
}
