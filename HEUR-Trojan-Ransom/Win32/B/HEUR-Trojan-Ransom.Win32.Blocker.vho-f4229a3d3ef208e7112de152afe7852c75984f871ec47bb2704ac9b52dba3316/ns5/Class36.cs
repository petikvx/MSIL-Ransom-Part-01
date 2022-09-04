using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ns0;
using ns2;
using ns3;
using ns6;
using ns7;
using ns8;

namespace ns5;

internal abstract class Class36
{
	private static readonly bool bool_0 = Convert.ToBoolean("True");

	internal static readonly string string_0 = "1";

	internal static Class36 class36_0;

	private IWebProxy iwebProxy_0;

	internal EventHandler eventHandler_0;

	internal Delegate2 delegate2_0;

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

	internal unsafe void method_3(Exception exception_0, bool bool_1, bool bool_2)
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
			Class28 @class = new Class28(vmethod_3(), exception_0, iwebProxy_0);
			Class24.smethod_138((Class27)@class, (Delegate2)method_6);
			Class24.smethod_12((EventHandler)method_5, @class);
			Class24.smethod_65(@class, (Delegate1)method_4);
			EventArgs1 eventArgs = new EventArgs1(@class, exception_0);
			if (Class24.smethod_72() != null)
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
			((byte*)ptr)[4] = ((!eventArgs.bool_3) ? ((byte)1) : ((byte)0));
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			vmethod_1(new EventArgs0(exception_));
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
		delegate2_0?.Invoke(sender, e);
	}
}
