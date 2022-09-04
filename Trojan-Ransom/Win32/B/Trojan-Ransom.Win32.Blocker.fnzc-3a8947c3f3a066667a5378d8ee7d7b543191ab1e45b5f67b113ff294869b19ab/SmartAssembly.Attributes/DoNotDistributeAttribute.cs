using System;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns0;

namespace SmartAssembly.Attributes;

public sealed class DoNotDistributeAttribute : Attribute
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1854)]
	private struct Struct19
	{
	}

	private static readonly char[] O;

	private static readonly char[] T;

	private static readonly string[] P;

	internal static byte V/* Not supported: data(00) */;

	public DoNotDistributeAttribute(string string_0)
	{
	}

	[SecuritySafeCritical]
	static DoNotDistributeAttribute()
	{
		Class32.smethod_1();
		T = new char[927];
		char[] array = new char[8];
		array[4] = '⌙';
		array[0] = '⦅';
		array[2] = '㯌';
		array[7] = 'ȡ';
		array[1] = '\u12c7';
		array[6] = 'ጧ';
		array[5] = 'ᕾ';
		array[3] = 'ܣ';
		P = new string[44];
		O = array;
	}

	[SecuritySafeCritical]
	internal static void smethod_0(RegistryKey registryKey_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 74:
				registryKey_0.Close();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_1(object object_0, object object_1, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 93:
				return Operators.ConditionalCompareObjectEqual(object_0, object_1, bool_0);
			}
		}
	}
}
