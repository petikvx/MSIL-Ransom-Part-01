using System;

namespace XjXnoB31;

public sealed class iPb2Xq
{
	private static readonly uint a;

	private static readonly int b;

	public static uint xzUz5iI85y4(uint uint_0, byte[] o2PHXcKjc, int int_0, int iPpXPwL9VT)
	{
		if (o2PHXcKjc == null)
		{
			return 1u;
		}
		uint num = uint_0 & 0xFFFFu;
		uint num2 = (uint_0 >> 16) & 0xFFFFu;
		while (iPpXPwL9VT > 0)
		{
			int num3 = ((iPpXPwL9VT < b) ? iPpXPwL9VT : b);
			iPpXPwL9VT -= num3;
			while (num3 >= 16)
			{
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num += o2PHXcKjc[int_0++];
				num2 += num;
				num3 -= 16;
			}
			if (num3 != 0)
			{
				do
				{
					num += o2PHXcKjc[int_0++];
					num2 += num;
				}
				while (--num3 != 0);
			}
			num %= a;
			num2 %= a;
		}
		return (num2 << 16) | num;
	}

	static iPb2Xq()
	{
		DateTime dateTime = new DateTime(2021, 7, 24, 0, 22, 31);
		if (dateTime < DateTime.Now || true)
		{
		}
		a = 65521u;
		b = 5552;
	}
}
