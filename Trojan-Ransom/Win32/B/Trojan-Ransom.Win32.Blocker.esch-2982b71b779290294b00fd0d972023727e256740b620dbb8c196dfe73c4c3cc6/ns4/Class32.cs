using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using ns1;
using ns10;
using ns2;
using ns5;
using ns9;

namespace ns4;

internal abstract class Class32
{
	public const string string_0 = "{1fe9e38e-05cc-46a3-ae48-6cda8fb62056}";

	public const string string_1 = "{395edd3b-130e-4160-bb08-6931086cea46}";

	private static readonly bool bool_0 = Convert.ToBoolean("False");

	private static readonly string string_2 = "1";

	private static Class32 class32_0;

	private IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private Delegate2 delegate2_0;

	private static Class32 Handler
	{
		get
		{
			if (class32_0 == null)
			{
				Type[] types = Assembly.GetExecutingAssembly().GetTypes();
				foreach (Type type in types)
				{
					if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class32))
					{
						continue;
					}
					try
					{
						class32_0 = (Class32)Activator.CreateInstance(type, nonPublic: true);
						if (class32_0 != null)
						{
							break;
						}
					}
					catch
					{
					}
				}
			}
			return class32_0;
		}
	}

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

	public event Delegate2 SendingReportFeedback
	{
		add
		{
			Delegate2 @delegate = delegate2_0;
			Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate2 value2 = (Delegate2)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate2_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate2 @delegate = delegate2_0;
			Delegate2 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate2 value2 = (Delegate2)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate2_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	protected abstract void vmethod_0(EventArgs1 e);

	protected abstract void vmethod_1(EventArgs0 e);

	protected abstract void vmethod_2(EventArgs2 e);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void smethod_0(Class32 unhandledExceptionHandler)
	{
		if (unhandledExceptionHandler != null)
		{
			class32_0 = unhandledExceptionHandler;
			AppDomain.CurrentDomain.UnhandledException += unhandledExceptionHandler.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)unhandledExceptionHandler.method_0);
		}
	}

	public static void smethod_1(Exception exception, object[] objects)
	{
		if (exception == null || !(exception is SecurityException) || !(string_2 == "1") || !Handler.method_3((SecurityException)exception))
		{
			Class29.smethod_11(exception, objects);
			Handler.method_4(exception, canContinue: false, manuallyReported: false);
		}
	}

	public static Exception smethod_2(Exception exception, object[] objects)
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
				Class29.smethod_11(exception, objects);
			}
			Handler.method_4(exception, canContinue: true, manuallyReported: false);
		}
		catch
		{
		}
		return (Exception)new SoapException(exception.Message, SoapException.ServerFaultCode);
	}

	public static void smethod_3(Exception exception, object[] objects)
	{
		try
		{
			if ((object)exception.GetType() == typeof(Exception) && exception.Message == "{report}")
			{
				exception = exception.InnerException;
			}
			else
			{
				Class29.smethod_11(exception, objects);
			}
			Handler.method_4(exception, canContinue: true, manuallyReported: true);
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
				method_4(ex, canContinue: true, manuallyReported: false);
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
				method_4((Exception)e.ExceptionObject, !e.IsTerminating, manuallyReported: false);
			}
		}
		catch
		{
		}
	}

	public void method_2(IWebProxy proxy)
	{
		iwebProxy_0 = proxy;
	}

	protected virtual Guid vmethod_3()
	{
		return Guid.Empty;
	}

	private bool method_3(SecurityException exception)
	{
		EventArgs2 eventArgs = new EventArgs2(exception);
		vmethod_2(eventArgs);
		if (eventArgs.ReportException)
		{
			return false;
		}
		if (!eventArgs.TryToContinue)
		{
			Application.Exit();
		}
		return true;
	}

	[Attribute9("Unhandled Exception Encountered")]
	private void method_4(Exception exception, bool canContinue, bool manuallyReported)
	{
		Class52.smethod_0(2u);
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
			Class23 @class = new Class23(vmethod_3(), exception, iwebProxy_0);
			@class.SendingReportFeedback += method_7;
			@class.DebuggerLaunched += method_6;
			@class.FatalException += method_5;
			EventArgs1 eventArgs = new EventArgs1(@class, exception);
			if (Class4.smethod_0() != null)
			{
				eventArgs.method_1();
			}
			if (!canContinue)
			{
				eventArgs.method_0(value: false);
				eventArgs.TryToContinue = false;
			}
			else if (manuallyReported || bool_0)
			{
				eventArgs.method_0(value: false);
				eventArgs.TryToContinue = true;
			}
			vmethod_0(eventArgs);
			flag = !eventArgs.TryToContinue;
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception fatalException)
		{
			vmethod_1(new EventArgs0(fatalException));
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

	private void method_5(object sender, EventArgs0 e)
	{
		vmethod_1(e);
	}

	private void method_6(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(sender, e);
	}

	private void method_7(object sender, EventArgs3 e)
	{
		delegate2_0?.Invoke(sender, e);
	}
}
