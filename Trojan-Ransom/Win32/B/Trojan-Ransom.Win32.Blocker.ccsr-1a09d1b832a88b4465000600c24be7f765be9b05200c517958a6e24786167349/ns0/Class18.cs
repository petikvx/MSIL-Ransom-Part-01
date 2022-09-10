using System;
using System.Runtime.CompilerServices;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class18
{
	internal Type type_0;

	internal object object_0;

	internal bool bool_0;

	public Class18(object object_1, bool bool_1)
		: this(object_1, (object_1 != null) ? FeedbackControl.smethod_0(object_1, 203, 177) : null, bool_1)
	{
	}

	public Class18(object object_1, Type type_1, bool bool_1)
	{
		object obj = (object_0 = object_1);
		Type type = (type_0 = type_1);
		bool flag = (bool_0 = bool_1);
	}

	[SpecialName]
	public bool method_0()
	{
		return bool_0;
	}

	public object method_1()
	{
		return object_0;
	}

	public Type method_2()
	{
		return type_0;
	}

	static Class18()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static Delegate smethod_0(Delegate delegate_0, Delegate delegate_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 40:
				return Delegate.Combine(delegate_0, delegate_1);
			}
		}
	}
}
