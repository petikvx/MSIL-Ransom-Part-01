using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using Microsoft.VisualBasic;
using Microsoft.Win32;

namespace ns1;

internal sealed class Class6
{
	[SecuritySafeCritical]
	internal static int smethod_0(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 54:
				return string_0.Length;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Label smethod_1(ILGenerator ilgenerator_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 34:
				return ilgenerator_0.DefineLabel();
			}
		}
	}

	[SecuritySafeCritical]
	internal static MethodInfo smethod_2(Type type_0, string string_0, Type[] type_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 127:
				return type_0.GetMethod(string_0, type_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_3(RegistryKey registryKey_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 105:
				return registryKey_0.GetValue(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_4(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 57:
				return Interaction.GetObject(string_0, string_1);
			}
		}
	}
}
