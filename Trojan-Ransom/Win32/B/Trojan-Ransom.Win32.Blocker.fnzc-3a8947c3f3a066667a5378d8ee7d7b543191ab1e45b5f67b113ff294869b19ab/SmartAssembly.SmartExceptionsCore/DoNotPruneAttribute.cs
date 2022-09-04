using System;
using System.Security;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
public sealed class DoNotPruneAttribute : Attribute
{
	[SecuritySafeCritical]
	static DoNotPruneAttribute()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static string smethod_0(string string_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 66:
				return string_0.Substring(int_0, int_1);
			}
		}
	}
}
