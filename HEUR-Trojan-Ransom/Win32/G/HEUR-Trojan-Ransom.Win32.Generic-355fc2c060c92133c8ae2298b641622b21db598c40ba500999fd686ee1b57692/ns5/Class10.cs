using System;
using ns4;
using ns7;

namespace ns5;

internal sealed class Class10
{
	internal IntPtr intptr_0 = IntPtr.Zero;

	public Class10(uint uint_0)
	{
		Class23.smethod_10(new IntPtr(uint_0), this);
	}

	public Class10(Class21.Enum5 enum5_0)
	{
		Class23.smethod_10((IntPtr)(long)enum5_0, this);
	}

	public Class10(string string_0)
	{
		Class23.smethod_73(this, string_0);
	}

	string object.ToString()
	{
		return Class23.smethod_46(this);
	}

	int object.GetHashCode()
	{
		if (!Class23.smethod_41(this))
		{
			return Class23.smethod_46(this).GetHashCode();
		}
		IntPtr intPtr = intptr_0;
		return intPtr.ToInt32();
	}

	bool object.Equals(object obj)
	{
		if (obj is Class10 && obj == this)
		{
			return true;
		}
		if (obj is Class10 && (obj as Class10).GetHashCode() == GetHashCode())
		{
			return true;
		}
		return false;
	}
}
