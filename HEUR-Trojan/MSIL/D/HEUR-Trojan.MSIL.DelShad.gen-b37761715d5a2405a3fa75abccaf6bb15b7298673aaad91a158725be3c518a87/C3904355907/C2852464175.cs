#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using C1255198513;
using C3554254475;

namespace C3904355907;

public abstract class C2852464175
{
	[SpecialName]
	public abstract global::C3554254475.C3865851505 C3554254475();

	[SpecialName]
	public abstract string C3904355907();

	public virtual global::C1255198513.C1304234792 C1255198513()
	{
		return new global::C1255198513.C1304234792(C3554254475());
	}

	public virtual void C3554254475(global::C1255198513.C1304234792 c1304234792_0)
	{
		Debug.Assert(c1304234792_0 != null);
		Debug.Assert(c1304234792_0.C3554254475().Equals(C3554254475()));
	}

	public abstract byte[] C3554254475(byte[] byte_0, global::C1255198513.C1304234792 c1304234792_0);

	public virtual global::C1255198513.C1304234792 C3554254475(uint uint_0)
	{
		throw new NotImplementedException();
	}

	protected void C3554254475(global::C1255198513.C1304234792 c1304234792_0, string string_0, ulong ulong_0, ulong ulong_1, uint uint_0, bool bool_0)
	{
		if (c1304234792_0 == null)
		{
			Debug.Assert(condition: false);
			return;
		}
		if (string.IsNullOrEmpty(string_0))
		{
			Debug.Assert(condition: false);
			return;
		}
		if (ulong_0 > ulong_1)
		{
			Debug.Assert(condition: false);
			return;
		}
		if (ulong_1 > long.MaxValue)
		{
			Debug.Assert(condition: false);
			ulong_1 = 9223372036854775807uL;
			if (ulong_0 > long.MaxValue)
			{
				c1304234792_0.C3904355907(string_0, ulong_0);
				return;
			}
		}
		byte[] array = new byte[32];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)i;
		}
		ulong num = ulong_0;
		ulong num2 = ulong_0 + 1L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = uint_0;
		while (num2 <= ulong_1)
		{
			c1304234792_0.C3904355907(string_0, num2);
			Stopwatch stopwatch = Stopwatch.StartNew();
			C3554254475(array, c1304234792_0);
			stopwatch.Stop();
			num4 = stopwatch.ElapsedMilliseconds;
			if (num4 > num5)
			{
				break;
			}
			num = num2;
			num3 = num4;
			num2 <<= 1;
		}
		if (num2 > ulong_1)
		{
			num2 = ulong_1;
			num4 = 0L;
		}
		if (num > num2)
		{
			num = num2;
		}
		while (num2 - num >= 2L)
		{
			ulong num6 = num2 + num >> 1;
			if (bool_0 && num3 > 0L && num4 > num5 && num3 <= num5)
			{
				num6 = num + (ulong)((long)(num2 - num) * (num5 - num3)) / (ulong)(num4 - num3);
				if (num6 >= num && num6 <= num2)
				{
					num6 = Math.Max(num6, num + 1L);
					num6 = Math.Min(num6, num2 - 1L);
				}
				else
				{
					Debug.Assert(condition: false);
					num6 = num2 + num >> 1;
				}
			}
			c1304234792_0.C3904355907(string_0, num6);
			Stopwatch stopwatch2 = Stopwatch.StartNew();
			C3554254475(array, c1304234792_0);
			stopwatch2.Stop();
			long elapsedMilliseconds = stopwatch2.ElapsedMilliseconds;
			if (elapsedMilliseconds != num5)
			{
				if (elapsedMilliseconds > num5)
				{
					num2 = num6;
					num4 = elapsedMilliseconds;
				}
				else
				{
					num = num6;
					num3 = elapsedMilliseconds;
				}
				continue;
			}
			num = num6;
			break;
		}
		c1304234792_0.C3904355907(string_0, num);
	}
}
