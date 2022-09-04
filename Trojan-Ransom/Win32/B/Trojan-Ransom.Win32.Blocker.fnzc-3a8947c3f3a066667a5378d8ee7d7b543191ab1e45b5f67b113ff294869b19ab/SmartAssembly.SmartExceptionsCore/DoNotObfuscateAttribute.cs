using System;
using System.Security;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class DoNotObfuscateAttribute : Attribute
{
	[SecuritySafeCritical]
	static DoNotObfuscateAttribute()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static RegistryKey smethod_0(RegistryKey registryKey_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 9:
				return registryKey_0.OpenSubKey(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_1(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 2:
				return Interaction.GetObject(string_0, string_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_2(ref DateTime dateTime_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 54:
				return dateTime_0.Month;
			}
		}
	}
}
