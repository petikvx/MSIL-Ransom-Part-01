using System;
using System.IO;
using rgA69G;

internal class yzFt9ajfw_bjeqibcttmudgpwhnitxqxhqoqxnx
{
	public static void PsYjkc_a(Stream a)
	{
		a.WriteByte(192);
	}

	public static void PsYjkc_b(Stream a, string b)
	{
		byte[] array = V7qSaHaL8shx.i0SpamIY(b);
		byte[] array2 = null;
		int num = array.Length;
		byte b2 = 0;
		if (num <= 31)
		{
			b2 = (byte)(160 + (byte)num);
			a.WriteByte(b2);
		}
		else if (num <= 255)
		{
			b2 = 217;
			a.WriteByte(217);
			b2 = (byte)num;
			a.WriteByte(b2);
		}
		else if (num <= 65535)
		{
			b2 = 218;
			a.WriteByte(218);
			array2 = V7qSaHaL8shx.aduO6vFYO(BitConverter.GetBytes((short)num));
			a.Write(array2, 0, array2.Length);
		}
		else
		{
			b2 = 219;
			a.WriteByte(219);
			array2 = V7qSaHaL8shx.aduO6vFYO(BitConverter.GetBytes(num));
			a.Write(array2, 0, array2.Length);
		}
		a.Write(array, 0, array.Length);
	}

	public static void PsYjkc_c(Stream a, byte[] b)
	{
		byte[] array = null;
		int num = b.Length;
		byte b2 = 0;
		if (num <= 255)
		{
			b2 = 196;
			a.WriteByte(196);
			b2 = (byte)num;
			a.WriteByte(b2);
		}
		else if (num <= 65535)
		{
			b2 = 197;
			a.WriteByte(197);
			array = V7qSaHaL8shx.aduO6vFYO(BitConverter.GetBytes((short)num));
			a.Write(array, 0, array.Length);
		}
		else
		{
			b2 = 198;
			a.WriteByte(198);
			array = V7qSaHaL8shx.aduO6vFYO(BitConverter.GetBytes(num));
			a.Write(array, 0, array.Length);
		}
		a.Write(b, 0, b.Length);
	}

	public static void PsYjkc_d(Stream a, double b)
	{
		a.WriteByte(203);
		a.Write(V7qSaHaL8shx.oub8W5ZTF(b), 0, 8);
	}

	public static void PsYjkc_e(Stream a, float b)
	{
		a.WriteByte(202);
		a.Write(V7qSaHaL8shx.aduO6vFYO(BitConverter.GetBytes(b)), 0, 4);
	}

	public static void PsYjkc_f(Stream a, bool b)
	{
		if (b)
		{
			a.WriteByte(195);
		}
		else
		{
			a.WriteByte(194);
		}
	}

	public static void PsYjkc_g(Stream a, ulong b)
	{
		a.WriteByte(207);
		byte[] bytes = BitConverter.GetBytes(b);
		a.Write(V7qSaHaL8shx.aduO6vFYO(bytes), 0, 8);
	}

	public static void PsYjkc_h(Stream a, long b)
	{
		if (b >= 0L)
		{
			if (b <= 127L)
			{
				a.WriteByte((byte)b);
			}
			else if (b <= 255L)
			{
				a.WriteByte(204);
				a.WriteByte((byte)b);
			}
			else if (b <= 65535L)
			{
				a.WriteByte(205);
				a.Write(V7qSaHaL8shx.smethod_1((short)b), 0, 2);
			}
			else if (b <= 4294967295L)
			{
				a.WriteByte(206);
				a.Write(V7qSaHaL8shx.i6eFie7rpEHjcN((int)b), 0, 4);
			}
			else
			{
				a.WriteByte(211);
				a.Write(V7qSaHaL8shx.c3gDb9bFbkFWZe(b), 0, 8);
			}
		}
		else if (b <= -2147483648L)
		{
			a.WriteByte(211);
			a.Write(V7qSaHaL8shx.c3gDb9bFbkFWZe(b), 0, 8);
		}
		else if (b <= -32768L)
		{
			a.WriteByte(210);
			a.Write(V7qSaHaL8shx.i6eFie7rpEHjcN((int)b), 0, 4);
		}
		else if (b <= -128L)
		{
			a.WriteByte(209);
			a.Write(V7qSaHaL8shx.smethod_1((short)b), 0, 2);
		}
		else if (b <= -32L)
		{
			a.WriteByte(208);
			a.WriteByte((byte)b);
		}
		else
		{
			a.WriteByte((byte)b);
		}
	}
}
