using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace dfb44QxstTvciGRseP;

[DefaultMember("Item")]
public readonly struct oMqkI2x8eESOayCSyM6 : IEnumerable<EdRPUvx6HtFjma48dEu>, IEquatable<oMqkI2x8eESOayCSyM6>, mLksQ0xGwy0EVfCkPHU<EdRPUvx6HtFjma48dEu>, IEnumerable
{
	public readonly ushort v1rSqe7Sqq;

	private readonly EdRPUvx6HtFjma48dEu[] E90S3YvyHb;

	public readonly Type hSHSQj9psB;

	private static object fo9g5N7cvxYcv10u9cm;

	[SpecialName]
	public int lqcSeesD6g()
	{
		return E90S3YvyHb.Length;
	}

	[SpecialName]
	public EdRPUvx6HtFjma48dEu K6nSFA122H(int int_0)
	{
		return E90S3YvyHb[int_0];
	}

	public oMqkI2x8eESOayCSyM6(in ushort type, params EdRPUvx6HtFjma48dEu[] @params)
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		hSHSQj9psB = null;
		v1rSqe7Sqq = type;
		E90S3YvyHb = @params;
	}

	public oMqkI2x8eESOayCSyM6(Enum enum_0, params EdRPUvx6HtFjma48dEu[] @params)
	{
		HQTs0l79cv8k3IxBocF();
		hSHSQj9psB = enum_0.GetType();
		v1rSqe7Sqq = Convert.ToUInt16(enum_0);
		E90S3YvyHb = @params;
	}

	public int tJcSAMKqWR(int int_0)
	{
		bool flag = false;
		bool flag2 = false;
		int num = int_0;
		while (true)
		{
			bool flag3 = num < E90S3YvyHb.Length;
			if (!mYoYq678BdaA9DuXFDi())
			{
				switch (0)
				{
				case 2:
					break;
				case 1:
					goto IL_0036;
				default:
					goto IL_003a;
				}
				continue;
			}
			goto IL_0036;
			IL_003a:
			if ((flag = !E90S3YvyHb[num].HasFlag((EdRPUvx6HtFjma48dEu)4)) && flag2)
			{
				break;
			}
			flag2 = flag;
			num++;
			continue;
			IL_0036:
			if (!flag3)
			{
				return E90S3YvyHb.Length;
			}
			goto IL_003a;
		}
		return num;
	}

	public IEnumerator<EdRPUvx6HtFjma48dEu> GetEnumerator()
	{
		return ((IEnumerable<EdRPUvx6HtFjma48dEu>)E90S3YvyHb).GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<EdRPUvx6HtFjma48dEu>)E90S3YvyHb).GetEnumerator();
	}

	public override string ToString()
	{
		object obj;
		if (!TtFNWk7axfuKnaiEo2C(hSHSQj9psB, null))
		{
			obj = v1rSqe7Sqq;
			if (obj == null)
			{
				goto IL_0037;
			}
		}
		else
		{
			obj = Enum.GetName(hSHSQj9psB, v1rSqe7Sqq);
			if (obj == null)
			{
				goto IL_0037;
			}
		}
		object obj2 = obj.ToString();
		goto IL_0040;
		IL_0037:
		obj2 = null;
		goto IL_0040;
		IL_0040:
		return (string?)obj2 + ": " + string.Join(",", E90S3YvyHb);
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		return obj is oMqkI2x8eESOayCSyM6 && Equals((oMqkI2x8eESOayCSyM6)obj);
	}

	public bool Equals(oMqkI2x8eESOayCSyM6 other)
	{
		return v1rSqe7Sqq == other.v1rSqe7Sqq && lqcSeesD6g() == other.lqcSeesD6g() && EqualityComparer<EdRPUvx6HtFjma48dEu[]>.Default.Equals(E90S3YvyHb, other.E90S3YvyHb);
	}

	public static bool operator ==(oMqkI2x8eESOayCSyM6 oMqkI2x8eESOayCSyM6_0, oMqkI2x8eESOayCSyM6 oMqkI2x8eESOayCSyM6_1)
	{
		return oMqkI2x8eESOayCSyM6_0.v1rSqe7Sqq == oMqkI2x8eESOayCSyM6_1.v1rSqe7Sqq;
	}

	public static bool operator !=(oMqkI2x8eESOayCSyM6 oMqkI2x8eESOayCSyM6_0, oMqkI2x8eESOayCSyM6 oMqkI2x8eESOayCSyM6_1)
	{
		return oMqkI2x8eESOayCSyM6_0.v1rSqe7Sqq == oMqkI2x8eESOayCSyM6_1.v1rSqe7Sqq;
	}

	public static bool operator ==(oMqkI2x8eESOayCSyM6 oMqkI2x8eESOayCSyM6_0, ushort ushort_0)
	{
		return oMqkI2x8eESOayCSyM6_0.v1rSqe7Sqq == ushort_0;
	}

	public static bool operator !=(oMqkI2x8eESOayCSyM6 oMqkI2x8eESOayCSyM6_0, ushort ushort_0)
	{
		return oMqkI2x8eESOayCSyM6_0.v1rSqe7Sqq == ushort_0;
	}

	public static bool operator ==(oMqkI2x8eESOayCSyM6 oMqkI2x8eESOayCSyM6_0, Enum enum_0)
	{
		return oMqkI2x8eESOayCSyM6_0.v1rSqe7Sqq == Convert.ToInt16(enum_0);
	}

	public static bool operator !=(oMqkI2x8eESOayCSyM6 oMqkI2x8eESOayCSyM6_0, Enum enum_0)
	{
		return oMqkI2x8eESOayCSyM6_0.v1rSqe7Sqq == Convert.ToInt16(enum_0);
	}

	public static implicit operator ushort(in oMqkI2x8eESOayCSyM6 c)
	{
		return c.v1rSqe7Sqq;
	}

	internal static bool mYoYq678BdaA9DuXFDi()
	{
		return fo9g5N7cvxYcv10u9cm == null;
	}

	internal static object p1hVH97vubYJub1tH8W()
	{
		return fo9g5N7cvxYcv10u9cm;
	}

	internal static void HQTs0l79cv8k3IxBocF()
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
	}

	internal static bool TtFNWk7axfuKnaiEo2C(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}
}
