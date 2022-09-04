using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns3;

namespace ns4;

internal sealed class Class4
{
	private IntPtr intptr_0 = IntPtr.Zero;

	public Class4(IntPtr intptr_1)
	{
		method_1(intptr_1);
	}

	public Class4(uint uint_0)
	{
		method_1(new IntPtr(uint_0));
	}

	public Class4(Class3.Enum1 enum1_0)
	{
		method_1((IntPtr)(long)enum1_0);
	}

	public Class4(string string_0)
	{
		method_5(string_0);
	}

	[SpecialName]
	public IntPtr method_0()
	{
		return intptr_0;
	}

	[SpecialName]
	public void method_1(IntPtr intptr_1)
	{
		intptr_0 = (smethod_0(intptr_1) ? intptr_1 : Marshal.StringToHGlobalUni(Marshal.PtrToStringUni(intptr_1)));
	}

	[SpecialName]
	public Class3.Enum1 method_2()
	{
		if (!method_3())
		{
			throw new InvalidCastException($"Resource {method_4()} is not of built-in type.");
		}
		return (Class3.Enum1)(int)intptr_0;
	}

	public bool method_3()
	{
		return smethod_0(intptr_0);
	}

	internal static bool smethod_0(IntPtr intptr_1)
	{
		return (uint)(int)intptr_1 <= 65535u;
	}

	[SpecialName]
	public string method_4()
	{
		if (!method_3())
		{
			return Marshal.PtrToStringUni(intptr_0);
		}
		return intptr_0.ToString();
	}

	[SpecialName]
	public void method_5(string string_0)
	{
		intptr_0 = Marshal.StringToHGlobalUni(string_0);
	}

	string object.ToString()
	{
		return method_4();
	}

	int object.GetHashCode()
	{
		if (!method_3())
		{
			return method_4().GetHashCode();
		}
		return method_0().ToInt32();
	}

	bool object.Equals(object obj)
	{
		if (obj is Class4 && obj == this)
		{
			return true;
		}
		if (obj is Class4 && (obj as Class4).GetHashCode() == GetHashCode())
		{
			return true;
		}
		return false;
	}
}
