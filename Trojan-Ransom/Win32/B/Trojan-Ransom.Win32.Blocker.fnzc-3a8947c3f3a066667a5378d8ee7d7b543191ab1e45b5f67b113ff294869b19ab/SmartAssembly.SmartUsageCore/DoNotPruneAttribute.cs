using System;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace SmartAssembly.SmartUsageCore;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
public sealed class DoNotPruneAttribute : Attribute
{
	[SecuritySafeCritical]
	static DoNotPruneAttribute()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static byte[] smethod_0(SymmetricAlgorithm symmetricAlgorithm_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 2:
				return symmetricAlgorithm_0.Key;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_1(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 122:
				return methodBase_0.Invoke(object_0, object_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_2(object object_0, Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 25:
				return Conversions.ChangeType(object_0, type_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_3(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 88:
				return Assembly.GetExecutingAssembly();
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_4(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 121:
				return type_0.FullName;
			}
		}
	}
}
