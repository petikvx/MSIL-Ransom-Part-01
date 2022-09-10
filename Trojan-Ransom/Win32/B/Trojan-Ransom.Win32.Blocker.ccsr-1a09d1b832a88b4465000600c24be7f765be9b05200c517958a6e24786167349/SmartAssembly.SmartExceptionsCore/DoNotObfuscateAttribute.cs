using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartExceptionsCore;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class DoNotObfuscateAttribute : Attribute
{
	static DoNotObfuscateAttribute()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static MethodInfo smethod_0(PropertyInfo propertyInfo_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 7:
				return propertyInfo_0.GetSetMethod();
			}
		}
	}

	internal static void smethod_1(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 40:
				ProjectData.ClearProjectError();
				return;
			}
		}
	}

	internal static string[] smethod_2(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 85:
				return Directory.GetDirectories(string_0);
			}
		}
	}
}
