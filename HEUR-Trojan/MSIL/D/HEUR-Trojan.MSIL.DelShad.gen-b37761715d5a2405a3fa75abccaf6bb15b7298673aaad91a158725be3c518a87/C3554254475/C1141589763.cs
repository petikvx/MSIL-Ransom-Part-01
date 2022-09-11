using System;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3554254475;

[Obsolete]
public sealed class C1141589763 : IComparable<C1141589763>
{
	private byte[] C3554254475 = new byte[16];

	public C1141589763(C3865851505 c3865851505_0)
	{
		if (c3865851505_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1130791706());
		}
		Array.Copy(c3865851505_0.C3554254475(), C3554254475, 16);
	}

	public int CompareTo(C1141589763 other)
	{
		if (other == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3775001192());
		}
		int num = 0;
		while (true)
		{
			if (num < 16)
			{
				if (C3554254475[num] >= other.C3554254475[num])
				{
					if (C3554254475[num] > other.C3554254475[num])
					{
						break;
					}
					num++;
					continue;
				}
				return -1;
			}
			return 0;
		}
		return 1;
	}
}
