using System;
using System.Collections.Generic;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3554254475;

internal sealed class C856455061<C3554254475> : IEqualityComparer<C3554254475[]>, IComparer<C3554254475[]> where C3554254475 : IComparable<C3554254475>, IEquatable<C3554254475>
{
	public int GetHashCode(C3554254475[] obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C476252946());
		}
		uint num = 3245957815u;
		int num2 = obj.Length;
		for (int i = 0; i < num2; i++)
		{
			num += (uint)obj[i].GetHashCode();
			num = C2137352139.C3554254475(num * 1606634599, 13);
		}
		return (int)num;
	}

	public bool Equals(C3554254475[] x, C3554254475[] y)
	{
		if (x == y)
		{
			return true;
		}
		if (x == null || y == null)
		{
			return false;
		}
		int num = x.Length;
		if (num != y.Length)
		{
			return false;
		}
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				if (!x[num2].Equals(y[num2]))
				{
					break;
				}
				num2++;
				continue;
			}
			return true;
		}
		return false;
	}

	public int Compare(C3554254475[] x, C3554254475[] y)
	{
		if (x == y)
		{
			return 0;
		}
		if (x == null)
		{
			return -1;
		}
		if (y == null)
		{
			return 1;
		}
		int num = x.Length;
		int num2 = y.Length;
		if (num != num2)
		{
			return (num >= num2) ? 1 : (-1);
		}
		int num3 = 0;
		C3554254475 val;
		C3554254475 other;
		while (true)
		{
			if (num3 < num)
			{
				val = x[num3];
				other = y[num3];
				if (!val.Equals(other))
				{
					break;
				}
				num3++;
				continue;
			}
			return 0;
		}
		return val.CompareTo(other);
	}
}
