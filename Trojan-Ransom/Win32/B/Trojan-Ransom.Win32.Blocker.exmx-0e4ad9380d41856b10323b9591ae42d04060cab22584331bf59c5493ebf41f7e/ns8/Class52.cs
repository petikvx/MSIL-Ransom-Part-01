using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using ns3;
using ns5;
using ns6;
using ns7;

namespace ns8;

internal abstract class Class52
{
	private static readonly bool bool_0 = Convert.ToBoolean("True");

	private static readonly string string_0 = "1";

	private static Class52 class52_0;

	private IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private Delegate3 delegate3_0;

	[SpecialName]
	public void method_0(EventHandler eventHandler_1)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	public void method_1(Delegate3 delegate3_1)
	{
		Delegate3 @delegate = delegate3_0;
		Delegate3 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate3 value = (Delegate3)Delegate.Combine(delegate2, delegate3_1);
			@delegate = Interlocked.CompareExchange(ref delegate3_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	protected abstract void vmethod_0(EventArgs2 eventArgs2_0);

	protected abstract void vmethod_1(EventArgs1 eventArgs1_0);

	protected abstract void vmethod_2(EventArgs3 eventArgs3_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void smethod_0(Class52 class52_1)
	{
		if (class52_1 != null)
		{
			class52_0 = class52_1;
			AppDomain.CurrentDomain.UnhandledException += class52_1.method_3;
			Application.add_ThreadException((ThreadExceptionEventHandler)class52_1.method_2);
		}
	}

	[SpecialName]
	private static Class52 smethod_1()
	{
		if (class52_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class52))
				{
					continue;
				}
				try
				{
					class52_0 = (Class52)Activator.CreateInstance(type, nonPublic: true);
					if (class52_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return class52_0;
	}

	public static void smethod_2(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(string_0 == "1") || !smethod_1().method_4((SecurityException)exception_0))
		{
			Class50.smethod_11(exception_0, object_0);
			smethod_1().method_5(exception_0, bool_1: false);
		}
	}

	public static Exception smethod_3(Exception exception_0, object[] object_0)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		smethod_4(exception_0, object_0);
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
				Class50.smethod_11(exception_0, object_0);
			}
			smethod_1().method_5(exception_0, bool_1: true);
		}
		catch
		{
		}
	}

	private void method_2(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			Exception ex = e.Exception;
			Type type = ex.GetType();
			if (type.Name == "UnhandledException" && type.Namespace == "SmartAssembly.SmartExceptionsCore")
			{
				ex = (Exception)type.GetField("PreviousException")!.GetValue(ex);
			}
			if (!(ex is SecurityException) || !(string_0 == "1") || !method_4(ex as SecurityException))
			{
				method_5(ex, bool_1: true);
			}
		}
		catch
		{
		}
	}

	private void method_3(object sender, UnhandledExceptionEventArgs e)
	{
		try
		{
			if ((!(e.ExceptionObject is SecurityException) || !(string_0 == "1") || !method_4(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
			{
				method_5((Exception)e.ExceptionObject, !e.IsTerminating);
			}
		}
		catch
		{
		}
	}

	protected virtual Guid vmethod_3()
	{
		return Guid.Empty;
	}

	private bool method_4(SecurityException securityException_0)
	{
		EventArgs3 eventArgs = new EventArgs3(securityException_0);
		vmethod_2(eventArgs);
		if (eventArgs.method_5())
		{
			return false;
		}
		if (!eventArgs.method_3())
		{
			Application.Exit();
		}
		return true;
	}

	private void method_5(Exception exception_0, bool bool_1)
	{
		Class22.smethod_0(2u);
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
			Class44 @class = new Class44(vmethod_3(), exception_0, iwebProxy_0);
			@class.method_2(method_8);
			@class.method_20(method_7);
			@class.method_18(method_6);
			EventArgs2 eventArgs = new EventArgs2(@class, exception_0);
			if (Class40.smethod_0() != null)
			{
				eventArgs.method_5();
			}
			if (!bool_1)
			{
				eventArgs.method_4(bool_4: false);
				eventArgs.method_7(bool_4: false);
			}
			else if (bool_0)
			{
				eventArgs.method_4(bool_4: false);
				eventArgs.method_7(bool_4: true);
			}
			vmethod_0(eventArgs);
			flag = !eventArgs.method_6();
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			vmethod_1(new EventArgs1(exception_));
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

	private void method_6(object sender, EventArgs1 e)
	{
		vmethod_1(e);
	}

	private void method_7(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(sender, e);
	}

	private void method_8(object sender, EventArgs4 e)
	{
		delegate3_0?.Invoke(sender, e);
	}
}
