using System.Runtime.CompilerServices;

internal struct Struct4
{
	public int int_0;

	public int int_1;

	public Struct4(int x, int y)
	{
		int_0 = x;
		int_1 = y;
	}

	[SpecialName]
	public static bool smethod_0(Struct4 a, Struct4 b)
	{
		if (a.int_0 == b.int_0)
		{
			return a.int_1 == b.int_1;
		}
		return false;
	}

	[SpecialName]
	public static bool smethod_1(Struct4 a, Struct4 b)
	{
		return !smethod_0(a, b);
	}

	public bool method_0(Struct4 other)
	{
		if (other.int_0 == int_0)
		{
			return other.int_1 == int_1;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (obj.GetType() != typeof(Struct4))
		{
			return false;
		}
		return method_0((Struct4)obj);
	}

	public override int GetHashCode()
	{
		return (int_0 * 397) ^ int_1;
	}
}
