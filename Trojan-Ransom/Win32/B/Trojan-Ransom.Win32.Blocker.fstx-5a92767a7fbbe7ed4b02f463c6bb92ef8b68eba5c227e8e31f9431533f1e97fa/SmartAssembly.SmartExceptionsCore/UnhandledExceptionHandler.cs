using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.Shared;

namespace SmartAssembly.SmartExceptionsCore;

public abstract class UnhandledExceptionHandler
{
	private static readonly bool AlwaysContinueOnError = Convert.ToBoolean("True");

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

	public event EventHandler DebuggerLaunched
	{
		add
		{
			EventHandler eventHandler = this.DebuggerLaunched;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.DebuggerLaunched, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event SendingReportFeedbackEventHandler SendingReportFeedback
	{
		add
		{
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler = this.SendingReportFeedback;
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler2;
			do
			{
				sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
				SendingReportFeedbackEventHandler value2 = (SendingReportFeedbackEventHandler)Delegate.Combine(sendingReportFeedbackEventHandler2, value);
				sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref this.SendingReportFeedback, value2, sendingReportFeedbackEventHandler2);
			}
			while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
		}
	}

	protected abstract void OnReportException(ReportExceptionEventArgs reportExceptionEventArgs_0);

	protected abstract void OnFatalException(FatalExceptionEventArgs fatalExceptionEventArgs_0);

	protected abstract void OnSecurityException(SecurityExceptionEventArgs securityExceptionEventArgs_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void AttachExceptionHandler(UnhandledExceptionHandler unhandledExceptionHandler_0)
	{
		if (unhandledExceptionHandler_0 != null)
		{
			s_Handler = unhandledExceptionHandler_0;
			AppDomain.CurrentDomain.UnhandledException += unhandledExceptionHandler_0.OnUnhandledException;
			Application.add_ThreadException((ThreadExceptionEventHandler)unhandledExceptionHandler_0.OnThreadException);
		}
	}

	public static void EntryPointException(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(SecurityExceptionsHaveSpecialTreatment == "1") || !Handler.InvokeSecurityException((SecurityException)exception_0))
		{
			StackFrameHelper.CreateExceptionN(exception_0, object_0);
			Handler.ReportException(exception_0, bool_0: false, bool_1: false);
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
				ReportException(ex, bool_0: true, bool_1: false);
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
				ReportException((Exception)e.ExceptionObject, !e.IsTerminating, bool_1: false);
			}
		}
		catch
		{
		}
	}

	protected virtual Guid GetUserID()
	{
		return Guid.Empty;
	}

	private bool InvokeSecurityException(SecurityException securityException_0)
	{
		SecurityExceptionEventArgs securityExceptionEventArgs = new SecurityExceptionEventArgs(securityException_0);
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

	private void ReportException(Exception exception_0, bool bool_0, bool bool_1)
	{
		Type type = exception_0.GetType();
		if (type.Name == "UnhandledException" && type.Namespace == "SmartAssembly.SmartExceptionsCore")
		{
			exception_0 = (Exception)type.GetField("PreviousException")!.GetValue(exception_0);
		}
		bool flag = true;
		if (exception_0 == null || exception_0 is ThreadAbortException)
		{
			return;
		}
		try
		{
			ErrorReportSender errorReportSender = new ErrorReportSender(GetUserID(), exception_0, m_Proxy);
			errorReportSender.SendingReportFeedback += InvokeSendingReportFeedback;
			errorReportSender.DebuggerLaunched += InvokeDebuggerLaunched;
			errorReportSender.FatalException += InvokeOnFatalException;
			ReportExceptionEventArgs reportExceptionEventArgs = new ReportExceptionEventArgs(errorReportSender, exception_0);
			if (AppPathFinder.ReadInstalledSaPath() != null)
			{
				reportExceptionEventArgs.EnableDebug();
			}
			if (!bool_0)
			{
				reportExceptionEventArgs.SetShowContinueCheckBox(bool_0: false);
				reportExceptionEventArgs.TryToContinue = false;
			}
			else if (bool_1 || AlwaysContinueOnError)
			{
				reportExceptionEventArgs.SetShowContinueCheckBox(bool_0: false);
				reportExceptionEventArgs.TryToContinue = true;
			}
			OnReportException(reportExceptionEventArgs);
			flag = !reportExceptionEventArgs.TryToContinue;
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			OnFatalException(new FatalExceptionEventArgs(exception_));
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
			Environment.ExitCode = -532462766;
			Application.Exit();
		}
		catch
		{
			try
			{
				Environment.Exit(-532462766);
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
