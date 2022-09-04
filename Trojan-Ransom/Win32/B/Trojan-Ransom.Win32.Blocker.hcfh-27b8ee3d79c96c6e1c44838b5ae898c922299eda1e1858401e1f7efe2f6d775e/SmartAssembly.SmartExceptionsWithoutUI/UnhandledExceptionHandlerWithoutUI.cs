using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartExceptionsWithoutUI;

public sealed class UnhandledExceptionHandlerWithoutUI : UnhandledExceptionHandler
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
}
