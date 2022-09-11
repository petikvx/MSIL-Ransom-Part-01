using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;

internal sealed class Class65 : IDisposable
{
	public static volatile Class65 class65_0;

	private static readonly object object_0;

	private ReaderWriterLock readerWriterLock_0;

	private Dictionary<int, Interface0> dictionary_0;

	private Class66 class66_0;

	private Class50 class50_0;

	public static Class65 Class65_0
	{
		get
		{
			if (class65_0 == null && 0 == 0)
			{
				try
				{
					Monitor.Enter(object_0);
					if (class65_0 == null && 0 == 0)
					{
						class65_0 = new Class65();
						GC.SuppressFinalize(class65_0);
					}
				}
				finally
				{
					Monitor.Exit(object_0);
				}
			}
			return class65_0;
		}
	}

	static Class65()
	{
		class65_0 = null;
		object_0 = new object();
	}

	private Class65()
	{
		readerWriterLock_0 = new ReaderWriterLock();
		while (true)
		{
			int num = Class52.smethod_4(37);
			while (true)
			{
				switch (num)
				{
				case 2:
					goto IL_0013;
				case 0:
					dictionary_0 = new Dictionary<int, Interface0>();
					num = 2;
					goto IL_0013;
				case 1:
					class50_0 = new Class50();
					num = 3;
					goto case 3;
				case 3:
					GC.SuppressFinalize(class66_0);
					num = 4;
					return;
				case 4:
					return;
				}
				break;
				IL_0013:
				class66_0 = new Class66();
				num = Class52.smethod_4(38);
			}
		}
	}

	~Class65()
	{
		method_0(bool_0: false);
	}

	public void method_0(bool bool_0)
	{
		try
		{
			if (bool_0 || 1 == 0)
			{
				class66_0.Dispose();
			}
		}
		finally
		{
			class66_0 = null;
			while (true)
			{
				int num;
				switch (Class52.smethod_4(37))
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
				class50_0 = null;
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
		Interface0 @interface = null;
		try
		{
			@interface = Class65_0.method_1(int_0);
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(string.Format(Class72.smethod_0("\uf156\uf155\uf156\uf151\uf158\uf114\uf159\uf104\uf114\uf14f\uf104\uf149\uf10e\uf114\uf14f\uf105\uf149", 61748), int_0, ex.Message), ex);
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

	private Interface0 method_1(int int_0)
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

	private Interface0 method_2(int int_0)
	{
		Class55 @class = class66_0.method_1(int_0);
		try
		{
			Interface0 @interface = Class62.smethod_0(class50_0, @class);
			if (@class.Boolean_5 || 1 == 0)
			{
				dictionary_0[int_0] = @interface;
			}
			return @interface;
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(string.Format(Class72.smethod_0("\ue6ff\ue6fc\ue6ff\ue6f8\ue6f1\ue6bd\ue6f0\ue6ac\ue6bd\ue6e6\ue6ad\ue6e0\ue6a7\ue6bd\ue6e6\ue6ac\ue6e0", 59037), int_0, ex.ToString()), ex);
		}
	}
}
