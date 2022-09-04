using System;

namespace ns0;

internal class Class19
{
	private static int int_0 = 32768;

	private static int int_1 = int_0 - 1;

	private byte[] byte_0 = new byte[int_0];

	private int int_2;

	private int int_3;

	public void method_0(int int_4)
	{
		if (int_3++ == int_0)
		{
			throw new InvalidOperationException(Class34.smethod_0(881531724, 2146514814, 2097126486));
		}
		byte_0[int_2++] = (byte)int_4;
		int_2 &= int_1;
	}

	private void method_1(int int_4, int int_5, int int_6)
	{
		while (int_5-- > 0)
		{
			byte_0[int_2++] = byte_0[int_4++];
			int_2 &= int_1;
			int_4 &= int_1;
		}
	}

	public void method_2(int int_4, int int_5)
	{
		if ((int_3 += int_4) > int_0)
		{
			throw new InvalidOperationException(Class34.smethod_0(1112614187, 2146514792, 2097126486));
		}
		int num = (int_2 - int_5) & int_1;
		int num2 = int_0 - int_4;
		if (num <= num2 && int_2 < num2)
		{
			if (int_4 <= int_5)
			{
				Array.Copy(byte_0, num, byte_0, int_2, int_4);
				int_2 += int_4;
			}
			else
			{
				while (int_4-- > 0)
				{
					byte_0[int_2++] = byte_0[num++];
				}
			}
		}
		else
		{
			method_1(num, int_4, int_5);
		}
	}

	public int method_3(Class20 class20_0, int int_4)
	{
		int_4 = Math.Min(Math.Min(int_4, int_0 - int_3), class20_0.method_4());
		int num = int_0 - int_2;
		int num2;
		if (int_4 > num)
		{
			num2 = class20_0.method_7(byte_0, int_2, num);
			if (num2 == num)
			{
				num2 += class20_0.method_7(byte_0, 0, int_4 - num);
			}
		}
		else
		{
			num2 = class20_0.method_7(byte_0, int_2, int_4);
		}
		int_2 = (int_2 + num2) & int_1;
		int_3 += num2;
		return num2;
	}

	public void method_4(byte[] byte_1, int int_4, int int_5)
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

	public int method_5()
	{
		return int_0 - int_3;
	}

	public int method_6()
	{
		return int_3;
	}

	public int method_7(byte[] byte_1, int int_4, int int_5)
	{
		int num = int_2;
		if (int_5 > int_3)
		{
			int_5 = int_3;
		}
		else
		{
			num = (int_2 - int_3 + int_5) & int_1;
		}
		int num2 = int_5;
		int num3 = int_5 - num;
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

	public void method_8()
	{
		int_2 = 0;
		int_3 = 0;
	}
}
