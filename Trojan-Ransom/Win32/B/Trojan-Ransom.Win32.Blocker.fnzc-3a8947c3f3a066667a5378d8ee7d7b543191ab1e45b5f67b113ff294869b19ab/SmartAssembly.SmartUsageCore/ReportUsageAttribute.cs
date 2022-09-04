using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using ns0;

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

	[SecuritySafeCritical]
	static ReportUsageAttribute()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static object smethod_0(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 42:
				return RuntimeHelpers.GetObjectValue(object_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(MemoryStream memoryStream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 118:
				memoryStream_0.Write(byte_0, int_0, int_1);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_2(Control control_0, Size size_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 47:
				control_0.set_Size(size_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Version smethod_3(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 88:
				return Environment.Version;
			}
		}
	}
}
