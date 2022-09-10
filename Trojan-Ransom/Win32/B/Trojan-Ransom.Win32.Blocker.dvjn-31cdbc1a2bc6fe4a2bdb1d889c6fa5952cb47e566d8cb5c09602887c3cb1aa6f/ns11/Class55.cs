using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Windows.Forms;

namespace ns11;

internal abstract class Class55
{
	private static readonly bool bool_0 = Convert.ToBoolean("False");

	internal static readonly string string_0 = "1";

	internal static Class55 class55_0;

	internal IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private Delegate20 delegate20_0;

	internal static Class55 Handler
	{
		get
		{
			if (class55_0 == null)
			{
				Type[] types = Assembly.GetExecutingAssembly().GetTypes();
				foreach (Type type in types)
				{
					if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class55))
					{
						continue;
					}
					try
					{
						class55_0 = (Class55)Activator.CreateInstance(type, nonPublic: true);
						if (class55_0 != null)
						{
							break;
						}
					}
					catch
					{
					}
				}
			}
			return class55_0;
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
			if (gNSZ0wXNVSGG6uy3oMm())
			{
				goto IL_0048;
			}
			EventHandler eventHandler = default(EventHandler);
			switch (2)
			{
			case 2:
				eventHandler = eventHandler_0;
				break;
			case 1:
			case 4:
				break;
			case 0:
				goto IL_003b;
			default:
				goto IL_0048;
			case 6:
				return;
			}
			goto IL_0039;
			IL_0048:
			EventHandler value2 = default(EventHandler);
			EventHandler eventHandler2 = default(EventHandler);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			if ((object)eventHandler == eventHandler2)
			{
				return;
			}
			goto IL_0039;
			IL_0039:
			eventHandler2 = eventHandler;
			goto IL_003b;
			IL_003b:
			value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
			goto IL_0048;
		}
	}

	public event Delegate20 SendingReportFeedback
	{
		add
		{
			while (true)
			{
				Delegate20 @delegate = delegate20_0;
				while (true)
				{
					Delegate20 delegate2 = @delegate;
					while (true)
					{
						IL_0037:
						Delegate20 value2 = (Delegate20)Delegate.Combine(delegate2, value);
						@delegate = Interlocked.CompareExchange(ref delegate20_0, value2, delegate2);
						while ((object)@delegate == delegate2)
						{
							if (ekFdoWXIwadNkbbccos())
							{
								switch (6)
								{
								case 5:
									goto IL_0037;
								case 1:
								case 2:
									goto end_IL_0030;
								case 0:
								case 4:
									goto end_IL_0054;
								case 6:
									return;
								}
								continue;
							}
							goto IL_0037;
							continue;
							end_IL_0030:
							break;
						}
						break;
					}
					continue;
					end_IL_0054:
					break;
				}
			}
		}
		remove
		{
			if (gNSZ0wXNVSGG6uy3oMm())
			{
			}
			Delegate20 @delegate = default(Delegate20);
			Delegate20 value2 = default(Delegate20);
			Delegate20 delegate2 = default(Delegate20);
			switch (3)
			{
			case 3:
				@delegate = delegate20_0;
				goto case 1;
			case 0:
			case 2:
				value2 = (Delegate20)Delegate.Remove(delegate2, value);
				goto default;
			default:
				@delegate = Interlocked.CompareExchange(ref delegate20_0, value2, delegate2);
				if ((object)@delegate == delegate2)
				{
					break;
				}
				goto case 1;
			case 1:
			case 5:
				delegate2 = @delegate;
				goto case 0;
			case 6:
				break;
			}
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
			if (!(e.ExceptionObject is SecurityException))
			{
				goto IL_001b;
			}
			int num = 2;
			if (gNSZ0wXNVSGG6uy3oMm())
			{
			}
			goto IL_005c;
			IL_005c:
			switch (num)
			{
			case 0:
			case 2:
				if (!(string_0 == "1"))
				{
					goto IL_001b;
				}
				goto default;
			default:
				if (method_2(e.ExceptionObject as SecurityException))
				{
					return;
				}
				goto IL_001b;
			case 4:
				break;
			}
			goto IL_007c;
			IL_001b:
			if (e.ExceptionObject is Exception)
			{
				num = 4;
				if (!gNSZ0wXNVSGG6uy3oMm())
				{
					goto IL_005c;
				}
				goto IL_007c;
			}
			return;
			IL_007c:
			method_3((Exception)e.ExceptionObject, !e.IsTerminating, bool_2: false);
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
			Class46 @class = new Class46(vmethod_3(), exception_0, iwebProxy_0);
			@class.SendingReportFeedback += method_6;
			@class.DebuggerLaunched += method_5;
			@class.FatalException += method_4;
			EventArgs1 eventArgs = new EventArgs1(@class, exception_0);
			if (Class21.smethod_111() != null)
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
		while (true)
		{
			EventHandler eventHandler = eventHandler_0;
			if (ekFdoWXIwadNkbbccos())
			{
				switch (4)
				{
				case 0:
				case 3:
					break;
				case 1:
				case 4:
					goto IL_0034;
				default:
					goto IL_0037;
				case 5:
					return;
				}
				continue;
			}
			goto IL_0034;
			IL_0037:
			eventHandler(sender, e);
			break;
			IL_0034:
			if (eventHandler == null)
			{
				break;
			}
			goto IL_0037;
		}
	}

	private void method_6(object sender, EventArgs3 e)
	{
		delegate20_0?.Invoke(sender, e);
	}

	internal static bool ekFdoWXIwadNkbbccos()
	{
		return true;
	}

	internal static bool gNSZ0wXNVSGG6uy3oMm()
	{
		return false;
	}
}
