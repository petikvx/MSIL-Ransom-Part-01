using System;
using System.IO;

namespace ns17;

internal class Class81
{
	public static void smethod_0(Stream stream_0)
	{
		stream_0.WriteByte(192);
	}

	public static void smethod_1(Stream stream_0, string string_0)
	{
		byte[] array = GClass15.smethod_0(string_0);
		byte[] array2 = null;
		int num = array.Length;
		byte b = 0;
		if (num <= 31)
		{
			b = (byte)(160 + (byte)num);
			stream_0.WriteByte(b);
		}
		else if (num <= 255)
		{
			b = 217;
			stream_0.WriteByte(217);
			b = (byte)num;
			stream_0.WriteByte(b);
		}
		else if (num <= 65535)
		{
			b = 218;
			stream_0.WriteByte(218);
			array2 = GClass15.smethod_4(BitConverter.GetBytes((short)num));
			stream_0.Write(array2, 0, array2.Length);
		}
		else
		{
			b = 219;
			stream_0.WriteByte(219);
			array2 = GClass15.smethod_4(BitConverter.GetBytes(num));
			stream_0.Write(array2, 0, array2.Length);
		}
		stream_0.Write(array, 0, array.Length);
	}

	public static void smethod_2(Stream stream_0, byte[] byte_0)
	{
		byte[] array = null;
		int num = byte_0.Length;
		byte b = 0;
		if (num <= 255)
		{
			b = 196;
			stream_0.WriteByte(196);
			b = (byte)num;
			stream_0.WriteByte(b);
		}
		else if (num <= 65535)
		{
			b = 197;
			stream_0.WriteByte(197);
			array = GClass15.smethod_4(BitConverter.GetBytes((short)num));
			stream_0.Write(array, 0, array.Length);
		}
		else
		{
			b = 198;
			stream_0.WriteByte(198);
			array = GClass15.smethod_4(BitConverter.GetBytes(num));
			stream_0.Write(array, 0, array.Length);
		}
		stream_0.Write(byte_0, 0, byte_0.Length);
	}

	public static void smethod_3(Stream stream_0, double double_0)
	{
		stream_0.WriteByte(203);
		stream_0.Write(GClass15.smethod_8(double_0), 0, 8);
	}

	public static void smethod_4(Stream stream_0, float float_0)
	{
		stream_0.WriteByte(202);
		stream_0.Write(GClass15.smethod_4(BitConverter.GetBytes(float_0)), 0, 4);
	}

	public static void smethod_5(Stream stream_0, bool bool_0)
	{
		if (bool_0)
		{
			stream_0.WriteByte(195);
		}
		else
		{
			stream_0.WriteByte(194);
		}
	}

	public static void smethod_6(Stream stream_0, ulong ulong_0)
	{
		stream_0.WriteByte(207);
		byte[] bytes = BitConverter.GetBytes(ulong_0);
		stream_0.Write(GClass15.smethod_4(bytes), 0, 8);
	}

	public static void smethod_7(Stream stream_0, long long_0)
	{
		if (long_0 >= 0L)
		{
			if (long_0 <= 127L)
			{
				stream_0.WriteByte((byte)long_0);
			}
			else if (long_0 <= 255L)
			{
				stream_0.WriteByte(204);
				stream_0.WriteByte((byte)long_0);
			}
			else if (long_0 <= 65535L)
			{
				stream_0.WriteByte(205);
				stream_0.Write(GClass15.smethod_7((short)long_0), 0, 2);
			}
			else if (long_0 <= 4294967295L)
			{
				stream_0.WriteByte(206);
				stream_0.Write(GClass15.smethod_6((int)long_0), 0, 4);
			}
			else
			{
				stream_0.WriteByte(211);
				stream_0.Write(GClass15.smethod_5(long_0), 0, 8);
			}
		}
		else if (long_0 <= -2147483648L)
		{
			stream_0.WriteByte(211);
			stream_0.Write(GClass15.smethod_5(long_0), 0, 8);
		}
		else if (long_0 <= -32768L)
		{
			stream_0.WriteByte(210);
			stream_0.Write(GClass15.smethod_6((int)long_0), 0, 4);
		}
		else if (long_0 <= -128L)
		{
			stream_0.WriteByte(209);
			stream_0.Write(GClass15.smethod_7((short)long_0), 0, 2);
		}
		else if (long_0 <= -32L)
		{
			stream_0.WriteByte(208);
			stream_0.WriteByte((byte)long_0);
		}
		else
		{
			stream_0.WriteByte((byte)long_0);
		}
	}
}
