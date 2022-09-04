using System;
using System.Runtime.CompilerServices;
using System.Threading;
using ns2;
using ns3;
using ns5;
using ns7;
using ns8;

namespace ns10;

internal abstract class Class58
{
	[CompilerGenerated]
	private sealed class Class60
	{
		public Class55 class55_0;

		public Class58 class58_0;

		public void method_0()
		{
			try
			{
				class58_0.method_4(class55_0);
			}
			catch (Exception exception_)
			{
				Class38.smethod_1(exception_, this);
				throw;
			}
		}
	}

	private static bool bool_0;

	private Delegate11 delegate11_0;

	private static readonly object object_0;

	protected void method_0(uint uint_0)
	{
		object obj = default(object);
		try
		{
			try
			{
				Monitor.Enter(obj = object_0);
				try
				{
					method_2();
					Class56.smethod_4(uint_0);
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}
			catch
			{
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_3(exception_, obj, this, uint_0);
			throw;
		}
	}

	protected void method_1(string string_0)
	{
		object obj = default(object);
		try
		{
			try
			{
				Monitor.Enter(obj = object_0);
				try
				{
					method_2();
					Class56.smethod_6(string_0);
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}
			catch
			{
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_3(exception_, obj, this, string_0);
			throw;
		}
	}

	private void method_2()
	{
		Class60 @class = default(Class60);
		Thread thread = default(Thread);
		try
		{
			if (!bool_0)
			{
				@class = new Class60();
				@class.class58_0 = this;
				@class.class55_0 = Class56.smethod_8();
				thread = new Thread(@class.method_0);
				thread.IsBackground = true;
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				AppDomain.CurrentDomain.ProcessExit += method_3;
				bool_0 = true;
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_3(exception_, thread, @class, this);
			throw;
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		Class55 @class = default(Class55);
		Class48 class2 = default(Class48);
		try
		{
			@class = Class56.smethod_9();
			if (!@class.method_2())
			{
				class2 = new Class48(@class);
				class2.method_1(method_5);
				if (vmethod_1())
				{
					vmethod_0(class2);
					Class56.smethod_10();
				}
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_5(exception_, @class, class2, this, sender, e);
			throw;
		}
	}

	protected abstract void vmethod_0(Class48 class48_0);

	protected abstract bool vmethod_1();

	private void method_4(Class55 class55_0)
	{
		Class48 @class = default(Class48);
		try
		{
			@class = new Class48(class55_0);
			@class.method_1(method_5);
			if (vmethod_1())
			{
				Thread.CurrentThread.IsBackground = false;
				vmethod_0(@class);
			}
			Class54.smethod_0();
		}
		catch (Exception exception_)
		{
			Class38.smethod_3(exception_, @class, this, class55_0);
			throw;
		}
	}

	private void method_5(object sender, EventArgs4 e)
	{
		Delegate11 @delegate = default(Delegate11);
		try
		{
			@delegate = delegate11_0;
			@delegate?.Invoke(sender, e);
		}
		catch (Exception exception_)
		{
			Class38.smethod_4(exception_, @delegate, this, sender, e);
			throw;
		}
	}

	static Class58()
	{
		try
		{
			object_0 = new object();
		}
		catch (Exception exception_)
		{
			Class38.smethod_0(exception_);
			throw;
		}
	}
}
