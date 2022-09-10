using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ns10;

namespace ns12;

internal abstract class Class56
{
	private static readonly bool bool_0 = Convert.ToBoolean(Class32.smethod_0(6954));

	internal static readonly string string_0 = Class32.smethod_0(871);

	internal static Class56 class56_0;

	internal IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private Delegate20 delegate20_0;

	internal static Class56 Handler
	{
		get
		{
			if (class56_0 == null)
			{
				Type[] types = Assembly.GetExecutingAssembly().GetTypes();
				foreach (Type type in types)
				{
					if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class56))
					{
						continue;
					}
					try
					{
						class56_0 = (Class56)Activator.CreateInstance(type, nonPublic: true);
						if (class56_0 != null)
						{
							break;
						}
					}
					catch
					{
					}
				}
			}
			return class56_0;
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

	public event Delegate20 SendingReportFeedback
	{
		add
		{
			Delegate20 @delegate = delegate20_0;
			Delegate20 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate20 value2 = (Delegate20)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate20_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate20 @delegate = delegate20_0;
			Delegate20 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate20 value2 = (Delegate20)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate20_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	protected abstract void vmethod_0(EventArgs1 eventArgs1_0);

	protected abstract void vmethod_1(EventArgs0 eventArgs0_0);

	protected abstract void vmethod_2(EventArgs2 eventArgs2_0);

	internal void method_0(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			Exception ex = e.Exception;
			Type type = ex.GetType();
			if (type.Name == Class32.smethod_0(6738) && type.Namespace == Class32.smethod_0(6763))
			{
				ex = (Exception)type.GetField(Class32.smethod_0(6808))!.GetValue(ex);
			}
			if (!(ex is SecurityException) || !(string_0 == Class32.smethod_0(871)) || !method_2(ex as SecurityException))
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
			if ((!(e.ExceptionObject is SecurityException) || !(string_0 == Class32.smethod_0(871)) || !method_2(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
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
		while (true)
		{
			EventArgs2 eventArgs = new EventArgs2(securityException_0);
			if (yae4s0RJuALtufmd4Ad())
			{
				break;
			}
			switch (3)
			{
			case 0:
			case 4:
				continue;
			case 3:
				vmethod_2(eventArgs);
				goto case 2;
			case 2:
			case 5:
				if (!eventArgs.bool_1)
				{
					if (!eventArgs.bool_0)
					{
						Application.Exit();
					}
					break;
				}
				goto default;
			default:
				return false;
			case 6:
				break;
			}
			break;
		}
		return true;
	}

	internal void method_3(Exception exception_0, bool bool_1, bool bool_2)
	{
		bool flag = default(bool);
		while (true)
		{
			Type type = exception_0.GetType();
			if (yae4s0RJuALtufmd4Ad())
			{
			}
			switch (5)
			{
			case 3:
				break;
			case 5:
				if (type.Name == Class32.smethod_0(6738) && type.Namespace == Class32.smethod_0(6763))
				{
					exception_0 = (Exception)type.GetField(Class32.smethod_0(6808))!.GetValue(exception_0);
				}
				goto case 0;
			case 0:
			case 2:
				flag = true;
				goto default;
			default:
			{
				if (exception_0 == null || exception_0 is ThreadAbortException)
				{
					return;
				}
				try
				{
					Class47 @class = new Class47(vmethod_3(), exception_0, iwebProxy_0);
					@class.SendingReportFeedback += method_6;
					@class.DebuggerLaunched += method_5;
					@class.FatalException += method_4;
					EventArgs1 eventArgs = new EventArgs1(@class, exception_0);
					if (Class12.smethod_7() != null)
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
						if (fullName.EndsWith(Class32.smethod_0(6833)) && fullName.StartsWith(Class32.smethod_0(6858)))
						{
							object obj = assembly.GetType(Class32.smethod_0(6891))!.GetProperty(Class32.smethod_0(6928))!.GetGetMethod()!.Invoke(null, null);
							obj.GetType().GetMethod(Class32.smethod_0(6941), new Type[0])!.Invoke(obj, null);
						}
					}
					catch
					{
					}
				}
				goto case 7;
			}
			case 1:
			case 4:
				return;
			case 7:
				try
				{
					Environment.ExitCode = -532462766;
					Application.Exit();
					return;
				}
				catch
				{
					try
					{
						Environment.Exit(-532462766);
						return;
					}
					catch
					{
						return;
					}
				}
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
		delegate20_0?.Invoke(sender, e);
	}

	internal static bool YrCfX1RIOMWshpjdGsR()
	{
		return true;
	}

	internal static bool yae4s0RJuALtufmd4Ad()
	{
		return false;
	}
}
