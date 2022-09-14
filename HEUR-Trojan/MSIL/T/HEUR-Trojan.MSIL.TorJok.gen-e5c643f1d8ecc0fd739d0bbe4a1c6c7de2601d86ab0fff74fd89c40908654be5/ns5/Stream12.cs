using System;
using System.IO;
using ns0;
using ns1;
using ns10;
using ns11;
using ns15;
using ns3;
using ns8;
using ns9;

namespace ns5;

internal sealed class Stream12 : Stream
{
	internal enum Enum24
	{
		const_0,
		const_1,
		const_2
	}

	protected internal GClass2 gclass2_0;

	protected internal Enum24 enum24_0 = Enum24.const_2;

	protected internal Enum19 enum19_0;

	protected internal Enum23 enum23_0;

	protected internal Enum22 enum22_0;

	protected internal Enum20 enum20_0;

	protected internal bool bool_0;

	protected internal byte[] byte_0;

	protected internal int int_0 = 16384;

	protected internal byte[] byte_1 = new byte[1];

	protected internal Stream stream_0;

	protected internal Enum21 enum21_0;

	internal GClass3 gclass3_0;

	protected internal string string_0;

	protected internal string string_1;

	protected internal DateTime dateTime_0;

	protected internal int int_1;

	private bool bool_1;

	bool Stream.CanRead => stream_0.CanRead;

	bool Stream.CanSeek => stream_0.CanSeek;

	bool Stream.CanWrite => stream_0.CanWrite;

	long Stream.Length => stream_0.Length;

	long Stream.Position
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public Stream12(Stream stream_1, Enum22 enum22_1, Enum20 enum20_1, Enum23 enum23_1, bool bool_2)
	{
		enum19_0 = Enum19.const_0;
		stream_0 = stream_1;
		bool_0 = bool_2;
		enum22_0 = enum22_1;
		enum23_0 = enum23_1;
		enum20_0 = enum20_1;
		if (enum23_1 == Enum23.const_2)
		{
			gclass3_0 = new GClass3();
		}
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		if (gclass3_0 != null)
		{
			Class6.smethod_23(gclass3_0, buffer, offset, count);
		}
		if (enum24_0 == Enum24.const_2)
		{
			enum24_0 = Enum24.const_0;
		}
		else if (enum24_0 != 0)
		{
			throw new GException0("Cannot Write after Reading.");
		}
		if (count == 0)
		{
			return;
		}
		Class6.smethod_209(this).byte_0 = buffer;
		gclass2_0.int_0 = offset;
		gclass2_0.int_1 = count;
		bool flag = false;
		while (true)
		{
			gclass2_0.byte_1 = Class6.smethod_544(this);
			gclass2_0.int_2 = 0;
			gclass2_0.int_3 = byte_0.Length;
			int num;
			if (enum22_0 == Enum22.const_0)
			{
				num = Class6.smethod_486(gclass2_0, enum19_0);
			}
			else
			{
				GClass2 gClass = gclass2_0;
				Enum19 @enum = enum19_0;
				num = Class6.smethod_390(@enum, gClass);
			}
			int num2 = num;
			if (num2 != 0 && num2 != 1)
			{
				break;
			}
			stream_0.Write(byte_0, 0, byte_0.Length - gclass2_0.int_3);
			flag = gclass2_0.int_1 == 0 && gclass2_0.int_3 != 0;
			if (enum23_0 == Enum23.const_2 && enum22_0 != 0)
			{
				flag = gclass2_0.int_1 == 8 && gclass2_0.int_3 != 0;
			}
			if (flag)
			{
				return;
			}
		}
		throw new GException0(((enum22_0 == Enum22.const_0) ? "de" : "in") + "flating: " + gclass2_0.string_0);
	}

	void Stream.Close()
	{
		if (stream_0 == null)
		{
			return;
		}
		try
		{
			Class6.smethod_368(this);
		}
		finally
		{
			Class6.smethod_492(this);
			if (!bool_0)
			{
				stream_0.Close();
			}
			stream_0 = null;
		}
	}

	void Stream.Flush()
	{
		stream_0.Flush();
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		throw new NotImplementedException();
	}

	void Stream.SetLength(long value)
	{
		stream_0.SetLength(value);
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		if (enum24_0 == Enum24.const_2)
		{
			if (!stream_0.CanRead)
			{
				throw new GException0("The stream is not readable.");
			}
			enum24_0 = Enum24.const_1;
			Class6.smethod_209(this).int_1 = 0;
			if (enum23_0 == Enum23.const_2)
			{
				int_1 = Class6.smethod_216(this);
				if (int_1 == 0)
				{
					return 0;
				}
			}
		}
		if (enum24_0 != Enum24.const_1)
		{
			throw new GException0("Cannot Read after Writing.");
		}
		if (count == 0)
		{
			return 0;
		}
		if (bool_1 && enum22_0 == Enum22.const_0)
		{
			return 0;
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (offset < buffer.GetLowerBound(0))
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (offset + count > buffer.GetLength(0))
		{
			throw new ArgumentOutOfRangeException("count");
		}
		int num = 0;
		gclass2_0.byte_1 = buffer;
		gclass2_0.int_2 = offset;
		gclass2_0.int_3 = count;
		gclass2_0.byte_0 = Class6.smethod_544(this);
		do
		{
			if (gclass2_0.int_1 == 0 && !bool_1)
			{
				gclass2_0.int_0 = 0;
				gclass2_0.int_1 = stream_0.Read(byte_0, 0, byte_0.Length);
				if (gclass2_0.int_1 == 0)
				{
					bool_1 = true;
				}
			}
			int num2;
			if (enum22_0 != 0)
			{
				GClass2 gClass = gclass2_0;
				Enum19 @enum = enum19_0;
				num2 = Class6.smethod_390(@enum, gClass);
			}
			else
			{
				num2 = Class6.smethod_486(gclass2_0, enum19_0);
			}
			num = num2;
			if (!bool_1 || num != -5)
			{
				if (num != 0 && num != 1)
				{
					throw new GException0(string.Format("{0}flating:  rc={1}  msg={2}", (enum22_0 == Enum22.const_0) ? "de" : "in", num, gclass2_0.string_0));
				}
				continue;
			}
			return 0;
		}
		while (((!bool_1 && num != 1) || gclass2_0.int_3 != count) && gclass2_0.int_3 > 0 && !bool_1 && num == 0);
		if (gclass2_0.int_3 > 0)
		{
			if (num != 0)
			{
			}
			if (bool_1 && enum22_0 == Enum22.const_0)
			{
				num = Class6.smethod_486(gclass2_0, Enum19.const_4);
				if (num != 0 && num != 1)
				{
					throw new GException0($"Deflating:  rc={num}  msg={gclass2_0.string_0}");
				}
			}
		}
		num = count - gclass2_0.int_3;
		if (gclass3_0 != null)
		{
			Class6.smethod_23(gclass3_0, buffer, offset, num);
		}
		return num;
	}
}
