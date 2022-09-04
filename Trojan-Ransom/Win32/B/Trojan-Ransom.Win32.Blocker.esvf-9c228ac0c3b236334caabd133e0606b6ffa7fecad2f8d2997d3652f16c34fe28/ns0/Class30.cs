using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Class30
{
	private byte[] byte_0;

	private int int_0;

	private int int_1;

	private uint uint_0;

	private int int_2;

	public int method_0(int int_3)
	{
		int num2 = default(int);
		int num4 = default(int);
		try
		{
			if (int_2 < int_3)
			{
				if (int_0 == int_1)
				{
					return -1;
				}
				uint num = uint_0;
				byte[] array = byte_0;
				num2 = int_0++;
				int num3 = array[num2] & 0xFF;
				byte[] array2 = byte_0;
				num4 = int_0++;
				uint_0 = num | (uint)((num3 | ((array2[num4] & 0xFF) << 8)) << int_2);
				int_2 += 16;
			}
			return (int)(uint_0 & ((1 << int_3) - 1));
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, int_3, num2, num4);
			throw;
		}
	}

	public void method_1(int int_3)
	{
		try
		{
			uint_0 >>= int_3;
			int_2 -= int_3;
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, int_3);
			throw;
		}
	}

	public int method_2(int int_3)
	{
		int num = default(int);
		try
		{
			num = method_0(int_3);
			if (num >= 0)
			{
				method_1(int_3);
			}
			return num;
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, int_3, num);
			throw;
		}
	}

	[SpecialName]
	public int method_3()
	{
		try
		{
			return int_2;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public int method_4()
	{
		try
		{
			return int_1 - int_0 + (int_2 >> 3);
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public void method_5()
	{
		try
		{
			uint_0 >>= int_2 & 7;
			int_2 &= -8;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	[SpecialName]
	public bool method_6()
	{
		try
		{
			return int_0 == int_1;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public int method_7(byte[] byte_1, int int_3, int int_4)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			if (int_4 < 0)
			{
				throw new ArgumentOutOfRangeException(Class45.smethod_0(1409467902, 134317981, 181823451));
			}
			if (((uint)int_2 & 7u) != 0)
			{
				throw new InvalidOperationException(Class45.smethod_0(285499912, 134317993, 181823473));
			}
			num = 0;
			while (int_2 > 0 && int_4 > 0)
			{
				byte_1[int_3++] = (byte)uint_0;
				uint_0 >>= 8;
				int_2 -= 8;
				int_4--;
				num++;
			}
			if (int_4 == 0)
			{
				return num;
			}
			num2 = int_1 - int_0;
			if (int_4 > num2)
			{
				int_4 = num2;
			}
			Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
			int_0 += int_4;
			if (((uint)(int_0 - int_1) & (true ? 1u : 0u)) != 0)
			{
				byte[] array = byte_0;
				num3 = int_0++;
				uint_0 = array[num3] & 0xFFu;
				int_2 = 8;
			}
			return num + int_4;
		}
		catch (Exception exception_)
		{
			Class14.smethod_28(exception_, this, byte_1, int_3, int_4, num, num2, num3);
			throw;
		}
	}

	public void method_8()
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num = (int_2 = 0);
			num2 = (int_1 = num);
			num3 = (int)(uint_0 = (uint)(int_0 = num2));
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, num, num2, num3);
			throw;
		}
	}

	public void method_9(byte[] byte_1, int int_3, int int_4)
	{
		int num = default(int);
		try
		{
			if (int_0 < int_1)
			{
				throw new InvalidOperationException(Class45.smethod_0(825247194, 134318075, 181823369));
			}
			num = int_3 + int_4;
			if (0 <= int_3 && int_3 <= num && num <= byte_1.Length)
			{
				if (((uint)int_4 & (true ? 1u : 0u)) != 0)
				{
					uint_0 |= (uint)((byte_1[int_3++] & 0xFF) << int_2);
					int_2 += 8;
				}
				byte_0 = byte_1;
				int_0 = int_3;
				int_1 = num;
				return;
			}
			throw new ArgumentOutOfRangeException();
		}
		catch (Exception exception_)
		{
			Class14.smethod_26(exception_, this, byte_1, int_3, int_4, num);
			throw;
		}
	}
}
