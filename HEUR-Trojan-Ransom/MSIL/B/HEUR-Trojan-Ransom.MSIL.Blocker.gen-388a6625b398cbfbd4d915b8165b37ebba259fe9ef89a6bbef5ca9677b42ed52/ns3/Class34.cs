using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ns0;
using ns4;
using ns5;
using ns6;
using ns8;

namespace ns3;

internal abstract class Class34
{
	private static readonly bool bool_0 = Convert.ToBoolean("False");

	internal static readonly string string_0 = "1";

	internal static Class34 class34_0;

	private IWebProxy iwebProxy_0;

	internal EventHandler eventHandler_0;

	internal Delegate1 delegate1_0;

	protected abstract void vmethod_0(EventArgs1 eventArgs1_0);

	protected abstract void vmethod_1(EventArgs0 eventArgs0_0);

	protected abstract void vmethod_2(EventArgs2 eventArgs2_0);

	internal void method_0(object sender, ThreadExceptionEventArgs e)
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

	internal void method_1(object sender, UnhandledExceptionEventArgs e)
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

	internal bool method_2(SecurityException securityException_0)
	{
		EventArgs2 eventArgs = new EventArgs2(securityException_0);
		vmethod_2(eventArgs);
		if (eventArgs.bool_1)
		{
			return false;
		}
		if (!eventArgs.bool_0)
		{
			Application.Exit();
		}
		return true;
	}

	internal void method_3(Exception exception_0, bool bool_1, bool bool_2)
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
			Class26 @class = new Class26(vmethod_3(), exception_0, iwebProxy_0);
			Class3.smethod_85((Class25)@class, (Delegate1)method_6);
			Class3.smethod_49((EventHandler)method_5, @class);
			Class3.smethod_160((Delegate0)method_4, @class);
			EventArgs1 eventArgs = new EventArgs1(@class, exception_0);
			if (Class3.smethod_133() != null)
			{
				eventArgs.bool_0 = true;
			}
			if (!bool_1)
			{
				eventArgs.bool_2 = false;
				eventArgs.bool_3 = false;
			}
			else if (bool_2 || bool_0)
			{
				eventArgs.bool_2 = false;
				eventArgs.bool_3 = true;
			}
			vmethod_0(eventArgs);
			flag = !eventArgs.bool_3;
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
