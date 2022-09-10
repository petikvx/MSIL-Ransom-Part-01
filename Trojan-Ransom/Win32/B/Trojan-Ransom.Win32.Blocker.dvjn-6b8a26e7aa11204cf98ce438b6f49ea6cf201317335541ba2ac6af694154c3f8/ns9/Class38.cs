using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ns7;

namespace ns9;

internal abstract class Class38
{
	private static readonly bool bool_0 = Convert.ToBoolean(Class14.smethod_0(3085));

	internal static readonly string string_0 = Class14.smethod_0(1158);

	internal static Class38 class38_0;

	internal IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private Delegate10 delegate10_0;

	internal static Class38 Handler
	{
		get
		{
			if (!Nh14am4XuP5L0bLmfqH())
			{
				goto IL_0093;
			}
			Type[] types = default(Type[]);
			int num = default(int);
			switch (3)
			{
			case 0:
			case 3:
				if (class38_0 == null)
				{
					goto case 1;
				}
				goto IL_0099;
			case 1:
				types = Assembly.GetExecutingAssembly().GetTypes();
				num = 0;
				goto IL_0093;
			case 4:
			case 5:
				goto IL_0056;
			case 6:
				goto IL_0093;
			case 7:
				goto IL_0099;
			}
			goto IL_0053;
			IL_0053:
			Type type = default(Type);
			if ((object)type != null)
			{
				goto IL_0056;
			}
			goto IL_008f;
			IL_0099:
			return class38_0;
			IL_008f:
			num++;
			goto IL_0093;
			IL_0093:
			if (num < types.Length)
			{
				type = types[num];
				goto IL_0053;
			}
			goto IL_0099;
			IL_0056:
			if ((object)type.BaseType != null && (object)type.BaseType == typeof(Class38))
			{
				try
				{
					class38_0 = (Class38)Activator.CreateInstance(type, nonPublic: true);
					if (class38_0 != null)
					{
						goto IL_0099;
					}
				}
				catch
				{
				}
			}
			goto IL_008f;
		}
	}

	public event EventHandler DebuggerLaunched
	{
		add
		{
			while (true)
			{
				EventHandler eventHandler = eventHandler_0;
				while (true)
				{
					EventHandler eventHandler2 = eventHandler;
					while (true)
					{
						IL_0036:
						EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
						eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
						while ((object)eventHandler == eventHandler2)
						{
							if (DNRaTr40MlvjeohwBIo())
							{
							}
							switch (6)
							{
							case 5:
								goto IL_0036;
							case 1:
								goto end_IL_0030;
							case 0:
							case 4:
								goto end_IL_0053;
							case 6:
								return;
							}
							continue;
							end_IL_0030:
							break;
						}
						break;
					}
					continue;
					end_IL_0053:
					break;
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

	public event Delegate10 SendingReportFeedback
	{
		add
		{
			Delegate10 @delegate = default(Delegate10);
			if (!DNRaTr40MlvjeohwBIo())
			{
				switch (2)
				{
				case 0:
				case 2:
					@delegate = delegate10_0;
					goto IL_004b;
				case 5:
					break;
				case 1:
					goto IL_004b;
				default:
					goto IL_005c;
				case 6:
					return;
				}
			}
			goto IL_003b;
			IL_003b:
			Delegate10 value2 = default(Delegate10);
			Delegate10 delegate2 = default(Delegate10);
			@delegate = Interlocked.CompareExchange(ref delegate10_0, value2, delegate2);
			goto IL_005c;
			IL_005c:
			if ((object)@delegate == delegate2)
			{
				return;
			}
			goto IL_004b;
			IL_004b:
			delegate2 = @delegate;
			value2 = (Delegate10)Delegate.Combine(delegate2, value);
			goto IL_003b;
		}
		remove
		{
			Delegate10 @delegate = delegate10_0;
			Delegate10 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate10 value2 = (Delegate10)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate10_0, value2, delegate2);
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
			if (type.Name == Class14.smethod_0(2869) && type.Namespace == Class14.smethod_0(2894))
			{
				ex = (Exception)type.GetField(Class14.smethod_0(2939))!.GetValue(ex);
			}
			if (!(ex is SecurityException) || !(string_0 == Class14.smethod_0(1158)) || !method_2(ex as SecurityException))
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
			if ((!(e.ExceptionObject is SecurityException) || !(string_0 == Class14.smethod_0(1158)) || !method_2(e.ExceptionObject as SecurityException)) && e.ExceptionObject is Exception)
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
			while (true)
			{
				vmethod_2(eventArgs);
				while (true)
				{
					if (!eventArgs.bool_1)
					{
						if (!eventArgs.bool_0)
						{
							while (true)
							{
								Application.Exit();
								if (DNRaTr40MlvjeohwBIo())
								{
								}
								switch (6)
								{
								case 2:
								case 5:
									goto end_IL_000b;
								case 0:
								case 1:
									goto end_IL_003f;
								case 4:
									goto end_IL_0049;
								case 6:
									goto IL_005d;
								}
								continue;
								end_IL_000b:
								break;
							}
							continue;
						}
						goto IL_005d;
					}
					return false;
					IL_005d:
					return true;
					continue;
					end_IL_003f:
					break;
				}
				continue;
				end_IL_0049:
				break;
			}
		}
	}

	internal void method_3(Exception exception_0, bool bool_1, bool bool_2)
	{
		Type type = exception_0.GetType();
		if (type.Name == Class14.smethod_0(2869) && type.Namespace == Class14.smethod_0(2894))
		{
			exception_0 = (Exception)type.GetField(Class14.smethod_0(2939))!.GetValue(exception_0);
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
			if (Class42.smethod_115() != null)
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
				if (fullName.EndsWith(Class14.smethod_0(2964)) && fullName.StartsWith(Class14.smethod_0(2989)))
				{
					object obj = assembly.GetType(Class14.smethod_0(3022))!.GetProperty(Class14.smethod_0(3059))!.GetGetMethod()!.Invoke(null, null);
					obj.GetType().GetMethod(Class14.smethod_0(3072), new Type[0])!.Invoke(obj, null);
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
			if (DNRaTr40MlvjeohwBIo())
			{
			}
			switch (4)
			{
			case 0:
			case 2:
				break;
			case 1:
			case 4:
				if (eventHandler == null)
				{
					return;
				}
				goto default;
			default:
				eventHandler(sender, e);
				return;
			case 5:
				return;
			}
		}
	}

	private void method_6(object sender, EventArgs3 e)
	{
		delegate10_0?.Invoke(sender, e);
	}

	internal static bool Nh14am4XuP5L0bLmfqH()
	{
		return true;
	}

	internal static bool DNRaTr40MlvjeohwBIo()
	{
		return false;
	}
}
