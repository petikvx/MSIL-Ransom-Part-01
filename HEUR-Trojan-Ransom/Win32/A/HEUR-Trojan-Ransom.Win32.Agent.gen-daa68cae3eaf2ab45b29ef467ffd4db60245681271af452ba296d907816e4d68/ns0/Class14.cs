using System;

namespace ns0;

internal class Class14
{
	private const int int_0 = 0;

	private const int int_1 = 1;

	private const int int_2 = 2;

	private const int int_3 = 3;

	private const int int_4 = 4;

	private const int int_5 = 5;

	private static readonly int[] int_6 = new int[3] { 3, 3, 11 };

	private static readonly int[] int_7 = new int[3] { 2, 3, 7 };

	private byte[] byte_0;

	private byte[] byte_1;

	private Class15 class15_0;

	private int int_8;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private int int_13;

	private byte byte_2;

	private int int_14;

	private static readonly int[] int_15 = new int[19]
	{
		16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
		11, 4, 12, 3, 13, 2, 14, 1, 15
	};

	public bool method_0(Class20 class20_0)
	{
		while (true)
		{
			switch (int_8)
			{
			case 5:
			{
				int num = int_7[int_13];
				int num2 = class20_0.method_0(num);
				if (num2 >= 0)
				{
					class20_0.method_1(num);
					num2 += int_6[int_13];
					if (int_14 + num2 <= int_12)
					{
						while (num2-- > 0)
						{
							byte_1[int_14++] = byte_2;
						}
						if (int_14 == int_12)
						{
							return true;
						}
						goto IL_0088;
					}
					throw new Exception();
				}
				return false;
			}
			case 4:
			{
				int num3;
				while (((num3 = class15_0.method_1(class20_0)) & -16) == 0)
				{
					byte_1[int_14++] = (byte_2 = (byte)num3);
					if (int_14 == int_12)
					{
						return true;
					}
				}
				if (num3 >= 0)
				{
					if (num3 >= 17)
					{
						byte_2 = 0;
					}
					else if (int_14 == 0)
					{
						throw new Exception();
					}
					int_13 = num3 - 16;
					int_8 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (int_14 < int_11)
				{
					int num4 = class20_0.method_0(3);
					if (num4 >= 0)
					{
						class20_0.method_1(3);
						byte_0[int_15[int_14]] = (byte)num4;
						int_14++;
						continue;
					}
					return false;
				}
				class15_0 = new Class15(byte_0);
				byte_0 = null;
				int_14 = 0;
				int_8 = 4;
				goto case 4;
			case 2:
				int_11 = class20_0.method_0(4);
				if (int_11 >= 0)
				{
					int_11 += 4;
					class20_0.method_1(4);
					byte_0 = new byte[19];
					int_14 = 0;
					int_8 = 3;
					goto case 3;
				}
				return false;
			case 1:
				int_10 = class20_0.method_0(5);
				if (int_10 >= 0)
				{
					int_10++;
					class20_0.method_1(5);
					int_12 = int_9 + int_10;
					byte_1 = new byte[int_12];
					int_8 = 2;
					goto case 2;
				}
				return false;
			case 0:
				int_9 = class20_0.method_0(5);
				if (int_9 >= 0)
				{
					int_9 += 257;
					class20_0.method_1(5);
					int_8 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0088:
			int_8 = 4;
		}
	}

	public Class15 method_1()
	{
		byte[] destinationArray = new byte[int_9];
		Array.Copy(byte_1, 0, destinationArray, 0, int_9);
		return new Class15(destinationArray);
	}

	public Class15 method_2()
	{
		byte[] destinationArray = new byte[int_10];
		Array.Copy(byte_1, int_9, destinationArray, 0, int_10);
		return new Class15(destinationArray);
	}
}
