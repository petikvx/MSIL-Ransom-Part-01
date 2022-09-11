using System;
using System.Collections;

namespace ns0;

internal sealed class Class1 : IEqualityComparer
{
	internal static IEqualityComparer iequalityComparer_0 = new Class1();

	public static int smethod_0(string string_0)
	{
		char num = Class1.pFPpUYHBBnzNxKlqNUEVbDRtemwcA(string_0);
		int num2 = 5381;
		char c = num;
		int num3;
		while ((num3 = c) != 0)
		{
			num2 = ((num2 << 5) + num2) ^ num3;
			c = (char)(c + 1);
		}
		return num2;
	}

	bool IEqualityComparer.Equals(object x, object y)
	{
		return Class1.JpZmsMMrwMiUnfUbIYrZNUmTNEXc(x, y);
	}

	public virtual int vmethod_0(object object_0)
	{
		if (!(object_0 is string string_))
		{
			return Class1.RSHDMaCPTgpCqYNPMKuobOhqOogiA(object_0);
		}
		return smethod_0(string_);
	}

	static char pFPpUYHBBnzNxKlqNUEVbDRtemwcA(string string_0)
	{
		return Convert.ToChar(string_0);
	}

	static bool JpZmsMMrwMiUnfUbIYrZNUmTNEXc(object object_0, object object_1)
	{
		return object.Equals(object_0, object_1);
	}

	static int RSHDMaCPTgpCqYNPMKuobOhqOogiA(object object_0)
	{
		return object_0.GetHashCode();
	}
}
