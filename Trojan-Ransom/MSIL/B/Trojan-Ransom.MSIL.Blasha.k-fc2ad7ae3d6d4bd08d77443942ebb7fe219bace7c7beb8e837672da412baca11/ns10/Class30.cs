using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using ns7;

namespace ns10;

internal abstract class Class30
{
	private static readonly bool bool_0 = Convert.ToBoolean("True");

	private static readonly string string_0 = "1";

	private static Class30 class30_0;

	private IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private Delegate1 delegate1_0;

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
	public void method_1(Delegate1 delegate1_1)
	{
		Delegate1 @delegate = delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_1);
			@delegate = Interlocked.CompareExchange(ref delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	protected abstract void vmethod_0(EventArgs1 eventArgs1_0);

	protected abstract void vmethod_1(EventArgs0 eventArgs0_0);

	protected abstract void vmethod_2(EventArgs2 eventArgs2_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void smethod_0(Class30 class30_1)
	{
		if (class30_1 != null)
		{
			class30_0 = class30_1;
			AppDomain.CurrentDomain.UnhandledException += class30_1.method_3;
			Application.add_ThreadException((ThreadExceptionEventHandler)class30_1.method_2);
		}
	}

	[SpecialName]
	private static Class30 smethod_1()
	{
		if (class30_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class30))
				{
					continue;
				}
				try
				{
					class30_0 = (Class30)Activator.CreateInstance(type, nonPublic: true);
					if (class30_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return class30_0;
	}

	public static void smethod_2(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(string_0 == "1") || !smethod_1().method_4((SecurityException)exception_0))
		{
			Class28.smethod_11(exception_0, object_0);
			smethod_1().method_5(exception_0, bool_1: false, bool_2: false);
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
				method_5(ex, bool_1: true, bool_2: false);
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
				method_5((Exception)e.ExceptionObject, !e.IsTerminating, bool_2: false);
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
		EventArgs2 eventArgs = new EventArgs2(securityException_0);
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

	private void method_5(Exception exception_0, bool bool_1, bool bool_2)
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
			Class22 @class = new Class22(vmethod_3(), exception_0, iwebProxy_0);
			@class.method_2(method_8);
			@class.method_20(method_7);
			@class.method_18(method_6);
			EventArgs1 eventArgs = new EventArgs1(@class, exception_0);
			if (Class6.smethod_0() != null)
			{
				eventArgs.method_5();
			}
			if (!bool_1)
			{
				eventArgs.method_4(bool_4: false);
				eventArgs.method_7(bool_4: false);
			}
			else if (bool_2 || bool_0)
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
			vmethod_1(new EventArgs0(exception_));
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

	private void method_6(object sender, EventArgs0 e)
	{
		vmethod_1(e);
	}

	private void method_7(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(sender, e);
	}

	private void method_8(object sender, EventArgs3 e)
	{
		delegate1_0?.Invoke(sender, e);
	}
}
