using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using ns12;
using ns2;
using ns21;

namespace MySql.Data.MySqlClient;

internal sealed class MySqlPool
{
	private readonly List<Class143> list_0;

	private readonly Queue<Class143> queue_0;

	private readonly uint uint_0;

	private readonly uint uint_1;

	private readonly AutoResetEvent autoResetEvent_0;

	private int int_0;

	[CompilerGenerated]
	private MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0;

	[CompilerGenerated]
	private readonly Class174 class174_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private Dictionary<string, string> dictionary_0;

	public MySqlConnectionStringBuilder Settings
	{
		[CompilerGenerated]
		get
		{
			return mySqlConnectionStringBuilder_0;
		}
		[CompilerGenerated]
		set
		{
			mySqlConnectionStringBuilder_0 = value;
		}
	}

	public Class174 ProcedureCache
	{
		[CompilerGenerated]
		get
		{
			return class174_0;
		}
	}

	private bool HasIdleConnections => queue_0.Count > 0;

	private int NumConnections => queue_0.Count + list_0.Count;

	public bool BeingCleared
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		private set
		{
			bool_0 = value;
		}
	}

	internal Dictionary<string, string> ServerProperties
	{
		[CompilerGenerated]
		get
		{
			return dictionary_0;
		}
		[CompilerGenerated]
		set
		{
			dictionary_0 = value;
		}
	}

	private void method_0(Class143 class143_0)
	{
		class143_0.IdleSince = DateTime.Now;
		queue_0.Enqueue(class143_0);
	}

	public MySqlPool(MySqlConnectionStringBuilder settings)
	{
		uint_0 = settings.MinimumPoolSize;
		uint_1 = settings.MaximumPoolSize;
		int_0 = (int)uint_1;
		autoResetEvent_0 = new AutoResetEvent(initialState: false);
		if (uint_0 > uint_1)
		{
			uint_0 = uint_1;
		}
		Settings = settings;
		list_0 = new List<Class143>((int)uint_1);
		queue_0 = new Queue<Class143>((int)uint_1);
		for (int i = 0; i < uint_0; i++)
		{
			method_0(method_2());
		}
		class174_0 = new Class174((int)settings.ProcedureCacheSize);
	}

	private Class143 method_1()
	{
		Class143 @class = null;
		lock (((ICollection)queue_0).SyncRoot)
		{
			if (HasIdleConnections)
			{
				@class = queue_0.Dequeue();
			}
		}
		if (@class != null)
		{
			try
			{
				@class.method_9((int)(Settings.ConnectionTimeout * 1000));
			}
			catch (Exception)
			{
				@class.vmethod_1();
				@class = null;
			}
		}
		if (@class != null)
		{
			if (!@class.method_10())
			{
				@class.vmethod_1();
				@class = null;
			}
			else if (Settings.ConnectionReset)
			{
				@class.vmethod_14();
			}
		}
		if (@class == null)
		{
			@class = method_2();
		}
		lock (((ICollection)list_0).SyncRoot)
		{
			list_0.Add(@class);
			return @class;
		}
	}

	private Class143 method_2()
	{
		Class143 @class = Class143.smethod_0(Settings);
		@class.Pool = this;
		return @class;
	}

	public void method_3(Class143 class143_0)
	{
		lock (((ICollection)list_0).SyncRoot)
		{
			if (list_0.Contains(class143_0))
			{
				list_0.Remove(class143_0);
			}
		}
		if (!class143_0.method_1() && !BeingCleared)
		{
			lock (((ICollection)queue_0).SyncRoot)
			{
				method_0(class143_0);
			}
		}
		else
		{
			class143_0.vmethod_1();
		}
		Interlocked.Increment(ref int_0);
		autoResetEvent_0.Set();
	}

	public void method_4(Class143 class143_0)
	{
		lock (((ICollection)list_0).SyncRoot)
		{
			if (list_0.Contains(class143_0))
			{
				list_0.Remove(class143_0);
				Interlocked.Increment(ref int_0);
				autoResetEvent_0.Set();
			}
		}
		if (BeingCleared && NumConnections == 0)
		{
			MySqlPoolManager.smethod_8(this);
		}
	}

	private Class143 method_5()
	{
		if (Interlocked.Decrement(ref int_0) < 0)
		{
			Interlocked.Increment(ref int_0);
			return null;
		}
		try
		{
			return method_1();
		}
		catch (Exception ex)
		{
			MySqlTrace.smethod_4(-1, ex.Message);
			Interlocked.Increment(ref int_0);
			throw;
		}
	}

	public Class143 method_6()
	{
		int num = (int)(Settings.ConnectionTimeout * 1000);
		int num2 = num;
		DateTime now = DateTime.Now;
		Class143 @class;
		while (true)
		{
			if (num2 > 0)
			{
				@class = method_5();
				if (@class != null)
				{
					break;
				}
				if (autoResetEvent_0.WaitOne(num2, exitContext: false))
				{
					num2 = num - (int)DateTime.Now.Subtract(now).TotalMilliseconds;
					continue;
				}
			}
			throw new MySqlException(Class121.TimeoutGettingConnection);
		}
		return @class;
	}

	internal void method_7()
	{
		lock (((ICollection)queue_0).SyncRoot)
		{
			BeingCleared = true;
			while (queue_0.Count > 0)
			{
				queue_0.Dequeue().vmethod_1();
			}
		}
	}

	internal List<Class143> method_8()
	{
		List<Class143> list = new List<Class143>();
		DateTime now = DateTime.Now;
		lock (((ICollection)queue_0).SyncRoot)
		{
			while (true)
			{
				if (queue_0.Count > uint_0)
				{
					Class143 @class = queue_0.Peek();
					if (@class.IdleSince.Add(new TimeSpan(0, 0, MySqlPoolManager.int_0)).CompareTo(now) < 0)
					{
						list.Add(@class);
						queue_0.Dequeue();
						continue;
					}
					break;
				}
				return list;
			}
			return list;
		}
	}
}
