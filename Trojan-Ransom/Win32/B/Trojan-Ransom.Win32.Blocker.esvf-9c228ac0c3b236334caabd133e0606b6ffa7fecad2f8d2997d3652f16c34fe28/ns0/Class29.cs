using System;

namespace ns0;

internal class Class29
{
	private static int int_0 = 32768;

	private static int int_1 = int_0 - 1;

	private byte[] byte_0 = new byte[int_0];

	private int int_2;

	private int int_3;

	public void method_0(int int_4)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = int_3++;
			if (num == int_0)
			{
				throw new InvalidOperationException(Class44.smethod_0(477559955, 749665583, 11002600));
			}
			byte[] array = byte_0;
			num2 = int_2++;
			array[num2] = (byte)int_4;
			int_2 &= int_1;
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, int_4, num, num2);
			throw;
		}
	}

	private void method_1(int int_4, int int_5, int int_6)
	{
		int num = default(int);
		try
		{
			while (int_5-- > 0)
			{
				byte[] array = byte_0;
				num = int_2++;
				array[num] = byte_0[int_4++];
				int_2 &= int_1;
				int_4 &= int_1;
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_26(exception_, this, int_4, int_5, int_6, num);
			throw;
		}
	}

	public void method_2(int int_4, int int_5)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		try
		{
			num = (int_3 += int_4);
			if (num > int_0)
			{
				throw new InvalidOperationException(Class44.smethod_0(2104731254, 749665593, 11002600));
			}
			num2 = (int_2 - int_5) & int_1;
			num3 = int_0 - int_4;
			if (num2 <= num3 && int_2 < num3)
			{
				if (int_4 <= int_5)
				{
					Array.Copy(byte_0, num2, byte_0, int_2, int_4);
					int_2 += int_4;
					return;
				}
				while (int_4-- > 0)
				{
					byte[] array = byte_0;
					num4 = int_2++;
					array[num4] = byte_0[num2++];
				}
			}
			else
			{
				method_1(num2, int_4, int_5);
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_28(exception_, this, int_4, int_5, num2, num3, num, num4);
			throw;
		}
	}

	public int method_3(Class30 class30_0, int int_4)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			int_4 = Math.Min(Math.Min(int_4, int_0 - int_3), class30_0.method_4());
			num = int_0 - int_2;
			if (int_4 > num)
			{
				num2 = class30_0.method_7(byte_0, int_2, num);
				if (num2 == num)
				{
					num2 += class30_0.method_7(byte_0, 0, int_4 - num);
				}
			}
			else
			{
				num2 = class30_0.method_7(byte_0, int_2, int_4);
			}
			int_2 = (int_2 + num2) & int_1;
			int_3 += num2;
			return num2;
		}
		catch (Exception exception_)
		{
			Class14.smethod_26(exception_, this, class30_0, int_4, num2, num);
			throw;
		}
	}

	public void method_4(byte[] byte_1, int int_4, int int_5)
	{
		try
		{
			if (int_3 > 0)
			{
				throw new InvalidOperationException();
			}
			if (int_5 > int_0)
			{
				int_4 += int_5 - int_0;
				int_5 = int_0;
			}
			Array.Copy(byte_1, int_4, byte_0, 0, int_5);
			int_2 = int_5 & int_1;
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, this, byte_1, int_4, int_5);
			throw;
		}
	}

	public int method_5()
	{
		try
		{
			return int_0 - int_3;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public int method_6()
	{
		try
		{
			return int_3;
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, this);
			throw;
		}
	}

	public int method_7(byte[] byte_1, int int_4, int int_5)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num = int_2;
			if (int_5 > int_3)
			{
				int_5 = int_3;
			}
			else
			{
				num = (int_2 - int_3 + int_5) & int_1;
			}
			num2 = int_5;
			num3 = int_5 - num;
			if (num3 > 0)
			{
				Array.Copy(byte_0, int_0 - num3, byte_1, int_4, num3);
				int_4 += num3;
				int_5 = num;
			}
			Array.Copy(byte_0, num - int_5, byte_1, int_4, int_5);
			int_3 -= num2;
			if (int_3 < 0)
			{
				throw new InvalidOperationException();
			}
			return num2;
		}
		catch (Exception exception_)
		{
			Class14.smethod_28(exception_, this, byte_1, int_4, int_5, num, num2, num3);
			throw;
		}
	}

	public void method_8()
	{
		int num = default(int);
		try
		{
			num = (int_3 = (int_2 = 0));
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, num);
			throw;
		}
	}
}
