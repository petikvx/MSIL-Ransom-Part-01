using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

[AttributeUsage(AttributeTargets.Parameter)]
[DoNotObfuscate]
[DoNotPrune]
internal sealed class Attribute0 : Attribute
{
	static Attribute0()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static void smethod_0(Icon icon_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 119:
				icon_0.Dispose();
				return;
			}
		}
	}

	internal static Size smethod_1(Control control_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 26:
				return control_0.get_ClientSize();
			case 27:
				return control_0.get_Size();
			}
		}
	}

	internal static Process[] smethod_2(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 80:
				return Process.GetProcessesByName(string_0);
			}
		}
	}

	internal static string smethod_3(ref short short_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 14:
				return short_0.ToString(string_0);
			}
		}
	}

	internal static bool smethod_4(FieldInfo fieldInfo_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 79:
				return fieldInfo_0.IsStatic;
			case 80:
				return fieldInfo_0.IsInitOnly;
			}
		}
	}

	internal static byte[] smethod_5(AssemblyName assemblyName_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 106:
				return assemblyName_0.GetPublicKey();
			}
		}
	}
}
