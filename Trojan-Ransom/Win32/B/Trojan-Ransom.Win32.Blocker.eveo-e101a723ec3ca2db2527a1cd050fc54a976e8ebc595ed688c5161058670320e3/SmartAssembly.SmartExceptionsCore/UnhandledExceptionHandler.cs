using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using SmartAssembly.Shared;
using SmartAssembly.SmartUsageWithoutUI;

namespace SmartAssembly.SmartExceptionsCore;

public abstract class UnhandledExceptionHandler
{
	public const string ApplicationName = "{1fe9e38e-05cc-46a3-ae48-6cda8fb62056}";

	public const string CompanyName = "{395edd3b-130e-4160-bb08-6931086cea46}";

	private static readonly bool AlwaysContinueOnError = Convert.ToBoolean("False");

	private static readonly string SecurityExceptionsHaveSpecialTreatment = "1";

	private static UnhandledExceptionHandler s_Handler;

	private IWebProxy m_Proxy;

	private static UnhandledExceptionHandler Handler
	{
		get
		{
			if (s_Handler == null)
			{
				Type[] types = Assembly.GetExecutingAssembly().GetTypes();
				foreach (Type type in types)
				{
					if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(UnhandledExceptionHandler))
					{
						continue;
					}
					try
					{
						s_Handler = (UnhandledExceptionHandler)Activator.CreateInstance(type, nonPublic: true);
						if (s_Handler != null)
						{
							break;
						}
					}
					catch
					{
					}
				}
			}
			return s_Handler;
		}
	}

	public event EventHandler DebuggerLaunched;

	public event SendingReportFeedbackEventHandler SendingReportFeedback;

	protected abstract void OnReportException(ReportExceptionEventArgs e);

	protected abstract void OnFatalException(FatalExceptionEventArgs e);

	protected abstract void OnSecurityException(SecurityExceptionEventArgs e);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void AttachExceptionHandler(UnhandledExceptionHandler unhandledExceptionHandler)
	{
		if (unhandledExceptionHandler != null)
		{
			s_Handler = unhandledExceptionHandler;
			AppDomain.CurrentDomain.UnhandledException += unhandledExceptionHandler.OnUnhandledException;
			Application.add_ThreadException((ThreadExceptionEventHandler)unhandledExceptionHandler.OnThreadException);
		}
	}

	public static void EntryPointException(Exception exception, object[] objects)
	{
		if (exception == null || !(exception is SecurityException) || !(SecurityExceptionsHaveSpecialTreatment == "1") || !Handler.InvokeSecurityException((SecurityException)exception))
		{
			StackFrameHelper.CreateExceptionN(exception, objects);
			Handler.ReportException(exception, canContinue: false, manuallyReported: false);
		}
	}

	public static Exception ReportWebMethodException(Exception exception, object[] objects)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		try
		{
			if ((object)exception.GetType() == typeof(Exception) && exception.Message == "{report}")
			{
				exception = exception.InnerException;
			}
			else
			{
				StackFrameHelper.CreateExceptionN(exception, objects);
			}
			Handler.ReportException(exception, canContinue: true, manuallyReported: false);
		}
		catch
		{
		}
		return (Exception)new SoapException(exception.Message, SoapException.ServerFaultCode);
	}

	public static void ReportException(Exception exception, object[] objects)
	{
		try
		{
			if ((object)exception.GetType() == typeof(Exception) && exception.Message == "{report}")
			{
				exception = exception.InnerException;
			}
			else
			{
				StackFrameHelper.CreateExceptionN(exception, objects);
			}
			Handler.ReportException(exception, canContinue: true, manuallyReported: true);
		}
		catch
		{
		}
	}

	private void OnThreadException(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			Exception ex = e.Exception;
			Type type = ex.GetType();
			if (type.Name == "UnhandledException" && type.Namespace == "SmartAssembly.SmartExceptionsCore")
			{
				ex = (Exception)type.GetField("PreviousException")!.GetValue(ex);
			}
			if (!(ex is SecurityException) || !(SecurityExceptionsHaveSpecialTreatment == "1") || !InvokeSecurityException(ex as SecurityException))
			{
				ReportException(ex, canContinue: true, manuallyReported: false);
			}
		}
		catch
		{
		}
	}

	private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		try
		{
			if ((!(e.ExceptionObject is SecurityException) || !(SecurityExceptionsHaveSpecialTreatment == "1") || !InvokeSecurityException(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
			{
				ReportException((Exception)e.ExceptionObject, !e.IsTerminating, manuallyReported: false);
			}
		}
		catch
		{
		}
	}

	public void SetProxy(IWebProxy proxy)
	{
		m_Proxy = proxy;
	}

	protected virtual Guid GetUserID()
	{
		return Guid.Empty;
	}

	private bool InvokeSecurityException(SecurityException exception)
	{
		SecurityExceptionEventArgs securityExceptionEventArgs = new SecurityExceptionEventArgs(exception);
		OnSecurityException(securityExceptionEventArgs);
		if (securityExceptionEventArgs.ReportException)
		{
			return false;
		}
		if (!securityExceptionEventArgs.TryToContinue)
		{
			Application.Exit();
		}
		return true;
	}

	[ReportUsage("Unhandled Exception Encountered")]
	private void ReportException(Exception exception, bool canContinue, bool manuallyReported)
	{
		UsageReporterWithoutUI.FeatureUsed(2u);
		Type type = exception.GetType();
		if (type.Name == "UnhandledException" && type.Namespace == "SmartAssembly.SmartExceptionsCore")
		{
			exception = (Exception)type.GetField("PreviousException")!.GetValue(exception);
		}
		bool flag = true;
		if (exception == null || exception is ThreadAbortException)
		{
			return;
		}
		try
		{
			ErrorReportSender errorReportSender = new ErrorReportSender(GetUserID(), exception, m_Proxy);
			errorReportSender.SendingReportFeedback += InvokeSendingReportFeedback;
			errorReportSender.DebuggerLaunched += InvokeDebuggerLaunched;
			errorReportSender.FatalException += InvokeOnFatalException;
			ReportExceptionEventArgs reportExceptionEventArgs = new ReportExceptionEventArgs(errorReportSender, exception);
			if (AppPathFinder.ReadInstalledSaPath() != null)
			{
				reportExceptionEventArgs.EnableDebug();
			}
			if (!canContinue)
			{
				reportExceptionEventArgs.SetShowContinueCheckBox(value: false);
				reportExceptionEventArgs.TryToContinue = false;
			}
			else if (manuallyReported || AlwaysContinueOnError)
			{
				reportExceptionEventArgs.SetShowContinueCheckBox(value: false);
				reportExceptionEventArgs.TryToContinue = true;
			}
			OnReportException(reportExceptionEventArgs);
			flag = !reportExceptionEventArgs.TryToContinue;
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception fatalException)
		{
			OnFatalException(new FatalExceptionEventArgs(fatalException));
		}
		if (!flag)
		{
			return;
		}
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			try
			{
				string fullName = assembly.FullName;
				if (fullName.EndsWith("31bf3856ad364e35") && fullName.StartsWith("PresentationFramework,"))
				{
					object obj = assembly.GetType("System.Windows.Application")!.GetProperty("Current")!.GetGetMethod()!.Invoke(null, null);
					obj.GetType().GetMethod("Shutdown", new Type[0])!.Invoke(obj, null);
				}
			}
			catch
			{
			}
		}
		try
		{
			Application.Exit();
		}
		catch
		{
			try
			{
				Environment.Exit(0);
			}
			catch
			{
			}
		}
	}

	private void InvokeOnFatalException(object sender, FatalExceptionEventArgs e)
	{
		OnFatalException(e);
	}

	private void InvokeDebuggerLaunched(object sender, EventArgs e)
	{
		this.DebuggerLaunched?.Invoke(sender, e);
	}

	private void InvokeSendingReportFeedback(object sender, SendingReportFeedbackEventArgs e)
	{
		this.SendingReportFeedback?.Invoke(sender, e);
	}
}
