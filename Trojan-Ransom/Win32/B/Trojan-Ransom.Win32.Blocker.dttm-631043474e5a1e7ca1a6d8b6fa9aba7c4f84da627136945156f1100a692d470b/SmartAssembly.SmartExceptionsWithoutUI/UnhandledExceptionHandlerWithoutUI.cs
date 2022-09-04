using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartExceptionsWithoutUI;

public class UnhandledExceptionHandlerWithoutUI : UnhandledExceptionHandler
{
	protected override void OnSecurityException(SecurityExceptionEventArgs securityExceptionEventArgs_0)
	{
		securityExceptionEventArgs_0.ReportException = true;
	}

	protected override void OnReportException(ReportExceptionEventArgs reportExceptionEventArgs_0)
	{
		for (int i = 0; i < 3; i++)
		{
			if (reportExceptionEventArgs_0.SendReport())
			{
				break;
			}
		}
		reportExceptionEventArgs_0.TryToContinue = true;
	}

	protected override void OnFatalException(FatalExceptionEventArgs fatalExceptionEventArgs_0)
	{
		throw fatalExceptionEventArgs_0.FatalException;
	}

	public static bool AttachApp()
	{
		UnhandledExceptionHandler.AttachExceptionHandler(new UnhandledExceptionHandlerWithoutUI());
		return true;
	}
}
