using System;

namespace ns0;

internal class Class24
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

	private Class25 class25_0;

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

	public bool method_0(Class30 class30_0)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		byte b = default(byte);
		int num8 = default(int);
		try
		{
			while (true)
			{
				num = int_8;
				switch (num)
				{
				case 5:
					num2 = int_7[int_13];
					num3 = class30_0.method_0(num2);
					if (num3 >= 0)
					{
						class30_0.method_1(num2);
						num3 += int_6[int_13];
						if (int_14 + num3 <= int_12)
						{
							while (num3-- > 0)
							{
								byte[] array = byte_1;
								num4 = int_14++;
								array[num4] = byte_2;
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
				case 4:
					while (((num5 = class25_0.method_1(class30_0)) & -16) == 0)
					{
						byte[] array2 = byte_1;
						num6 = int_14++;
						int num7 = num6;
						b = (byte_2 = (byte)num5);
						array2[num7] = b;
						if (int_14 == int_12)
						{
							return true;
						}
					}
					if (num5 >= 0)
					{
						if (num5 >= 17)
						{
							byte_2 = 0;
						}
						else if (int_14 == 0)
						{
							throw new Exception();
						}
						int_13 = num5 - 16;
						int_8 = 5;
						goto case 5;
					}
					return false;
				case 3:
					while (int_14 < int_11)
					{
						num8 = class30_0.method_0(3);
						if (num8 >= 0)
						{
							class30_0.method_1(3);
							byte_0[int_15[int_14]] = (byte)num8;
							int_14++;
							continue;
						}
						return false;
					}
					class25_0 = new Class25(byte_0);
					byte_0 = null;
					int_14 = 0;
					int_8 = 4;
					goto case 4;
				case 2:
					int_11 = class30_0.method_0(4);
					if (int_11 >= 0)
					{
						int_11 += 4;
						class30_0.method_1(4);
						byte_0 = new byte[19];
						int_14 = 0;
						int_8 = 3;
						goto case 3;
					}
					return false;
				case 1:
					int_10 = class30_0.method_0(5);
					if (int_10 >= 0)
					{
						int_10++;
						class30_0.method_1(5);
						int_12 = int_9 + int_10;
						byte_1 = new byte[int_12];
						int_8 = 2;
						goto case 2;
					}
					return false;
				case 0:
					int_9 = class30_0.method_0(5);
					if (int_9 >= 0)
					{
						int_9 += 257;
						class30_0.method_1(5);
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
		catch (Exception exception_)
		{
			Class14.smethod_31(exception_, this, class30_0, num8, num5, num2, num3, num, num6, b, num4);
			throw;
		}
	}

	public Class25 method_1()
	{
		byte[] array = default(byte[]);
		try
		{
			array = new byte[int_9];
			Array.Copy(byte_1, 0, array, 0, int_9);
			return new Class25(array);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, array);
			throw;
		}
	}

	public Class25 method_2()
	{
		byte[] array = default(byte[]);
		try
		{
			array = new byte[int_10];
			Array.Copy(byte_1, int_9, array, 0, int_10);
			return new Class25(array);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, this, array);
			throw;
		}
	}
}
