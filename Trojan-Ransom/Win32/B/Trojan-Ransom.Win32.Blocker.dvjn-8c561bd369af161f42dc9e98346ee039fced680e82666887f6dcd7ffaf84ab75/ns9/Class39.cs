using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ns7;

namespace ns9;

internal abstract class Class39
{
	private static readonly bool bool_0 = Convert.ToBoolean(Class14.smethod_0(6794));

	internal static readonly string string_0 = Class14.smethod_0(2062);

	internal static Class39 class39_0;

	internal IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private Delegate11 delegate11_0;

	internal static Class39 Handler
	{
		get
		{
			if (class39_0 == null)
			{
				Type[] types = Assembly.GetExecutingAssembly().GetTypes();
				foreach (Type type in types)
				{
					if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class39))
					{
						continue;
					}
					try
					{
						class39_0 = (Class39)Activator.CreateInstance(type, nonPublic: true);
						if (class39_0 != null)
						{
							break;
						}
					}
					catch
					{
					}
				}
			}
			return class39_0;
		}
	}

	public event EventHandler DebuggerLaunched
	{
		add
		{
			EventHandler value2 = default(EventHandler);
			EventHandler eventHandler2 = default(EventHandler);
			while (true)
			{
				EventHandler eventHandler = eventHandler_0;
				if (iZ0CqRr5tL9OJR10O80())
				{
				}
				switch (5)
				{
				case 4:
					break;
				case 0:
				case 2:
					eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
					goto default;
				default:
					if ((object)eventHandler == eventHandler2)
					{
						return;
					}
					goto case 1;
				case 1:
				case 5:
					eventHandler2 = eventHandler;
					value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					goto case 0;
				case 6:
					return;
				}
			}
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

	public event Delegate11 SendingReportFeedback
	{
		add
		{
			if (!KwYYXbrPy7nmpy15GmX())
			{
				goto IL_004e;
			}
			Delegate11 @delegate = default(Delegate11);
			switch (3)
			{
			case 0:
			case 3:
				@delegate = delegate11_0;
				goto IL_004a;
			case 5:
				break;
			case 1:
			case 4:
				goto IL_004a;
			default:
				goto IL_004e;
			case 6:
				return;
			}
			goto IL_003b;
			IL_003b:
			Delegate11 delegate2 = default(Delegate11);
			Delegate11 value2 = (Delegate11)Delegate.Combine(delegate2, value);
			goto IL_004e;
			IL_004e:
			@delegate = Interlocked.CompareExchange(ref delegate11_0, value2, delegate2);
			if ((object)@delegate == delegate2)
			{
				return;
			}
			goto IL_004a;
			IL_004a:
			delegate2 = @delegate;
			goto IL_003b;
		}
		remove
		{
			Delegate11 @delegate = delegate11_0;
			Delegate11 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate11 value2 = (Delegate11)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate11_0, value2, delegate2);
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
			if (type.Name == Class14.smethod_0(6578) && type.Namespace == Class14.smethod_0(6603))
			{
				ex = (Exception)type.GetField(Class14.smethod_0(6648))!.GetValue(ex);
			}
			if (!(ex is SecurityException) || !(string_0 == Class14.smethod_0(2062)) || !method_2(ex as SecurityException))
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
			if ((!(e.ExceptionObject is SecurityException) || !(string_0 == Class14.smethod_0(2062)) || !method_2(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
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
		if (type.Name == Class14.smethod_0(6578) && type.Namespace == Class14.smethod_0(6603))
		{
			exception_0 = (Exception)type.GetField(Class14.smethod_0(6648))!.GetValue(exception_0);
		}
		bool flag = true;
		if (exception_0 == null || exception_0 is ThreadAbortException)
		{
			return;
		}
		try
		{
			Class29 @class = new Class29(vmethod_3(), exception_0, iwebProxy_0);
			@class.SendingReportFeedback += method_6;
			@class.DebuggerLaunched += method_5;
			@class.FatalException += method_4;
			EventArgs1 eventArgs = new EventArgs1(@class, exception_0);
			if (Class33.smethod_87() != null)
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
				if (fullName.EndsWith(Class14.smethod_0(6673)) && fullName.StartsWith(Class14.smethod_0(6698)))
				{
					object obj = assembly.GetType(Class14.smethod_0(6731))!.GetProperty(Class14.smethod_0(6768))!.GetGetMethod()!.Invoke(null, null);
					obj.GetType().GetMethod(Class14.smethod_0(6781), new Type[0])!.Invoke(obj, null);
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
		while (true)
		{
			EventHandler eventHandler = eventHandler_0;
			while (true)
			{
				if (eventHandler == null)
				{
					return;
				}
				while (true)
				{
					eventHandler(sender, e);
					int num = 5;
					if (!KwYYXbrPy7nmpy15GmX())
					{
						return;
					}
					while (true)
					{
						switch (num)
						{
						default:
							num = 0;
							if (!iZ0CqRr5tL9OJR10O80())
							{
							}
							continue;
						case 0:
						case 2:
							break;
						case 1:
						case 4:
							goto end_IL_002e;
						case 3:
							goto end_IL_0044;
						case 5:
							return;
						}
						break;
					}
					continue;
					end_IL_002e:
					break;
				}
				continue;
				end_IL_0044:
				break;
			}
		}
	}

	private void method_6(object sender, EventArgs3 e)
	{
		delegate11_0?.Invoke(sender, e);
	}

	internal static bool KwYYXbrPy7nmpy15GmX()
	{
		return true;
	}

	internal static bool iZ0CqRr5tL9OJR10O80()
	{
		return false;
	}
}
