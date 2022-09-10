using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Windows.Forms;

namespace ns11;

internal abstract class Class54
{
	private static readonly bool bool_0 = Convert.ToBoolean("False");

	internal static readonly string string_0 = "1";

	internal static Class54 class54_0;

	internal IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private Delegate20 delegate20_0;

	internal static Class54 Handler
	{
		get
		{
			Type type = default(Type);
			while (class54_0 == null)
			{
				while (true)
				{
					IL_000b:
					Type[] types = Assembly.GetExecutingAssembly().GetTypes();
					while (true)
					{
						IL_0016:
						int num = 0;
						while (true)
						{
							if (num < types.Length)
							{
								type = types[num];
								goto IL_0022;
							}
							if (U97yETvt4EC3HWDjZPB())
							{
							}
							switch (7)
							{
							case 0:
							case 3:
								break;
							case 6:
								goto IL_000b;
							case 2:
							case 5:
								goto IL_0016;
							default:
								goto IL_0022;
							case 4:
								goto IL_0049;
							case 7:
								goto end_IL_0001;
							}
							break;
							IL_0022:
							if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class54))
							{
								goto IL_00d3;
							}
							goto IL_0049;
							IL_0049:
							try
							{
								class54_0 = (Class54)Activator.CreateInstance(type, nonPublic: true);
								int num2 = 2;
								if (!j9qKeJvADafgyteGjhi())
								{
									goto IL_008f;
								}
								while (true)
								{
									switch (num2)
									{
									default:
										num2 = 3;
										if (j9qKeJvADafgyteGjhi())
										{
											continue;
										}
										goto end_IL_0075;
									case 0:
									case 2:
										break;
									case 1:
									case 3:
										goto end_IL_0075;
									}
									goto IL_008f;
									continue;
									end_IL_0075:
									break;
								}
								goto end_IL_0049;
								IL_008f:
								if (class54_0 == null)
								{
									goto IL_00d3;
								}
								end_IL_0049:;
							}
							catch
							{
								goto IL_00d3;
							}
							goto end_IL_0001;
							IL_00d3:
							num++;
						}
						break;
					}
					break;
				}
				continue;
				end_IL_0001:
				break;
			}
			return class54_0;
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
			while (true)
			{
				EventHandler eventHandler = eventHandler_0;
				while (true)
				{
					EventHandler eventHandler2 = eventHandler;
					if (U97yETvt4EC3HWDjZPB())
					{
						return;
					}
					switch (4)
					{
					case 1:
					case 5:
						continue;
					case 4:
					{
						EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
						eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
						goto default;
					}
					default:
						if ((object)eventHandler != eventHandler2)
						{
							continue;
						}
						return;
					case 0:
					case 2:
						break;
					case 6:
						return;
					}
					break;
				}
			}
		}
	}

	public event Delegate20 SendingReportFeedback
	{
		add
		{
			Delegate20 delegate2 = default(Delegate20);
			Delegate20 value2 = default(Delegate20);
			while (true)
			{
				Delegate20 @delegate = delegate20_0;
				if (U97yETvt4EC3HWDjZPB())
				{
				}
				switch (3)
				{
				case 0:
				case 4:
					break;
				default:
					if ((object)@delegate == delegate2)
					{
						return;
					}
					goto case 3;
				case 3:
					delegate2 = @delegate;
					value2 = (Delegate20)Delegate.Combine(delegate2, value);
					goto case 2;
				case 2:
				case 5:
					@delegate = Interlocked.CompareExchange(ref delegate20_0, value2, delegate2);
					goto default;
				case 6:
					return;
				}
			}
		}
		remove
		{
			Delegate20 @delegate = default(Delegate20);
			if (j9qKeJvADafgyteGjhi())
			{
				switch (4)
				{
				case 4:
					@delegate = delegate20_0;
					goto IL_005c;
				case 0:
				case 2:
					break;
				default:
					goto IL_0048;
				case 1:
				case 5:
					goto IL_005c;
				case 6:
					return;
				}
			}
			goto IL_003b;
			IL_0048:
			Delegate20 value2 = default(Delegate20);
			Delegate20 delegate2 = default(Delegate20);
			@delegate = Interlocked.CompareExchange(ref delegate20_0, value2, delegate2);
			if ((object)@delegate == delegate2)
			{
				return;
			}
			goto IL_005c;
			IL_005c:
			delegate2 = @delegate;
			goto IL_003b;
			IL_003b:
			value2 = (Delegate20)Delegate.Remove(delegate2, value);
			goto IL_0048;
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
			while (true)
			{
				Type type = ex.GetType();
				int num = 3;
				if (!U97yETvt4EC3HWDjZPB())
				{
				}
				while (true)
				{
					switch (num)
					{
					default:
						if (ex is SecurityException && string_0 == "1" && method_2(ex as SecurityException))
						{
							num = 5;
							if (j9qKeJvADafgyteGjhi())
							{
								continue;
							}
							goto case 1;
						}
						method_3(ex, bool_1: true, bool_2: false);
						return;
					case 1:
					case 3:
						if (type.Name == "UnhandledException" && type.Namespace == "SmartAssembly.SmartExceptionsCore")
						{
							ex = (Exception)type.GetField("PreviousException")!.GetValue(ex);
						}
						goto default;
					case 0:
					case 4:
						break;
					case 5:
						return;
					}
					break;
				}
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
			Class45 @class = new Class45(vmethod_3(), exception_0, iwebProxy_0);
			@class.SendingReportFeedback += method_6;
			@class.DebuggerLaunched += method_5;
			@class.FatalException += method_4;
			EventArgs1 eventArgs = new EventArgs1(@class, exception_0);
			if (Class58.smethod_64() != null)
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
			if (j9qKeJvADafgyteGjhi())
			{
				switch (3)
				{
				case 0:
					break;
				case 1:
				case 3:
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

	internal static bool j9qKeJvADafgyteGjhi()
	{
		return true;
	}

	internal static bool U97yETvt4EC3HWDjZPB()
	{
		return false;
	}
}
