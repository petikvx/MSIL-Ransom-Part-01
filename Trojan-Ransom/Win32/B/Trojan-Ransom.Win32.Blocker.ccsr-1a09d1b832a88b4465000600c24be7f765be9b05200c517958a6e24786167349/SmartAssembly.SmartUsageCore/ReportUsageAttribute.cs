using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartUsageCore;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public class ReportUsageAttribute : Attribute
{
	public ReportUsageAttribute()
	{
	}

	public ReportUsageAttribute(string featureName)
	{
	}

	static ReportUsageAttribute()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 127:
				RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
				return;
			}
		}
	}

	internal static void smethod_1(XmlWriter xmlWriter_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 108:
				xmlWriter_0.WriteStartElement(string_0);
				return;
			}
		}
	}

	internal static int smethod_2(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 14:
				return Marshal.SizeOf(type_0);
			}
		}
	}

	internal static string smethod_3(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 59:
				return string_0 + string_1;
			}
		}
	}
}
