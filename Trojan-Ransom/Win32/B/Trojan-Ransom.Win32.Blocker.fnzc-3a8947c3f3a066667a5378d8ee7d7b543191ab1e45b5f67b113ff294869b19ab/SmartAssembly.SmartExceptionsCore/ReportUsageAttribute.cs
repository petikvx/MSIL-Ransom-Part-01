using System;
using System.Reflection;
using System.Security;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

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
	internal static string smethod_0(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 70:
				return object_0.ToString();
			}
		}
	}

	[SecuritySafeCritical]
	internal static Exception smethod_1(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 51:
				return ProjectData.CreateProjectError(int_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime smethod_2(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 21:
				return DateTime.Parse(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_3(DateTime dateTime_0, DateTime dateTime_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 2:
				return dateTime_0 > dateTime_1;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_4(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 24:
				return Assembly.GetCallingAssembly();
			}
		}
	}
}
