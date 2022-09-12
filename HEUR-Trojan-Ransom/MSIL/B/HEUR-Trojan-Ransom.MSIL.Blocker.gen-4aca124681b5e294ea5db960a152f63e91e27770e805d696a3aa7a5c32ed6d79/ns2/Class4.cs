using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;
using ns4;
using ns5;
using ns8;

namespace ns2;

internal sealed class Class4
{
	[NonSerialized]
	internal static GetString getString_0;

	public static string smethod_0()
	{
		try
		{
			object object_;
			switch (smethod_1(getString_0(107391369), Class5.smethod_0(), out object_))
			{
			case Enum3.const_1:
				return null;
			case Enum3.const_0:
			{
				Enum3 @enum = smethod_1(getString_0(107391369), Class5.smethod_1(), out object_);
				break;
			}
			}
			return (string)object_;
		}
		catch
		{
			return null;
		}
	}

	public static Enum3 smethod_1(string string_0, string string_1, out object object_0)
	{
		object_0 = null;
		try
		{
			Enum3 enum3_;
			using Class7 @class = Class9.smethod_0(Class6.uintptr_2, Enum4.const_0, Enum2.const_0, string_1, out enum3_);
			switch (enum3_)
			{
			case Enum3.const_1:
				return Enum3.const_1;
			default:
				return Enum3.const_0;
			case Enum3.const_2:
				object_0 = @class.vmethod_0(string_0);
				break;
			}
		}
		catch
		{
			return Enum3.const_0;
		}
		return Enum3.const_2;
	}

	static Class4()
	{
		Strings.CreateGetStringDelegate(typeof(Class4));
	}
}
