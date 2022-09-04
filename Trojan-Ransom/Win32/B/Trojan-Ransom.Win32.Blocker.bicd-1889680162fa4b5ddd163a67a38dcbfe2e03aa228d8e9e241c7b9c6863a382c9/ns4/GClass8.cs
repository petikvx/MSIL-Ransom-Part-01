using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using ns1;
using ns2;

namespace ns4;

public abstract class GClass8
{
	public const string string_0 = "{1fe9e38e-05cc-46a3-ae48-6cda8fb62056}";

	public const string string_1 = "{395edd3b-130e-4160-bb08-6931086cea46}";

	private static readonly bool bool_0;

	private static readonly string string_2;

	private static GClass8 gclass8_0;

	internal IWebProxy iwebProxy_0;

	internal EventHandler eventHandler_0;

	internal GDelegate1 gdelegate1_0;

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

	public event GDelegate1 SendingReportFeedback
	{
		add
		{
			GDelegate1 gDelegate = gdelegate1_0;
			GDelegate1 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate1 value2 = (GDelegate1)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate1_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		remove
		{
			GDelegate1 gDelegate = gdelegate1_0;
			GDelegate1 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate1 value2 = (GDelegate1)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate1_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	protected abstract void OnReportException(GEventArgs1 geventArgs1_0);

	protected abstract void OnFatalException(GEventArgs0 geventArgs0_0);

	protected abstract void OnSecurityException(GEventArgs2 geventArgs2_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void smethod_0(GClass8 gclass8_1)
	{
		if (gclass8_1 != null)
		{
			gclass8_0 = gclass8_1;
			AppDomain.CurrentDomain.UnhandledException += gclass8_1.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)gclass8_1.method_0);
		}
	}

	[SpecialName]
	private static GClass8 smethod_1()
	{
		if (gclass8_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(GClass8))
				{
					continue;
				}
				try
				{
					gclass8_0 = (GClass8)Activator.CreateInstance(type, nonPublic: true);
					if (gclass8_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return gclass8_0;
	}

	public static void smethod_2(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(string_2 == "1") || !smethod_1().method_3((SecurityException)exception_0))
		{
			GClass6.smethod_11(exception_0, object_0);
			smethod_1().method_4(exception_0, bool_1: false, bool_2: false);
		}
	}

	public static Exception smethod_3(Exception exception_0, object[] object_0)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == "{report}")
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				GClass6.smethod_11(exception_0, object_0);
			}
			smethod_1().method_4(exception_0, bool_1: true, bool_2: false);
		}
		catch
		{
		}
		return (Exception)new SoapException(exception_0.Message, SoapException.ServerFaultCode);
	}

	public static void smethod_4(Exception exception_0, object[] object_0)
	{
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == "{report}")
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				GClass6.smethod_11(exception_0, object_0);
			}
			smethod_1().method_4(exception_0, bool_1: true, bool_2: true);
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
			if (type.Name == "UnhandledException" && type.Namespace == "SmartAssembly.SmartExceptionsCore")
			{
				ex = (Exception)type.GetField("PreviousException")!.GetValue(ex);
			}
			if (!(ex is SecurityException) || !(string_2 == "1") || !method_3(ex as SecurityException))
			{
				method_4(ex, bool_1: true, bool_2: false);
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
			if ((!(e.ExceptionObject is SecurityException) || !(string_2 == "1") || !method_3(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
			{
				method_4((Exception)e.ExceptionObject, !e.IsTerminating, bool_2: false);
			}
		}
		catch
		{
		}
	}

	public void method_2(IWebProxy iwebProxy_1)
	{
		IWebProxy webProxy = (iwebProxy_0 = iwebProxy_1);
	}

	protected virtual Guid GetUserID()
	{
		return Guid.Empty;
	}

	private bool method_3(SecurityException securityException_0)
	{
		GEventArgs2 gEventArgs = new GEventArgs2(securityException_0);
		OnSecurityException(gEventArgs);
		if (gEventArgs.ReportException)
		{
			return false;
		}
		if (!gEventArgs.TryToContinue)
		{
			Application.Exit();
		}
		return true;
	}

	private void method_4(Exception exception_0, bool bool_1, bool bool_2)
	{
		Class39.smethod_0(2u);
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
			Class18 @class = new Class18(GetUserID(), exception_0, iwebProxy_0);
			@class.SendingReportFeedback += method_7;
			@class.method_22(method_6);
			@class.method_20(method_5);
			GEventArgs1 gEventArgs = new GEventArgs1(@class, exception_0);
			if (GClass1.smethod_0() != null)
			{
				gEventArgs.method_1();
			}
			if (!bool_1)
			{
				gEventArgs.method_0(bool_4: false);
				gEventArgs.TryToContinue = false;
			}
			else if (bool_2 || bool_0)
			{
				gEventArgs.method_0(bool_4: false);
				gEventArgs.TryToContinue = true;
			}
			OnReportException(gEventArgs);
			flag = !gEventArgs.TryToContinue;
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			OnFatalException(new GEventArgs0(exception_));
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

	private void method_5(object sender, GEventArgs0 e)
	{
		OnFatalException(e);
	}

	private void method_6(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(sender, e);
	}

	private void method_7(object sender, GEventArgs3 e)
	{
		gdelegate1_0?.Invoke(sender, e);
	}

	static GClass8()
	{
		GClass11.smethod_0();
		bool_0 = Convert.ToBoolean("False");
		string_2 = "1";
	}
}
