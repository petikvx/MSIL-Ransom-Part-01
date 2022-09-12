using System;

namespace ns5;

internal readonly struct Struct5<T, U> : IEquatable<Struct5<T, U>>
{
	public readonly T gparam_0;

	public readonly U gparam_1;

	public Struct5(T gparam_2, U gparam_3)
	{
		gparam_0 = gparam_2;
		gparam_1 = gparam_3;
	}

	int ValueType.GetHashCode()
	{
		T val = gparam_0;
		int num = ((val != null) ? val.GetHashCode() : 0);
		U val2 = gparam_1;
		return num ^ ((val2 != null) ? val2.GetHashCode() : 0);
	}

	bool ValueType.Equals(object obj)
	{
		if (obj is Struct5<T, U> other)
		{
			return System_002EIEquatable_003Cns5_002EStruct5_003CT_002CU_003E_003E_002EEquals(other);
		}
		return false;
	}

	bool IEquatable<Struct5<T, U>>.Equals(Struct5<T, U> other)
	{
		if (object.Equals(gparam_0, other.gparam_0))
		{
			return object.Equals(gparam_1, other.gparam_1);
		}
		return false;
	}
}
