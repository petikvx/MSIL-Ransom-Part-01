using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Windows.Forms;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class24
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 124)]
	private struct Struct25
	{
		static Struct25()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 116)]
	private struct Struct26
	{
		static Struct26()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	internal static Struct25 struct25_0/* Not supported: data(61 00 62 00 63 00 64 00 65 00 66 00 67 00 68 00 69 00 6A 00 6B 00 6C 00 6D 00 6E 00 6F 00 70 00 71 00 72 00 73 00 74 00 75 00 76 00 77 00 78 00 79 00 7A 00 41 00 42 00 43 00 44 00 45 00 46 00 47 00 48 00 49 00 4A 00 4B 00 4C 00 4D 00 4E 00 4F 00 50 00 51 00 52 00 53 00 54 00 55 00 56 00 57 00 58 00 59 00 5A 00 30 00 31 00 32 00 33 00 34 00 35 00 36 00 37 00 38 00 39 00) */;

	internal static Struct26 struct26_0/* Not supported: data(01 00 02 00 03 00 04 00 05 00 06 00 07 00 08 00 0E 00 0F 00 10 00 11 00 12 00 13 00 14 00 15 00 16 00 17 00 18 00 19 00 1A 00 1B 00 1C 00 1D 00 1E 00 1F 00 7F 00 80 00 81 00 82 00 83 00 84 00 86 00 87 00 88 00 89 00 8A 00 8B 00 8C 00 8D 00 8E 00 8F 00 90 00 91 00 92 00 93 00 94 00 95 00 96 00 97 00 98 00 99 00 9A 00 9B 00 9C 00 9D 00 9E 00 9F 00) */;

	static Class24()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static void smethod_0(Control control_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 13:
				control_0.set_Text(string_0);
				return;
			case 14:
				control_0.set_Name(string_0);
				return;
			}
		}
	}

	internal static Assembly smethod_1(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 59:
				return Assembly.GetExecutingAssembly();
			case 60:
				return Assembly.GetEntryAssembly();
			}
		}
	}

	internal static Exception smethod_2(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 118:
				return exception_0.InnerException;
			}
		}
	}

	internal static bool smethod_3(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 57:
				return string_0.EndsWith(string_1);
			}
		}
	}

	internal static Type smethod_4(FieldInfo fieldInfo_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 56:
				return fieldInfo_0.FieldType;
			}
		}
	}

	internal static int smethod_5(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 66:
				return type_0.GetArrayRank();
			}
		}
	}

	internal static Evidence smethod_6(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 115:
				return assembly_0.get_Evidence();
			}
		}
	}
}
