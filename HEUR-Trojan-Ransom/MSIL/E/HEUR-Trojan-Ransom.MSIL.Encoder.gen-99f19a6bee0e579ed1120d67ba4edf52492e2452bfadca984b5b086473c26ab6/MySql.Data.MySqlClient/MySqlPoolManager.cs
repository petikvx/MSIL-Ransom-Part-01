using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Principal;
using System.Threading;

namespace MySql.Data.MySqlClient;

internal class MySqlPoolManager
{
	private static readonly Dictionary<string, MySqlPool> Pools;

	private static readonly List<MySqlPool> ClearingPools;

	internal static int maxConnectionIdleTime;

	private static Timer timer;

	static MySqlPoolManager()
	{
		Pools = new Dictionary<string, MySqlPool>();
		ClearingPools = new List<MySqlPool>();
		maxConnectionIdleTime = 180;
		timer = new Timer(CleanIdleConnections, null, maxConnectionIdleTime * 1000 + 8000, maxConnectionIdleTime * 1000);
		AppDomain.CurrentDomain.ProcessExit += EnsureClearingPools;
		AppDomain.CurrentDomain.DomainUnload += EnsureClearingPools;
	}

	private static void EnsureClearingPools(object sender, EventArgs e)
	{
		ClearAllPools();
	}

	private static string GetKey(MySqlConnectionStringBuilder settings)
	{
		string text = "";
		lock (settings)
		{
			text = settings.ConnectionString;
		}
		if (settings.IntegratedSecurity && !settings.ConnectionReset)
		{
			try
			{
				WindowsIdentity current = WindowsIdentity.GetCurrent();
				return text + ";" + current.User;
			}
			catch (SecurityException ex)
			{
				throw new MySqlException(Resources.NoWindowsIdentity, ex);
			}
		}
		return text;
	}

	public static MySqlPool GetPool(MySqlConnectionStringBuilder settings)
	{
		string key = GetKey(settings);
		lock (Pools)
		{
			Pools.TryGetValue(key, out var value);
			if (value == null)
			{
				value = new MySqlPool(settings);
				Pools.Add(key, value);
			}
			else
			{
				value.Settings = settings;
			}
			return value;
		}
	}

	public static void RemoveConnection(Driver driver)
	{
		driver.Pool?.RemoveConnection(driver);
	}

	public static void ReleaseConnection(Driver driver)
	{
		driver.Pool?.ReleaseConnection(driver);
	}

	public static void ClearPool(MySqlConnectionStringBuilder settings)
	{
		string key;
		try
		{
			key = GetKey(settings);
		}
		catch (MySqlException)
		{
			return;
		}
		ClearPoolByText(key);
	}

	private static void ClearPoolByText(string key)
	{
		lock (Pools)
		{
			if (Pools.ContainsKey(key))
			{
				MySqlPool mySqlPool = Pools[key];
				ClearingPools.Add(mySqlPool);
				mySqlPool.Clear();
				Pools.Remove(key);
			}
		}
	}

	public static void ClearAllPools()
	{
		lock (Pools)
		{
			List<string> list = new List<string>(Pools.Count);
			list.AddRange(Pools.Keys);
			foreach (string item in list)
			{
				ClearPoolByText(item);
			}
		}
	}

	public static void RemoveClearedPool(MySqlPool pool)
	{
		ClearingPools.Remove(pool);
	}

	public static void CleanIdleConnections(object obj)
	{
		List<Driver> list = new List<Driver>();
		lock (Pools)
		{
			foreach (MySqlPool item in Pools.Keys.Select((string key) => Pools[key]))
			{
				list.AddRange(item.RemoveOldIdleConnections());
			}
		}
		foreach (Driver item2 in list)
		{
			item2.Close();
		}
	}
}
