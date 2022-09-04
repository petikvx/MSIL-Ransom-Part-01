using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using ns0;
using ns1;
using ns5;
using ns6;
using ns8;

namespace ns2;

internal abstract class Class27
{
	private static readonly bool bool_0 = Convert.ToBoolean("False");

	private static readonly string string_0 = "1";

	private static Class27 class27_0;

	private IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private Delegate1 delegate1_0;

	protected abstract void vmethod_0(EventArgs1 eventArgs1_0);

	protected abstract void vmethod_1(EventArgs0 eventArgs0_0);

	protected abstract void vmethod_2(EventArgs2 eventArgs2_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void smethod_0(Class27 class27_1)
	{
		if (class27_1 != null)
		{
			class27_0 = class27_1;
			AppDomain.CurrentDomain.UnhandledException += class27_1.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class27_1.method_0);
		}
	}

	[SpecialName]
	private static Class27 smethod_1()
	{
		if (class27_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class27))
				{
					continue;
				}
				try
				{
					class27_0 = (Class27)Activator.CreateInstance(type, nonPublic: true);
					if (class27_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return class27_0;
	}

	public static void smethod_2(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(string_0 == "1") || !smethod_1().method_2((SecurityException)exception_0))
		{
			Class26.smethod_11(exception_0, object_0);
			smethod_1().method_3(exception_0, bool_1: false, bool_2: false);
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
			if ((!(e.ExceptionObject is SecurityException) || !(string_0 == "1") || !method_2(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
			{
				method_3((Exception)e.ExceptionObject, !e.IsTerminating, bool_2: false);
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

	private bool method_2(SecurityException securityException_0)
	{
		EventArgs2 eventArgs = new EventArgs2(securityException_0);
		vmethod_2(eventArgs);
		if (eventArgs.method_1())
		{
			return false;
		}
		if (!eventArgs.method_0())
		{
			Application.Exit();
		}
		return true;
	}

	private void method_3(Exception exception_0, bool bool_1, bool bool_2)
	{
		Class46.smethod_0(2u);
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
			Class21 @class = new Class21(vmethod_3(), exception_0, iwebProxy_0);
			@class.method_2(method_6);
			@class.method_20(method_5);
			@class.method_18(method_4);
			EventArgs1 eventArgs = new EventArgs1(@class, exception_0);
			if (Class3.smethod_0() != null)
			{
				eventArgs.method_1();
			}
			if (!bool_1)
			{
				eventArgs.method_0(bool_4: false);
				eventArgs.method_3(bool_4: false);
			}
			else if (bool_2 || bool_0)
			{
				eventArgs.method_0(bool_4: false);
				eventArgs.method_3(bool_4: true);
			}
			vmethod_0(eventArgs);
			flag = !eventArgs.method_2();
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

	private void method_4(object sender, EventArgs0 e)
	{
		vmethod_1(e);
	}

	private void method_5(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(sender, e);
	}

	private void method_6(object sender, EventArgs3 e)
	{
		delegate1_0?.Invoke(sender, e);
	}
}
