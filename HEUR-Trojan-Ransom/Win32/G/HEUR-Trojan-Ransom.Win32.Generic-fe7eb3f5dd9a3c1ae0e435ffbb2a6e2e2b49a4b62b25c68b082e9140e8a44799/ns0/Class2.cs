using System;

namespace ns0;

internal class Class2
{
	private ulong ulong_0 = 1uL;

	private ulong ulong_1 = 2uL;

	private const ulong ulong_2 = 11376068507788127593uL;

	public Class2(int int_0)
	{
		Random random = new Random(int_0);
		ulong_0 ^= (ulong)random.Next();
		ulong_1 ^= (ulong)random.Next();
	}

	private ulong method_0()
	{
		ulong num = (ulong_0 ^ ulong_1) * 11376068507788127593uL;
		ulong num2 = num;
		num = num2 ^ (num2 >> 47);
		ulong num3 = (ulong_1 ^ num) * 11376068507788127593uL;
		ulong num4 = num3;
		num3 = num4 ^ (num4 >> 47);
		num3 *= 11376068507788127593uL;
		ulong num5 = ulong_0 ^ num3;
		ulong_1 = ulong_0;
		ulong_0 = num5;
		return num3;
	}

	public bool method_1(int int_0, ulong ulong_3)
	{
		while (true)
		{
			int num;
			int num2;
			if (int_0-- <= 0)
			{
				num = -2115595874;
				num2 = -2115595874;
			}
			else
			{
				num = 1316155211;
				num2 = 1316155211;
			}
			while (true)
			{
				int num3 = num;
				switch ((uint)(~(-(~(((-269620568 - num3) ^ 0x4FE8DD1B) - 1426538454) ^ 0x13156C11))) % 5u)
				{
				case 2u:
				{
					int num4;
					if (method_0() != ulong_3)
					{
						num = -526874922;
						num4 = -526874922;
					}
					else
					{
						num = 1083625823;
						num4 = 1083625823;
					}
					continue;
				}
				case 0u:
					num = 1316155211;
					continue;
				case 4u:
					break;
				default:
					return false;
				case 3u:
					return true;
				}
				break;
			}
		}
	}
}
