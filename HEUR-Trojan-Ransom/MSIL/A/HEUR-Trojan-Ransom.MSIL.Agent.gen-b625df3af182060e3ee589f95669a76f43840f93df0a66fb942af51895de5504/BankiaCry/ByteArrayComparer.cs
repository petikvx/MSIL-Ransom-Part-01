using System;
using System.Collections.Generic;
using System.Text;

namespace BankiaCry;

public class ByteArrayComparer : IEqualityComparer<byte[]>
{
	public bool Equals(byte[] x, byte[] y)
	{
		if (x == null || y == null)
		{
			return x == y;
		}
		if (x.Length != y.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < x.Length)
			{
				if (x[num] != y[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public int GetHashCode(byte[] obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("Key is null");
		}
		return Encoding.UTF8.GetString(obj).GetHashCode();
	}
}
