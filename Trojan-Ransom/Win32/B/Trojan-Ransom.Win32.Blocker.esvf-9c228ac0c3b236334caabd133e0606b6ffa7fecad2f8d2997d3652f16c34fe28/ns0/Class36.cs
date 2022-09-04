using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Class36
{
	protected byte[] byte_0;

	private int int_0;

	private int int_1;

	private uint uint_0;

	private int int_2;

	public Class36()
		: this(4096)
	{
	}

	public Class36(int int_3)
	{
		byte_0 = new byte[int_3];
	}

	public void method_0()
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = (int_2 = 0);
			num2 = (int_0 = (int_1 = num));
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, num, num2);
			throw;
		}
	}

	public void method_1(int int_3)
	{
		int num = default(int);
		try
		{
			byte[] array = byte_0;
			num = int_1++;
			array[num] = (byte)int_3;
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, int_3, num);
			throw;
		}
	}

	public void method_2(int int_3)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			byte[] array = byte_0;
			num = int_1++;
			array[num] = (byte)int_3;
			byte[] array2 = byte_0;
			num2 = int_1++;
			array2[num2] = (byte)(int_3 >> 8);
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, int_3, num, num2);
			throw;
		}
	}

	public void method_3(int int_3)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		try
		{
			byte[] array = byte_0;
			num = int_1++;
			array[num] = (byte)int_3;
			byte[] array2 = byte_0;
			num2 = int_1++;
			array2[num2] = (byte)(int_3 >> 8);
			byte[] array3 = byte_0;
			num3 = int_1++;
			array3[num3] = (byte)(int_3 >> 16);
			byte[] array4 = byte_0;
			num4 = int_1++;
			array4[num4] = (byte)(int_3 >> 24);
		}
		catch (Exception exception_)
		{
			Class14.smethod_27(exception_, this, int_3, num, num2, num3, num4);
			throw;
		}
	}

	public void method_4(byte[] byte_1, int int_3, int int_4)
	{
		try
		{
			Array.Copy(byte_1, int_3, byte_0, int_1, int_4);
			int_1 += int_4;
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, byte_1, int_3, int_4);
			throw;
		}
	}

	[SpecialName]
	public int method_5()
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

	public void method_6()
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			if (int_2 > 0)
			{
				byte[] array = byte_0;
				num = int_1++;
				array[num] = (byte)uint_0;
				if (int_2 > 8)
				{
					byte[] array2 = byte_0;
					num2 = int_1++;
					array2[num2] = (byte)(uint_0 >> 8);
				}
			}
			uint_0 = 0u;
			int_2 = 0;
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, this, num, num2);
			throw;
		}
	}

	public void method_7(int int_3, int int_4)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			uint_0 |= (uint)(int_3 << int_2);
			int_2 += int_4;
			if (int_2 >= 16)
			{
				byte[] array = byte_0;
				num = int_1++;
				array[num] = (byte)uint_0;
				byte[] array2 = byte_0;
				num2 = int_1++;
				array2[num2] = (byte)(uint_0 >> 8);
				uint_0 >>= 16;
				int_2 -= 16;
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_26(exception_, this, int_3, int_4, num, num2);
			throw;
		}
	}

	public void method_8(int int_3)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			byte[] array = byte_0;
			num = int_1++;
			array[num] = (byte)(int_3 >> 8);
			byte[] array2 = byte_0;
			num2 = int_1++;
			array2[num2] = (byte)int_3;
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, int_3, num, num2);
			throw;
		}
	}

	[SpecialName]
	public bool method_9()
	{
		try
		{
			return int_1 == 0;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public int method_10(byte[] byte_1, int int_3, int int_4)
	{
		int num = default(int);
		try
		{
			if (int_2 >= 8)
			{
				byte[] array = byte_0;
				num = int_1++;
				array[num] = (byte)uint_0;
				uint_0 >>= 8;
				int_2 -= 8;
			}
			if (int_4 > int_1 - int_0)
			{
				int_4 = int_1 - int_0;
				Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
				int_0 = 0;
				int_1 = 0;
			}
			else
			{
				Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
				int_0 += int_4;
			}
			return int_4;
		}
		catch (Exception exception_)
		{
			Class14.smethod_26(exception_, this, byte_1, int_3, int_4, num);
			throw;
		}
	}

	public byte[] method_11()
	{
		byte[] array = default(byte[]);
		try
		{
			array = new byte[int_1 - int_0];
			Array.Copy(byte_0, int_0, array, 0, array.Length);
			int_0 = 0;
			int_1 = 0;
			return array;
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, array);
			throw;
		}
	}
}
