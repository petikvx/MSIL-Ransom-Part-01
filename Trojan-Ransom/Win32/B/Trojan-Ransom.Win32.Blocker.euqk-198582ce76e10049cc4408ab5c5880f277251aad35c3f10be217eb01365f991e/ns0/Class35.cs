using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using ns5;
using ns6;
using ns8;

namespace ns0;

internal abstract class Class35
{
	public const string string_0 = "{1fe9e38e-05cc-46a3-ae48-6cda8fb62056}";

	public const string string_1 = "{395edd3b-130e-4160-bb08-6931086cea46}";

	private static readonly bool bool_0 = Convert.ToBoolean("False");

	private static readonly string string_2 = "1";

	private static Class35 class35_0;

	private IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private Delegate1 delegate1_0;

	private static Class35 Handler
	{
		get
		{
			if (class35_0 == null)
			{
				Type[] types = Assembly.GetExecutingAssembly().GetTypes();
				foreach (Type type in types)
				{
					if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class35))
					{
						continue;
					}
					try
					{
						class35_0 = (Class35)Activator.CreateInstance(type, nonPublic: true);
						if (class35_0 != null)
						{
							break;
						}
					}
					catch
					{
					}
				}
			}
			return class35_0;
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

	public event Delegate1 SendingReportFeedback
	{
		add
		{
			Delegate1 @delegate = delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value2 = (Delegate1)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate1 @delegate = delegate1_0;
			Delegate1 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate1 value2 = (Delegate1)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate1_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	protected abstract void vmethod_0(EventArgs1 eventArgs1_0);

	protected abstract void vmethod_1(EventArgs0 eventArgs0_0);

	protected abstract void vmethod_2(EventArgs2 eventArgs2_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void smethod_0(Class35 class35_1)
	{
		if (class35_1 != null)
		{
			class35_0 = class35_1;
			AppDomain.CurrentDomain.UnhandledException += class35_1.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class35_1.method_0);
		}
	}

	public static void smethod_1(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(string_2 == "1") || !Handler.method_3((SecurityException)exception_0))
		{
			Class32.smethod_11(exception_0, object_0);
			Handler.method_4(exception_0, bool_1: false, bool_2: false);
		}
	}

	public static Exception smethod_2(Exception exception_0, object[] object_0)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == "{report}")
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				Class32.smethod_11(exception_0, object_0);
			}
			Handler.method_4(exception_0, bool_1: true, bool_2: false);
		}
		catch
		{
		}
		return (Exception)new SoapException(exception_0.Message, SoapException.ServerFaultCode);
	}

	public static void smethod_3(Exception exception_0, object[] object_0)
	{
		try
		{
			if ((object)exception_0.GetType() == typeof(Exception) && exception_0.Message == "{report}")
			{
				exception_0 = exception_0.InnerException;
			}
			else
			{
				Class32.smethod_11(exception_0, object_0);
			}
			Handler.method_4(exception_0, bool_1: true, bool_2: true);
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
		iwebProxy_0 = iwebProxy_1;
	}

	protected virtual Guid vmethod_3()
	{
		return Guid.Empty;
	}

	private bool method_3(SecurityException securityException_0)
	{
		EventArgs2 eventArgs = new EventArgs2(securityException_0);
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

	private unsafe void method_4(Exception exception_0, bool bool_1, bool bool_2)
	{
		void* ptr = stackalloc byte[5];
		Type type = exception_0.GetType();
		if (type.Name == "UnhandledException" && type.Namespace == "SmartAssembly.SmartExceptionsCore")
		{
			exception_0 = (Exception)type.GetField("PreviousException")!.GetValue(exception_0);
		}
		((byte*)ptr)[4] = 1;
		if (exception_0 == null || exception_0 is ThreadAbortException)
		{
			return;
		}
		try
		{
			Class26 @class = new Class26(vmethod_3(), exception_0, iwebProxy_0);
			@class.SendingReportFeedback += method_7;
			@class.DebuggerLaunched += method_6;
			@class.FatalException += method_5;
			EventArgs1 eventArgs = new EventArgs1(@class, exception_0);
			if (Class10.smethod_0() != null)
			{
				eventArgs.method_1();
			}
			if (!bool_1)
			{
				eventArgs.method_0(bool_4: false);
				eventArgs.TryToContinue = false;
			}
			else if (bool_2 || bool_0)
			{
				eventArgs.method_0(bool_4: false);
				eventArgs.TryToContinue = true;
			}
			vmethod_0(eventArgs);
			((byte*)ptr)[4] = ((!eventArgs.TryToContinue) ? ((byte)1) : ((byte)0));
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception fatalException)
		{
			vmethod_1(new EventArgs0(fatalException));
		}
		if (((byte*)ptr)[4] == 0)
		{
			return;
		}
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		*(int*)ptr = 0;
		while (*(int*)ptr < assemblies.Length)
		{
			Assembly assembly = assemblies[*(int*)ptr];
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
			(*(int*)ptr)++;
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
		delegate1_0?.Invoke(sender, e);
	}
}
