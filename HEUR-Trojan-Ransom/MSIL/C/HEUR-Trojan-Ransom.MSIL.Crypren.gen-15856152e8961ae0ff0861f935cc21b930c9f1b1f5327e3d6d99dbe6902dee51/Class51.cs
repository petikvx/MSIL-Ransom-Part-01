using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;

internal sealed class Class51 : IDisposable
{
	public static volatile Class51 class51_0;

	private static readonly object object_0;

	private ReaderWriterLock readerWriterLock_0;

	private Dictionary<int, Interface0> dictionary_0;

	private Class52 class52_0;

	private Class36 class36_0;

	public static Class51 Class51_0
	{
		get
		{
			if (class51_0 == null && 0 == 0)
			{
				try
				{
					Monitor.Enter(object_0);
					if (class51_0 == null && 0 == 0)
					{
						class51_0 = new Class51();
						GC.SuppressFinalize(class51_0);
					}
				}
				finally
				{
					Monitor.Exit(object_0);
				}
			}
			return class51_0;
		}
	}

	static Class51()
	{
		class51_0 = null;
		object_0 = new object();
	}

	private Class51()
	{
		readerWriterLock_0 = new ReaderWriterLock();
		int num;
		while (true)
		{
			switch (Class64.smethod_0(92))
			{
			default:
				continue;
			case 0:
				dictionary_0 = new Dictionary<int, Interface0>();
				num = 2;
				goto case 2;
			case 2:
				class52_0 = new Class52();
				num = 3;
				goto case 3;
			case 3:
				class36_0 = new Class36();
				num = 1;
				break;
			case 1:
				break;
			case 4:
				return;
			}
			break;
		}
		GC.SuppressFinalize(class52_0);
		num = 4;
	}

	~Class51()
	{
		method_0(bool_0: false);
	}

	public void method_0(bool bool_0)
	{
		try
		{
			if (bool_0 || 1 == 0)
			{
				class52_0.Dispose();
			}
		}
		finally
		{
			class52_0 = null;
			while (true)
			{
				int num;
				switch (Class64.smethod_0(79))
				{
				default:
					continue;
				case 1:
					dictionary_0 = null;
					num = 0;
					break;
				case 0:
					break;
				case 2:
					goto end_IL_001d;
				}
				class36_0 = null;
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
			@interface = Class51_0.method_1(int_0);
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(string.Format(Class58.smethod_0("\uf24f\uf24c\uf24f\uf248\uf241\uf20d\uf240\uf21d\uf20d\uf256\uf21d\uf250\uf217\uf20d\uf256\uf21c\uf250", 61997), int_0, ex.Message), ex);
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
		Class41 @class = class52_0.method_1(int_0);
		try
		{
			Interface0 @interface = Class48.smethod_0(class36_0, @class);
			if (@class.Boolean_5 || 1 == 0)
			{
				dictionary_0[int_0] = @interface;
			}
			return @interface;
		}
		catch (Exception ex)
		{
			throw new InvalidOperationException(string.Format(Class58.smethod_0("\uef53\uef50\uef53\uef54\uef5d\uef11\uef5c\uef00\uef11\uef4a\uef01\uef4c\uef0b\uef11\uef4a\uef00\uef4c", 61233), int_0, ex.ToString()), ex);
		}
	}
}
