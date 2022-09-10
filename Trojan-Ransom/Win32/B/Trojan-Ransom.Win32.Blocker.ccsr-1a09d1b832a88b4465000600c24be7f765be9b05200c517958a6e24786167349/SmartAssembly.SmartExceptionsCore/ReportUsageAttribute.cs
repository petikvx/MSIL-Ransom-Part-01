using System;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartExceptionsCore;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public class ReportUsageAttribute : Attribute
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2434)]
	private struct Struct19
	{
	}

	private static readonly char[] b;

	private static readonly char[] O;

	private static readonly string[] a;

	internal static byte C/* Not supported: data(00) */;

	public ReportUsageAttribute()
	{
	}

	public ReportUsageAttribute(string featureName)
	{
	}

	static ReportUsageAttribute()
	{
		DESCryptoIndirector.smethod_0();
		O = new char[1217];
		char[] array = new char[8];
		array[2] = '⛱';
		array[3] = '\u082d';
		array[1] = 'ᮞ';
		array[4] = '\u0952';
		array[0] = '㤖';
		array[6] = 'ໞ';
		array[7] = '૦';
		array[5] = 'ᡑ';
		a = new string[47];
		b = array;
	}

	internal static Type smethod_0(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 10:
				return exception_0.GetType();
			}
		}
	}

	internal static Type smethod_1(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 32:
				return type_0.GetElementType();
			}
		}
	}

	internal static Assembly smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 14:
				return Assembly.GetCallingAssembly();
			}
		}
	}

	internal static bool smethod_3(Guid guid_0, Guid guid_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 16:
				return guid_0 != guid_1;
			}
		}
	}

	internal static string smethod_4(string string_0, object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 97:
				return string.Format(string_0, object_0, object_1);
			}
		}
	}
}
