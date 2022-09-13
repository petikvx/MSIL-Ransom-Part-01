public sealed class GClass4
{
	private static readonly uint uint_0 = 65521u;

	private static readonly int int_0 = 5552;

	public static uint smethod_0(uint uint_1, byte[] byte_0, int int_1, int int_2)
	{
		if (byte_0 == null)
		{
			return 1u;
		}
		uint num = uint_1 & 0xFFFFu;
		uint num2 = (uint_1 >> 16) & 0xFFFFu;
		while (int_2 > 0)
		{
			int num3 = ((int_2 < int_0) ? int_2 : int_0);
			int_2 -= num3;
			while (num3 >= 16)
			{
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num += byte_0[int_1++];
				num2 += num;
				num3 -= 16;
			}
			if (num3 != 0)
			{
				do
				{
					num += byte_0[int_1++];
					num2 += num;
				}
				while (--num3 != 0);
			}
			num %= uint_0;
			num2 %= uint_0;
		}
		return (num2 << 16) | num;
	}
}
