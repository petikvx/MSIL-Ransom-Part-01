using System;
using System.Security;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace SmartAssembly.Zip;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class DoNotEncodeStringsAttribute : Attribute
{
	[SecuritySafeCritical]
	static DoNotEncodeStringsAttribute()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static int smethod_0(string string_0, string string_1, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 95:
				return Operators.CompareString(string_0, string_1, bool_0);
			}
		}
	}
}
