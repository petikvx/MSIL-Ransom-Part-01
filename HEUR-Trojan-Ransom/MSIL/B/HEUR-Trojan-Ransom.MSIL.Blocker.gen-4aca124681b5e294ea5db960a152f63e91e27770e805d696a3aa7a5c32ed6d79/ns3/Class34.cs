using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns1;
using ns10;
using ns11;
using ns2;
using ns6;
using ns7;
using ns8;

namespace ns3;

internal abstract class Class34
{
	private static readonly bool bool_0;

	private static readonly string string_0;

	private static Class34 class34_0;

	private IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private Delegate2 delegate2_0;

	[NonSerialized]
	internal static GetString getString_0;

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
	public void method_1(Delegate2 delegate2_1)
	{
		Delegate2 @delegate = delegate2_0;
		Delegate2 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate2 value = (Delegate2)Delegate.Combine(delegate2, delegate2_1);
			@delegate = Interlocked.CompareExchange(ref delegate2_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	protected abstract void vmethod_0(EventArgs2 eventArgs2_0);

	protected abstract void vmethod_1(EventArgs1 eventArgs1_0);

	protected abstract void vmethod_2(EventArgs3 eventArgs3_0);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void smethod_0(Class34 class34_1)
	{
		if (class34_1 != null)
		{
			class34_0 = class34_1;
			AppDomain.CurrentDomain.UnhandledException += class34_1.method_3;
			Application.add_ThreadException((ThreadExceptionEventHandler)class34_1.method_2);
		}
	}

	[SpecialName]
	private static Class34 smethod_1()
	{
		if (class34_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class34))
				{
					continue;
				}
				try
				{
					class34_0 = (Class34)Activator.CreateInstance(type, nonPublic: true);
					if (class34_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return class34_0;
	}

	public static void smethod_2(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(string_0 == getString_0(107397168)) || !smethod_1().method_4((SecurityException)exception_0))
		{
			Class33.smethod_11(exception_0, object_0);
			smethod_1().method_5(exception_0, bool_1: false, bool_2: false);
		}
	}

	private void method_2(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			Exception ex = e.Exception;
			Type type = ex.GetType();
			if (type.Name == getString_0(107387871) && type.Namespace == getString_0(107387846))
			{
				ex = (Exception)type.GetField(getString_0(107387769))!.GetValue(ex);
			}
			if (!(ex is SecurityException) || !(string_0 == getString_0(107397168)) || !method_4(ex as SecurityException))
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
			if ((!(e.ExceptionObject is SecurityException) || !(string_0 == getString_0(107397168)) || !method_4(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
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

	private unsafe void method_5(Exception exception_0, bool bool_1, bool bool_2)
	{
		void* ptr = stackalloc byte[5];
		Class46.smethod_0(2u);
		Type type = exception_0.GetType();
		if (type.Name == getString_0(107387871) && type.Namespace == getString_0(107387846))
		{
			exception_0 = (Exception)type.GetField(getString_0(107387769))!.GetValue(exception_0);
		}
		((byte*)ptr)[4] = 1;
		if (exception_0 == null || exception_0 is ThreadAbortException)
		{
			return;
		}
		try
		{
			Class27 @class = new Class27(vmethod_3(), exception_0, iwebProxy_0);
			@class.method_2(method_8);
			@class.method_20(method_7);
			@class.method_18(method_6);
			EventArgs2 eventArgs = new EventArgs2(@class, exception_0);
			if (Class4.smethod_0() != null)
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
			((byte*)ptr)[4] = ((!eventArgs.method_6()) ? ((byte)1) : ((byte)0));
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			vmethod_1(new EventArgs1(exception_));
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
				if (fullName.EndsWith(getString_0(107387776)) && fullName.StartsWith(getString_0(107387751)))
				{
					object obj = assembly.GetType(getString_0(107387718))!.GetProperty(getString_0(107387681))!.GetGetMethod()!.Invoke(null, null);
					obj.GetType().GetMethod(getString_0(107388148), new Type[0])!.Invoke(obj, null);
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
		delegate2_0?.Invoke(sender, e);
	}

	static Class34()
	{
		Strings.CreateGetStringDelegate(typeof(Class34));
		bool_0 = Convert.ToBoolean(getString_0(107388167));
		string_0 = getString_0(107397168);
	}
}
