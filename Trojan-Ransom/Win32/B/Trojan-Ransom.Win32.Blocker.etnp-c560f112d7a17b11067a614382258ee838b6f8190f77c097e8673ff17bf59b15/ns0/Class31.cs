using System;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;

namespace ns0;

internal abstract class Class31
{
	private static readonly bool bool_0 = Convert.ToBoolean(Class5.smethod_0(82445));

	private static readonly string string_0 = Class5.smethod_0(80307);

	private static Class31 class31_0;

	private IWebProxy iwebProxy_0;

	private EventHandler eventHandler_0;

	private Delegate1 delegate1_0;

	[SpecialName]
	public void method_0(EventHandler CO_)
	{
		if (false)
		{
			goto IL_000f;
		}
		EventHandler eventHandler;
		if (0 == 0)
		{
			eventHandler = eventHandler_0;
		}
		goto IL_003d;
		IL_002d:
		EventHandler eventHandler2;
		if ((object)eventHandler == eventHandler2)
		{
			goto IL_000f;
		}
		goto IL_003d;
		IL_003d:
		if (7u != 0)
		{
			EventHandler eventHandler3 = eventHandler;
			if (6u != 0)
			{
				eventHandler2 = eventHandler3;
			}
			goto IL_0012;
		}
		goto IL_002d;
		IL_000f:
		if (0 == 0)
		{
			return;
		}
		goto IL_0012;
		IL_0012:
		EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, CO_);
		eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		goto IL_002d;
	}

	[SpecialName]
	public void method_1(Delegate1 CO_)
	{
		if (false)
		{
			goto IL_000f;
		}
		Delegate1 @delegate;
		if (0 == 0)
		{
			@delegate = delegate1_0;
		}
		goto IL_003d;
		IL_002d:
		Delegate1 delegate2;
		if ((object)@delegate == delegate2)
		{
			goto IL_000f;
		}
		goto IL_003d;
		IL_003d:
		if (7u != 0)
		{
			Delegate1 delegate3 = @delegate;
			if (6u != 0)
			{
				delegate2 = delegate3;
			}
			goto IL_0012;
		}
		goto IL_002d;
		IL_000f:
		if (0 == 0)
		{
			return;
		}
		goto IL_0012;
		IL_0012:
		Delegate1 value = (Delegate1)Delegate.Combine(delegate2, CO_);
		@delegate = Interlocked.CompareExchange(ref delegate1_0, value, delegate2);
		goto IL_002d;
	}

	protected abstract void vmethod_0(EventArgs1 CO_);

	protected abstract void vmethod_1(EventArgs0 CO_);

	protected abstract void vmethod_2(EventArgs2 CO_);

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static void smethod_0(Class31 CO_)
	{
		if (4u != 0 && CO_ != null)
		{
			if (3u != 0)
			{
				class31_0 = CO_;
			}
			AppDomain.CurrentDomain.UnhandledException += CO_.method_3;
			Application.add_ThreadException((ThreadExceptionEventHandler)CO_.method_2);
		}
	}

	[SpecialName]
	private static Class31 smethod_1()
	{
		if (class31_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			Type[] array = default(Type[]);
			if (0 == 0)
			{
				array = types;
			}
			int num = 0;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = array.Length;
					if (false)
					{
						goto IL_0021;
					}
					if (num2 >= num3)
					{
						break;
					}
					Type type = array[num];
					if ((object)type != null && (object)type.BaseType != null && (object)type.BaseType == typeof(Class31))
					{
						try
						{
							if (0 == 0 && 0 == 0)
							{
								class31_0 = (Class31)Activator.CreateInstance(type, nonPublic: true);
								goto IL_0061;
							}
							goto IL_0068;
							IL_0068:
							if (false)
							{
								goto IL_0061;
							}
							goto end_IL_004a;
							IL_0061:
							if (class31_0 != null)
							{
								goto IL_0068;
							}
							goto IL_0075;
							end_IL_004a:;
						}
						catch
						{
							goto IL_0075;
						}
						break;
					}
					goto IL_0075;
					IL_0021:
					num2 += num3;
					if (false)
					{
						continue;
					}
					goto IL_0072;
					IL_0075:
					num2 = num;
					num3 = 1;
					goto IL_0021;
				}
				break;
				IL_0072:
				num = num2;
			}
		}
		return class31_0;
	}

	public static void smethod_2(Exception CO_, object[] CO_)
	{
		do
		{
			IL_0000:
			if (CO_ != null)
			{
				goto IL_004e;
			}
			goto IL_0056;
			IL_0056:
			while (0 == 0)
			{
				Class29.smethod_10(CO_, CO_);
				if (false)
				{
					goto IL_004e;
				}
				smethod_1().method_5(CO_, CO_: false, CO_: false);
				if (false)
				{
					continue;
				}
				goto IL_005b;
			}
			goto IL_0005;
			IL_004e:
			if (CO_ is SecurityException)
			{
				goto IL_0005;
			}
			goto IL_0056;
			IL_0005:
			if (string_0 == Class5.smethod_0(80307))
			{
				if (-1 == 0)
				{
					goto IL_0000;
				}
				if (smethod_1().method_4((SecurityException)CO_))
				{
					break;
				}
			}
			goto IL_0056;
			IL_005b:;
		}
		while (1 == 0);
	}

	private void method_2(object sender, ThreadExceptionEventArgs e)
	{
		try
		{
			Exception ex;
			if (0 == 0)
			{
				ex = e.Exception;
			}
			Type type = ex.GetType();
			if (type.Name == Class5.smethod_0(82229) && type.Namespace == Class5.smethod_0(82254))
			{
				ex = (Exception)type.GetField(Class5.smethod_0(82299))!.GetValue(ex);
			}
			if (!(ex is SecurityException) || !(string_0 == Class5.smethod_0(80307)) || !method_4(ex as SecurityException))
			{
				method_5(ex, CO_: true, CO_: false);
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
			while (true)
			{
				bool num;
				if (false || e.ExceptionObject is SecurityException)
				{
					num = string_0 == Class5.smethod_0(80307);
					if (false)
					{
						goto IL_001e;
					}
					if (num)
					{
						goto IL_0025;
					}
				}
				goto IL_003b;
				IL_001e:
				if (num)
				{
					break;
				}
				goto IL_003b;
				IL_003b:
				if (7u != 0)
				{
					if (false)
					{
						goto IL_0025;
					}
					if (!(e.ExceptionObject is Exception))
					{
						break;
					}
				}
				method_5((Exception)e.ExceptionObject, !e.IsTerminating, CO_: false);
				break;
				IL_0025:
				if (false)
				{
					continue;
				}
				num = method_4(e.ExceptionObject as SecurityException);
				goto IL_001e;
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

	private bool method_4(SecurityException CO_)
	{
		EventArgs2 eventArgs = new EventArgs2(CO_);
		int num;
		while (true)
		{
			vmethod_2(eventArgs);
			num = (eventArgs.method_5() ? 1 : 0);
			if (false)
			{
				break;
			}
			if (num == 0)
			{
				if (3 == 0)
				{
					continue;
				}
				num = (eventArgs.method_3() ? 1 : 0);
				if (0 == 0)
				{
					if (num == 0)
					{
						Application.Exit();
					}
					num = 1;
				}
				break;
			}
			num = 0;
			if (num != 0)
			{
				break;
			}
			return (byte)num != 0;
		}
		return (byte)num != 0;
	}

	private void method_5(Exception CO_, bool CO_, bool CO_)
	{
		Type type = CO_.GetType();
		Type type2 = default(Type);
		if (0 == 0)
		{
			type2 = type;
		}
		if (type2.Name == Class5.smethod_0(82229) && type2.Namespace == Class5.smethod_0(82254))
		{
			CO_ = (Exception)type2.GetField(Class5.smethod_0(82299))!.GetValue(CO_);
		}
		bool flag = true;
		if (CO_ == null || CO_ is ThreadAbortException)
		{
			return;
		}
		try
		{
			Class23 @class = new Class23(vmethod_3(), CO_, iwebProxy_0);
			@class.method_2(method_8);
			@class.method_20(method_7);
			@class.method_18(method_6);
			EventArgs1 eventArgs = new EventArgs1(@class, CO_);
			while (true)
			{
				if (Class3.smethod_0() != null)
				{
					eventArgs.method_5();
				}
				if (!CO_)
				{
					eventArgs.method_4(CO_: false);
					eventArgs.method_7(CO_: false);
					goto IL_00e0;
				}
				if (!CO_)
				{
					goto IL_00d6;
				}
				goto IL_00ec;
				IL_00ec:
				eventArgs.method_4(CO_: false);
				eventArgs.method_7(CO_: true);
				goto IL_00e0;
				IL_00d6:
				if (2 == 0)
				{
					continue;
				}
				if (!bool_0)
				{
					goto IL_00e0;
				}
				goto IL_00ec;
				IL_00e0:
				vmethod_0(eventArgs);
				if (0 == 0)
				{
					break;
				}
				goto IL_00d6;
			}
			flag = !eventArgs.method_6();
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception cO_)
		{
			vmethod_1(new EventArgs0(cO_));
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
				if (fullName.EndsWith(Class5.smethod_0(82324)) && fullName.StartsWith(Class5.smethod_0(82349)))
				{
					object obj = assembly.GetType(Class5.smethod_0(82382))!.GetProperty(Class5.smethod_0(82419))!.GetGetMethod()!.Invoke(null, null);
					obj.GetType().GetMethod(Class5.smethod_0(82432), new Type[0])!.Invoke(obj, null);
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
				do
				{
					Environment.Exit(0);
				}
				while (false);
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
		delegate1_0?.Invoke(sender, e);
	}
}
