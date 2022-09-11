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
								if ((object)type == null)
								{
									goto IL_00c1;
								}
								goto IL_0028;
							}
							if (NGberGp5D6DOgQFJ87t())
							{
							}
							switch (7)
							{
							case 0:
							case 5:
								break;
							case 1:
								goto IL_000b;
							case 2:
							case 6:
								goto IL_0016;
							default:
								goto IL_0028;
							case 3:
								goto IL_0046;
							case 7:
								goto end_IL_0001;
							}
							break;
							IL_0028:
							if ((object)type.BaseType == null || (object)type.BaseType != typeof(Class54))
							{
								goto IL_00c1;
							}
							goto IL_0046;
							IL_00c1:
							num++;
							continue;
							IL_0046:
							try
							{
								class54_0 = (Class54)Activator.CreateInstance(type, nonPublic: true);
								if (VIwh2gpaxjSAMXY8k9W())
								{
									switch (2)
									{
									default:
										goto end_IL_0046;
									case 0:
									case 2:
										break;
									case 1:
									case 3:
										goto end_IL_0046;
									}
								}
								if (class54_0 == null)
								{
									goto IL_00c1;
								}
								end_IL_0046:;
							}
							catch
							{
								goto IL_00c1;
							}
							goto end_IL_0001;
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
			EventHandler eventHandler2 = default(EventHandler);
			EventHandler value2 = default(EventHandler);
			while (true)
			{
				EventHandler eventHandler = eventHandler_0;
				int num = 2;
				if (!NGberGp5D6DOgQFJ87t())
				{
				}
				while (true)
				{
					switch (num)
					{
					default:
						goto IL_0003;
					case 0:
					case 5:
						break;
					case 2:
						eventHandler2 = eventHandler;
						value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
						goto case 1;
					case 1:
						eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
						goto case 3;
					case 3:
					case 4:
						if ((object)eventHandler == eventHandler2)
						{
							return;
						}
						goto case 2;
					case 6:
						return;
					}
					break;
					IL_0003:
					num = 4;
					if (NGberGp5D6DOgQFJ87t())
					{
						return;
					}
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

	public event Delegate20 SendingReportFeedback
	{
		add
		{
			int num = 0;
			Delegate20 @delegate = default(Delegate20);
			if (VIwh2gpaxjSAMXY8k9W())
			{
				while (true)
				{
					switch (num)
					{
					case 0:
						@delegate = delegate20_0;
						num = 5;
						if (!NGberGp5D6DOgQFJ87t())
						{
							continue;
						}
						goto IL_0057;
					case 5:
						break;
					case 2:
					case 4:
						goto IL_004a;
					default:
						goto IL_0057;
					case 6:
						return;
					}
					break;
				}
			}
			goto IL_0048;
			IL_0048:
			Delegate20 delegate2 = @delegate;
			goto IL_004a;
			IL_004a:
			Delegate20 value2 = (Delegate20)Delegate.Combine(delegate2, value);
			goto IL_0057;
			IL_0057:
			@delegate = Interlocked.CompareExchange(ref delegate20_0, value2, delegate2);
			if ((object)@delegate == delegate2)
			{
				return;
			}
			goto IL_0048;
		}
		remove
		{
			while (true)
			{
				Delegate20 @delegate = delegate20_0;
				while (true)
				{
					Delegate20 delegate2 = @delegate;
					Delegate20 value2 = (Delegate20)Delegate.Remove(delegate2, value);
					while (true)
					{
						IL_0037:
						@delegate = Interlocked.CompareExchange(ref delegate20_0, value2, delegate2);
						while ((object)@delegate == delegate2)
						{
							if (VIwh2gpaxjSAMXY8k9W())
							{
								switch (6)
								{
								case 2:
								case 4:
									goto IL_0037;
								case 5:
									goto end_IL_0030;
								case 0:
									goto end_IL_0047;
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
					end_IL_0047:
					break;
				}
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
		while (true)
		{
			Type type = exception_0.GetType();
			while (true)
			{
				IL_0008:
				if (!(type.Name == "UnhandledException") || !(type.Namespace == "SmartAssembly.SmartExceptionsCore"))
				{
					goto IL_001d;
				}
				goto IL_01b7;
				IL_01b7:
				exception_0 = (Exception)type.GetField("PreviousException")!.GetValue(exception_0);
				goto IL_001d;
				IL_001d:
				while (true)
				{
					IL_001d_2:
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
						if (Class56.smethod_1() != null)
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
					int num = 0;
					while (true)
					{
						if (num < assemblies.Length)
						{
							Assembly assembly = assemblies[num];
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
							num++;
							continue;
						}
						if (!NGberGp5D6DOgQFJ87t())
						{
							switch (7)
							{
							case 0:
							case 5:
								break;
							case 4:
								goto IL_0008;
							default:
								goto IL_001d_2;
							case 3:
								continue;
							case 2:
							case 6:
								goto IL_01b7;
							case 7:
								goto IL_01f4;
							}
							break;
						}
						goto IL_01f4;
						IL_01f4:
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
					break;
				}
				break;
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
			if (VIwh2gpaxjSAMXY8k9W())
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
		if (VIwh2gpaxjSAMXY8k9W())
		{
			switch (2)
			{
			case 0:
			case 2:
				break;
			case 1:
			case 3:
				goto IL_0035;
			default:
				goto IL_0038;
			case 5:
				return;
			}
		}
		Delegate20 @delegate = delegate20_0;
		goto IL_0035;
		IL_0038:
		@delegate(sender, e);
		return;
		IL_0035:
		if (@delegate == null)
		{
			return;
		}
		goto IL_0038;
	}

	internal static bool VIwh2gpaxjSAMXY8k9W()
	{
		return true;
	}

	internal static bool NGberGp5D6DOgQFJ87t()
	{
		return false;
	}
}
