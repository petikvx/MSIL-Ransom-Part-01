using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns0;
using ns1;

namespace SmartAssembly.SmartExceptionsCore;

public abstract class UnhandledExceptionHandler
{
	[NonSerialized]
	internal static GetString getString_0;

	private static readonly bool bool_0;

	private static readonly string string_0;

	private static UnhandledExceptionHandler unhandledExceptionHandler_0;

	private IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler_0;

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
	}

	protected abstract void OnReportException(ReportExceptionEventArgs reportExceptionEventArgs_0);

	protected abstract void OnFatalException(FatalExceptionEventArgs fatalExceptionEventArgs_0);

	protected abstract void OnSecurityException(SecurityExceptionEventArgs securityExceptionEventArgs_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void AttachExceptionHandler(UnhandledExceptionHandler unhandledExceptionHandler_1)
	{
		if (unhandledExceptionHandler_1 != null)
		{
			unhandledExceptionHandler_0 = unhandledExceptionHandler_1;
			AppDomain.CurrentDomain.UnhandledException += unhandledExceptionHandler_1.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)unhandledExceptionHandler_1.method_0);
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

	public static void EntryPointException(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(string_0 == getString_0(1529)) || !smethod_0().method_2((SecurityException)exception_0))
		{
			StackFrameHelper.CreateExceptionN(exception_0, object_0);
			smethod_0().method_3(exception_0, bool_1: false);
		}
	}

	public static Exception ReportWebMethodException(Exception exception_0, object[] object_0)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		ReportException(exception_0, object_0);
		return (Exception)new SoapException(exception_0.Message, SoapException.ServerFaultCode);
	}

	public static void ReportException(Exception exception_0, object[] object_0)
	{
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == getString_0(3587))
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				StackFrameHelper.CreateExceptionN(exception_0, object_0);
			}
			smethod_0().method_3(exception_0, bool_1: true);
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
			if (type.Name == getString_0(3600) && type.Namespace == getString_0(3625))
			{
				ex = (Exception)type.GetField(getString_0(3670))!.GetValue(ex);
			}
			if (!(ex is SecurityException) || !(string_0 == getString_0(1529)) || !method_2(ex as SecurityException))
			{
				method_3(ex, bool_1: true);
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
			if ((!(e.ExceptionObject is SecurityException) || !(string_0 == getString_0(1529)) || !method_2(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
			{
				method_3((Exception)e.ExceptionObject, !e.IsTerminating);
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

	private void method_3(Exception exception_0, bool bool_1)
	{
		Type type = exception_0.GetType();
		if (type.Name == getString_0(3600) && type.Namespace == getString_0(3625))
		{
			exception_0 = (Exception)type.GetField(getString_0(3670))!.GetValue(exception_0);
		}
		bool flag = true;
		if (exception_0 == null || exception_0 is ThreadAbortException)
		{
			return;
		}
		try
		{
			Class7 @class = new Class7(GetUserID(), exception_0, iwebProxy_0);
			@class.SendingReportFeedback += method_6;
			@class.method_15(method_5);
			@class.method_13(method_4);
			ReportExceptionEventArgs reportExceptionEventArgs = new ReportExceptionEventArgs(@class, exception_0);
			if (Class4.smethod_0() != null)
			{
				reportExceptionEventArgs.method_1();
			}
			if (!bool_1)
			{
				reportExceptionEventArgs.method_0(bool_4: false);
				reportExceptionEventArgs.TryToContinue = false;
			}
			else if (bool_0)
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
				if (fullName.EndsWith(getString_0(3695)) && fullName.StartsWith(getString_0(3720)))
				{
					object obj = assembly.GetType(getString_0(3753))!.GetProperty(getString_0(3790))!.GetGetMethod()!.Invoke(null, null);
					obj.GetType().GetMethod(getString_0(3803), new Type[0])!.Invoke(obj, null);
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

	static UnhandledExceptionHandler()
	{
		Strings.CreateGetStringDelegate(typeof(UnhandledExceptionHandler));
		bool_0 = Convert.ToBoolean(getString_0(3816));
		string_0 = getString_0(1529);
	}
}
