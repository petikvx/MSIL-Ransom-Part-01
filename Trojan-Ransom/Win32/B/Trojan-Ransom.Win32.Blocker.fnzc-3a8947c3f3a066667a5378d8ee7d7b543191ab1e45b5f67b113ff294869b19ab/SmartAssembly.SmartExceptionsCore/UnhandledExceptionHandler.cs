using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using SmartAssembly.Shared;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public abstract class UnhandledExceptionHandler
{
	public const string ApplicationName = "{1fe9e38e-05cc-46a3-ae48-6cda8fb62056}";

	public const string CompanyName = "{395edd3b-130e-4160-bb08-6931086cea46}";

	private static readonly bool bool_0;

	private static readonly string string_0;

	private static UnhandledExceptionHandler unhandledExceptionHandler_0;

	internal IWebProxy iwebProxy_0;

	internal EventHandler eventHandler_0;

	internal SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler_0;

	public event EventHandler DebuggerLaunched
	{
		add
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Class34.smethod_0(eventHandler2, value, 972, 899);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event SendingReportFeedbackEventHandler SendingReportFeedback
	{
		add
		{
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler_0;
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler2;
			do
			{
				sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
				SendingReportFeedbackEventHandler value2 = (SendingReportFeedbackEventHandler)Class34.smethod_0(sendingReportFeedbackEventHandler2, value, 68, 11);
				sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler_0, value2, sendingReportFeedbackEventHandler2);
			}
			while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
		}
		remove
		{
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler_0;
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler2;
			do
			{
				sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
				SendingReportFeedbackEventHandler value2 = (SendingReportFeedbackEventHandler)Delegate.Remove(sendingReportFeedbackEventHandler2, value);
				sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler_0, value2, sendingReportFeedbackEventHandler2);
			}
			while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
		}
	}

	protected abstract void OnReportException(ReportExceptionEventArgs e);

	protected abstract void OnFatalException(FatalExceptionEventArgs e);

	protected abstract void OnSecurityException(SecurityExceptionEventArgs e);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void AttachExceptionHandler(UnhandledExceptionHandler unhandledExceptionHandler)
	{
		if (unhandledExceptionHandler != null)
		{
			unhandledExceptionHandler_0 = unhandledExceptionHandler;
			Class34.smethod_1(989, 950).UnhandledException += unhandledExceptionHandler.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)unhandledExceptionHandler.method_0);
		}
	}

	[SpecialName]
	private static UnhandledExceptionHandler smethod_0()
	{
		if (unhandledExceptionHandler_0 == null)
		{
			Type[] types = SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(670, 710).GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)ReportExceptionEventArgs.smethod_2(type, 387, 511) == null || (object)ReportExceptionEventArgs.smethod_2(type, 511, 387) != Class26.smethod_1(typeof(UnhandledExceptionHandler).TypeHandle, 438, 402))
				{
					continue;
				}
				try
				{
					unhandledExceptionHandler_0 = (UnhandledExceptionHandler)Activator.CreateInstance(type, nonPublic: true);
					if (unhandledExceptionHandler_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return unhandledExceptionHandler_0;
	}

	public static void EntryPointException(Exception exception, object[] objects)
	{
		if (exception == null || !(exception is SecurityException) || !UsageCounts.smethod_0(string_0, "1", 843, 849) || !smethod_0().method_2((SecurityException)exception))
		{
			StackFrameHelper.CreateExceptionN(exception, objects);
			smethod_0().method_3(exception, bool_1: false, bool_2: false);
		}
	}

	public static Exception ReportWebMethodException(Exception exception, object[] objects)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		try
		{
			if ((object)Class25.smethod_0(exception, 584, 620) == Class26.smethod_1(typeof(Exception).TypeHandle, 731, 767) && UsageCounts.smethod_0(Class26.smethod_0(exception, 712, 646), "{report}", 31, 5))
			{
				exception = Class37.smethod_5(exception, 930, 964);
			}
			else
			{
				StackFrameHelper.CreateExceptionN(exception, objects);
			}
			smethod_0().method_3(exception, bool_1: true, bool_2: false);
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
			if ((object)Class25.smethod_0(exception, 372, 336) == Class26.smethod_1(typeof(Exception).TypeHandle, 174, 138) && UsageCounts.smethod_0(Class26.smethod_0(exception, 598, 536), "{report}", 327, 349))
			{
				exception = Class37.smethod_5(exception, 904, 1006);
			}
			else
			{
				StackFrameHelper.CreateExceptionN(exception, objects);
			}
			smethod_0().method_3(exception, bool_1: true, bool_2: true);
		}
		catch
		{
		}
	}

	private void method_0(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			Exception ex = e.Exception;
			Type type = Class25.smethod_0(ex, 873, 845);
			if (UsageCounts.smethod_0(Win32.smethod_13(type, 395, 461), "UnhandledException", 549, 575) && UsageCounts.smethod_0(type.Namespace, "SmartAssembly.SmartExceptionsCore", 654, 660))
			{
				ex = (Exception)Class31.smethod_2(type, "PreviousException", 249, 160).GetValue(ex);
			}
			if (!(ex is SecurityException) || !(string_0 == "1") || !method_2(ex as SecurityException))
			{
				method_3(ex, bool_1: true, bool_2: false);
			}
		}
		catch
		{
		}
	}

	private void method_1(object sender, UnhandledExceptionEventArgs e)
	{
		try
		{
			if ((!(e.ExceptionObject is SecurityException) || !UsageCounts.smethod_0(string_0, "1", 228, 254) || !method_2(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
			{
				method_3((Exception)e.ExceptionObject, !e.IsTerminating, bool_2: false);
			}
		}
		catch
		{
		}
	}

	public void SetProxy(IWebProxy proxy)
	{
		IWebProxy webProxy = (iwebProxy_0 = proxy);
	}

	protected virtual Guid GetUserID()
	{
		return Guid.Empty;
	}

	private bool method_2(SecurityException securityException_0)
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

	private void method_3(Exception exception_0, bool bool_1, bool bool_2)
	{
		Class37.smethod_0(2u);
		Type type = Class25.smethod_0(exception_0, 652, 680);
		if (UsageCounts.smethod_0(Win32.smethod_13(type, 839, 769), "UnhandledException", 472, 450) && UsageCounts.smethod_0(type.Namespace, "SmartAssembly.SmartExceptionsCore", 11, 17))
		{
			exception_0 = (Exception)Class31.smethod_2(type, "PreviousException", 812, 885).GetValue(exception_0);
		}
		bool flag = true;
		if (exception_0 == null || exception_0 is ThreadAbortException)
		{
			return;
		}
		try
		{
			Class16 @class = new Class16(GetUserID(), exception_0, iwebProxy_0);
			@class.SendingReportFeedback += method_6;
			@class.method_18(method_5);
			@class.method_16(method_4);
			ReportExceptionEventArgs reportExceptionEventArgs = new ReportExceptionEventArgs(@class, exception_0);
			if (AppPathFinder.ReadInstalledSaPath() != null)
			{
				reportExceptionEventArgs.method_1();
			}
			if (!bool_1)
			{
				reportExceptionEventArgs.method_0(bool_4: false);
				reportExceptionEventArgs.TryToContinue = false;
			}
			else if (bool_2 || bool_0)
			{
				reportExceptionEventArgs.method_0(bool_4: false);
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
		Assembly[] assemblies = Class34.smethod_1(557, 582).GetAssemblies();
		foreach (Assembly assembly_ in assemblies)
		{
			try
			{
				string text = Class26.smethod_5(assembly_, 994, 923);
				if (AppNameFinder.smethod_1(text, "31bf3856ad364e35", 684, 710) && UsageCounts.smethod_0(text, "PresentationFramework,", 174, 181))
				{
					object obj = Class22.smethod_0(assembly_, "System.Windows.Application", 475, 390).GetProperty("Current")!.GetGetMethod()!.Invoke(null, null);
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

	private void method_4(object sender, FatalExceptionEventArgs e)
	{
		OnFatalException(e);
	}

	private void method_5(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(sender, e);
	}

	private void method_6(object sender, SendingReportFeedbackEventArgs e)
	{
		sendingReportFeedbackEventHandler_0?.Invoke(sender, e);
	}

	[SecuritySafeCritical]
	static UnhandledExceptionHandler()
	{
		Class32.smethod_1();
		bool_0 = Convert.ToBoolean("False");
		string_0 = "1";
	}
}
