using System;
using System.IO;
using System.Security;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace SmartAssembly.SmartExceptionsWithoutUI;

public class UnhandledExceptionHandlerWithoutUI : UnhandledExceptionHandler
{
	protected override void OnSecurityException(SecurityExceptionEventArgs e)
	{
		e.ReportException = true;
	}

	protected override void OnReportException(ReportExceptionEventArgs e)
	{
		for (int i = 0; i < 3; i++)
		{
			if (e.SendReport())
			{
				break;
			}
		}
		e.TryToContinue = true;
	}

	protected override void OnFatalException(FatalExceptionEventArgs e)
	{
		throw e.FatalException;
	}

	public static bool AttachApp()
	{
		UnhandledExceptionHandler.AttachExceptionHandler(new UnhandledExceptionHandlerWithoutUI());
		return true;
	}

	[SecuritySafeCritical]
	static UnhandledExceptionHandlerWithoutUI()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_1(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 40:
				stream_0.Close();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime smethod_2(ref DateTime dateTime_0, double double_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 12:
				return dateTime_0.AddDays(double_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_3(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 99:
				return type_0.IsEnum;
			}
		}
	}
}
