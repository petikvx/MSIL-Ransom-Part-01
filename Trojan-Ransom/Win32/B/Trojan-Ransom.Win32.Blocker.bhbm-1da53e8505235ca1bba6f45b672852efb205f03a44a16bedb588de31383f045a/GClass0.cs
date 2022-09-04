using System;
using System.Configuration;
using System.Reflection;
using System.Runtime.InteropServices;
using ns2;
using ns5;

public class GClass0
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct0
	{
		internal uint uint_0;

		static Struct0()
		{
			Class12.Class13.Class14.smethod_1();
			Class7.smethod_15();
		}
	}

	static GClass0()
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
		GClass1.smethod_7();
	}

	internal static SettingsBase smethod_0(SettingsBase settingsBase_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 95:
				return Class9.smethod_12(settingsBase_0, 2, 73);
			}
		}
	}

	internal static int smethod_1(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 34:
				return Class9.smethod_13(type_0, 786, 803);
			}
		}
	}

	internal static string smethod_2(AssemblyName assemblyName_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 14:
				return Class9.smethod_14(assemblyName_0, 162, 141);
			}
		}
	}
}
