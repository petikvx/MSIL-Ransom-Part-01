using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;

internal sealed class Class26 : IDisposable
{
	public static volatile Class26 class26_0;

	private static readonly object object_0;

	private ReaderWriterLock readerWriterLock_0;

	private Dictionary<int, Interface2> dictionary_0;

	private Class27 class27_0;

	private Class11 class11_0;

	public static Class26 Class26_0
	{
		get
		{
			if (class26_0 == null && 0 == 0)
			{
				try
				{
					Monitor.Enter(object_0);
					if (class26_0 == null && 0 == 0)
					{
						class26_0 = new Class26();
						GC.SuppressFinalize(class26_0);
					}
				}
				finally
				{
					Monitor.Exit(object_0);
				}
			}
			return class26_0;
		}
	}

	static Class26()
	{
		class26_0 = null;
		object_0 = new object();
	}

	private Class26()
	{
		readerWriterLock_0 = new ReaderWriterLock();
		while (true)
		{
			int num = Class13.smethod_4(37);
			while (true)
			{
				switch (num)
				{
				case 2:
					goto IL_0013;
				case 0:
					dictionary_0 = new Dictionary<int, Interface2>();
					num = 2;
					goto IL_0013;
				case 1:
					class11_0 = new Class11();
					num = 3;
					goto case 3;
				case 3:
					GC.SuppressFinalize(class27_0);
					num = 4;
					return;
				case 4:
					return;
				}
				break;
				IL_0013:
				class27_0 = new Class27();
				num = Class13.smethod_4(38);
			}
		}
	}

	~Class26()
	{
		method_0(bool_0: false);
	}

	public void method_0(bool bool_0)
	{
		try
		{
			if (bool_0 || 1 == 0)
			{
				class27_0.Dispose();
			}
		}
		finally
		{
			class27_0 = null;
			while (true)
			{
				int num;
				switch (Class13.smethod_4(37))
				{
				default:
					continue;
				case 0:
					dictionary_0 = null;
					num = 1;
					break;
				case 1:
					break;
				case 2:
					goto end_IL_001d;
				}
				class11_0 = null;
				num = 2;
				break;
				continue;
				end_IL_001d:
				break;
			}
		}
	}

	public void Dispose()
	{
		method_0(bool_0: true);
		GC.SuppressFinalize(this);
	}

	public static object smethod_0(int int_0, object object_1, params object[] object_2)
	{
		Interface2 @interface = null;
		try
		{
			@interface = Class26_0.method_1(int_0);
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(string.Format(Class33.smethod_0("\uf156\uf155\uf156\uf151\uf158\uf114\uf159\uf104\uf114\uf14f\uf104\uf149\uf10e\uf114\uf14f\uf105\uf149", 61748), int_0, ex.Message), ex);
		}
		try
		{
			return @interface.imethod_0(object_1, object_2);
		}
		catch (TargetInvocationException ex2)
		{
			if (ex2.InnerException != null || 1 == 0)
			{
				throw ex2.InnerException;
			}
			throw;
		}
	}

	public static Stream smethod_1(string string_0)
	{
		return smethod_2(string_0);
	}

	private static Stream smethod_2(string string_0)
	{
		return null;
	}

	private Interface2 method_1(int int_0)
	{
		readerWriterLock_0.AcquireReaderLock(-1);
		try
		{
			if (!dictionary_0.TryGetValue(int_0, out var value))
			{
				LockCookie lockCookie = readerWriterLock_0.UpgradeToWriterLock(-1);
				try
				{
					if (dictionary_0.TryGetValue(int_0, out value))
					{
						return value;
					}
					return method_2(int_0);
				}
				finally
				{
					readerWriterLock_0.DowngradeFromWriterLock(ref lockCookie);
				}
			}
			return value;
		}
		finally
		{
			readerWriterLock_0.ReleaseReaderLock();
		}
	}

	private Interface2 method_2(int int_0)
	{
		Class16 @class = class27_0.method_1(int_0);
		try
		{
			Interface2 @interface = Class23.smethod_0(class11_0, @class);
			if (@class.Boolean_5 || 1 == 0)
			{
				dictionary_0[int_0] = @interface;
			}
			return @interface;
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(string.Format(Class33.smethod_0("\ue6ff\ue6fc\ue6ff\ue6f8\ue6f1\ue6bd\ue6f0\ue6ac\ue6bd\ue6e6\ue6ad\ue6e0\ue6a7\ue6bd\ue6e6\ue6ac\ue6e0", 59037), int_0, ex.ToString()), ex);
		}
	}
}
