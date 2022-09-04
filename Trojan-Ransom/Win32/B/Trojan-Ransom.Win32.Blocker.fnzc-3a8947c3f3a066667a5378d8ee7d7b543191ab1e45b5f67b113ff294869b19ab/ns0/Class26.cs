using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace ns0;

internal sealed class Class26
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 124)]
	private struct Struct14
	{
		[SecuritySafeCritical]
		static Struct14()
		{
			Class32.smethod_1();
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 116)]
	private struct Struct15
	{
		[SecuritySafeCritical]
		static Struct15()
		{
			Class32.smethod_1();
		}
	}

	internal static Struct14 struct14_0/* Not supported: data(61 00 62 00 63 00 64 00 65 00 66 00 67 00 68 00 69 00 6A 00 6B 00 6C 00 6D 00 6E 00 6F 00 70 00 71 00 72 00 73 00 74 00 75 00 76 00 77 00 78 00 79 00 7A 00 41 00 42 00 43 00 44 00 45 00 46 00 47 00 48 00 49 00 4A 00 4B 00 4C 00 4D 00 4E 00 4F 00 50 00 51 00 52 00 53 00 54 00 55 00 56 00 57 00 58 00 59 00 5A 00 30 00 31 00 32 00 33 00 34 00 35 00 36 00 37 00 38 00 39 00) */;

	internal static Struct15 struct15_0/* Not supported: data(01 00 02 00 03 00 04 00 05 00 06 00 07 00 08 00 0E 00 0F 00 10 00 11 00 12 00 13 00 14 00 15 00 16 00 17 00 18 00 19 00 1A 00 1B 00 1C 00 1D 00 1E 00 1F 00 7F 00 80 00 81 00 82 00 83 00 84 00 86 00 87 00 88 00 89 00 8A 00 8B 00 8C 00 8D 00 8E 00 8F 00 90 00 91 00 92 00 93 00 94 00 95 00 96 00 97 00 98 00 99 00 9A 00 9B 00 9C 00 9D 00 9E 00 9F 00) */;

	[SecuritySafeCritical]
	static Class26()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static string smethod_0(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 78:
				return exception_0.Message;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 36:
				return Type.GetTypeFromHandle(runtimeTypeHandle_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_2(ref short short_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 106:
				return short_0.ToString(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static long smethod_3(ref IntPtr intptr_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 3:
				return intptr_0.ToInt64();
			}
		}
	}

	[SecuritySafeCritical]
	internal static MethodBase smethod_4(StackFrame stackFrame_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 41:
				return stackFrame_0.GetMethod();
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_5(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 121:
				return assembly_0.FullName;
			case 122:
				return assembly_0.CodeBase;
			}
		}
	}
}
