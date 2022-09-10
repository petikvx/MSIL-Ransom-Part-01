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
using SmartAssembly.StringsEncoding;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public abstract class UnhandledExceptionHandler
{
	public const string ApplicationName = "{1fe9e38e-05cc-46a3-ae48-6cda8fb62056}";

	public const string CompanyName = "{395edd3b-130e-4160-bb08-6931086cea46}";

	private static readonly bool bool_0 = Convert.ToBoolean(Strings.Get(3897));

	private static readonly string string_0 = Strings.Get(1713);

	private static UnhandledExceptionHandler unhandledExceptionHandler_0;

	private IWebProxy iwebProxy_0;

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
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
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
				SendingReportFeedbackEventHandler value2 = (SendingReportFeedbackEventHandler)Delegate.Combine(sendingReportFeedbackEventHandler2, value);
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
			AppDomain.CurrentDomain.UnhandledException += unhandledExceptionHandler.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)unhandledExceptionHandler.method_0);
		}
	}

	[SpecialName]
	private static UnhandledExceptionHandler smethod_0()
	{
		if (unhandledExceptionHandler_0 == null)
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
		if (exception == null || !(exception is SecurityException) || !(string_0 == Strings.Get(1713)) || !smethod_0().method_2((SecurityException)exception))
		{
			StackFrameHelper.CreateExceptionN(exception, objects);
			smethod_0().method_3(exception, bool_1: false, bool_2: false);
		}
	}

	public static Exception ReportWebMethodException(Exception exception, object[] objects)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		try
		{
			if ((object)exception.GetType() == typeof(Exception) && exception.Message == Strings.Get(3668))
			{
				exception = exception.InnerException;
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
			if ((object)exception.GetType() == typeof(Exception) && exception.Message == Strings.Get(3668))
			{
				exception = exception.InnerException;
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
			Type type = ex.GetType();
			if (type.Name == Strings.Get(3681) && type.Namespace == Strings.Get(3706))
			{
				ex = (Exception)type.GetField(Strings.Get(3751))!.GetValue(ex);
			}
			if (!(ex is SecurityException) || !(string_0 == Strings.Get(1713)) || !method_2(ex as SecurityException))
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
			if ((!(e.ExceptionObject is SecurityException) || !(string_0 == Strings.Get(1713)) || !method_2(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
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
		iwebProxy_0 = proxy;
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
		Class35.smethod_0(2u);
		Type type = exception_0.GetType();
		if (type.Name == Strings.Get(3681) && type.Namespace == Strings.Get(3706))
		{
			exception_0 = (Exception)type.GetField(Strings.Get(3751))!.GetValue(exception_0);
		}
		bool flag = true;
		if (exception_0 == null || exception_0 is ThreadAbortException)
		{
			return;
		}
		try
		{
			Class14 @class = new Class14(GetUserID(), exception_0, iwebProxy_0);
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
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			try
			{
				string fullName = assembly.FullName;
				if (fullName.EndsWith(Strings.Get(3776)) && fullName.StartsWith(Strings.Get(3801)))
				{
					object obj = assembly.GetType(Strings.Get(3834))!.GetProperty(Strings.Get(3871))!.GetGetMethod()!.Invoke(null, null);
					obj.GetType().GetMethod(Strings.Get(3884), new Type[0])!.Invoke(obj, null);
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
}
