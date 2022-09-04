using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using ns2;
using ns3;
using ns5;
using ns7;
using ns9;

namespace ns10;

internal abstract class Class40
{
	private static readonly bool bool_0 = Convert.ToBoolean(Class15.smethod_0(952331));

	private static readonly string string_0 = Class15.smethod_0(950194);

	private static Class40 class40_0;

	private IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private Delegate9 delegate9_0;

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
	public void method_1(Delegate9 delegate9_1)
	{
		Delegate9 @delegate = delegate9_0;
		Delegate9 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate9 value = (Delegate9)Delegate.Combine(delegate2, delegate9_1);
			@delegate = Interlocked.CompareExchange(ref delegate9_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	protected abstract void vmethod_0(EventArgs1 eventArgs1_0);

	protected abstract void vmethod_1(EventArgs0 eventArgs0_0);

	protected abstract void vmethod_2(EventArgs2 eventArgs2_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void smethod_0(Class40 class40_1)
	{
		if (class40_1 != null)
		{
			class40_0 = class40_1;
			AppDomain.CurrentDomain.UnhandledException += class40_1.method_3;
			Application.add_ThreadException((ThreadExceptionEventHandler)class40_1.method_2);
		}
	}

	[SpecialName]
	private static Class40 smethod_1()
	{
		if (class40_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class40))
				{
					continue;
				}
				try
				{
					class40_0 = (Class40)Activator.CreateInstance(type, nonPublic: true);
					if (class40_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return class40_0;
	}

	public static void smethod_2(object object_0, object[] object_1)
	{
		if (object_0 == null || !(object_0 is SecurityException) || !(string_0 == Class15.smethod_0(950194)) || !smethod_1().method_4((SecurityException)object_0))
		{
			Class38.smethod_11((Exception)object_0, object_1);
			smethod_1().method_5((Exception)object_0, bool_1: false, bool_2: false);
		}
	}

	private void method_2(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			Exception ex = e.Exception;
			Type type = ex.GetType();
			if (type.Name == Class15.smethod_0(952115) && type.Namespace == Class15.smethod_0(952140))
			{
				ex = (Exception)type.GetField(Class15.smethod_0(952185))!.GetValue(ex);
			}
			if (!(ex is SecurityException) || !(string_0 == Class15.smethod_0(950194)) || !method_4(ex as SecurityException))
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
			if ((!(e.ExceptionObject is SecurityException) || !(string_0 == Class15.smethod_0(950194)) || !method_4(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
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
		Class59.smethod_0(2u);
		Type type = exception_0.GetType();
		if (type.Name == Class15.smethod_0(952115) && type.Namespace == Class15.smethod_0(952140))
		{
			exception_0 = (Exception)type.GetField(Class15.smethod_0(952185))!.GetValue(exception_0);
		}
		bool flag = true;
		if (exception_0 == null || exception_0 is ThreadAbortException)
		{
			return;
		}
		try
		{
			Class32 @class = new Class32(vmethod_3(), exception_0, iwebProxy_0);
			@class.method_2(method_8);
			@class.method_20(method_7);
			@class.method_18(method_6);
			EventArgs1 eventArgs = new EventArgs1(@class, exception_0);
			if (Class13.smethod_0() != null)
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
				if (fullName.EndsWith(Class15.smethod_0(952210)) && fullName.StartsWith(Class15.smethod_0(952235)))
				{
					object obj = assembly.GetType(Class15.smethod_0(952268))!.GetProperty(Class15.smethod_0(952305))!.GetGetMethod()!.Invoke(null, null);
					obj.GetType().GetMethod(Class15.smethod_0(952318), new Type[0])!.Invoke(obj, null);
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
		delegate9_0?.Invoke(sender, e);
	}
}
