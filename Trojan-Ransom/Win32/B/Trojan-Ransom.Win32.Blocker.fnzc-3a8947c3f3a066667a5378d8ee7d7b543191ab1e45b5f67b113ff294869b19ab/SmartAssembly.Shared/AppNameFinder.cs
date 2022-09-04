using System;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace SmartAssembly.Shared;

public sealed class AppNameFinder
{
	public static string AppName => Win32.smethod_11(AppNameMinusVersion, " ", MajorVersion, 630, 573);

	public static int MajorVersion
	{
		get
		{
			Version version_ = new Version("6.8.0.121");
			return ReportExceptionEventArgs.smethod_0(version_, 978, 935);
		}
	}

	public static string AppNameMinusVersion => "SmartAssembly";

	private AppNameFinder()
	{
	}

	[SecuritySafeCritical]
	static AppNameFinder()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static string smethod_0(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 34:
				return Application.get_ExecutablePath();
			case 35:
				return Path.GetTempFileName();
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_1(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 105:
				return string.Equals(string_0, string_1);
			case 106:
				return string_0.EndsWith(string_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static ILGenerator smethod_2(DynamicMethod dynamicMethod_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 126:
				return dynamicMethod_0.GetILGenerator();
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_3(Control control_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 121:
				control_0.set_Text(string_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_4(Form form_0, Size size_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 95:
				form_0.set_ClientSize(size_0);
				return;
			}
		}
	}
}
