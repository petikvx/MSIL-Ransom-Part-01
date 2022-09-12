using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using MySql.Data.Common;
using MySql.Data.Failover;

namespace MySql.Data.MySqlClient;

internal sealed class MySqlPool
{
	private readonly List<Driver> _inUsePool;

	private readonly Queue<Driver> _idlePool;

	private readonly uint _minSize;

	private readonly uint _maxSize;

	private readonly AutoResetEvent _autoEvent;

	private int _available;

	private readonly object _dnsSrvLock = new object();

	public MySqlConnectionStringBuilder Settings { get; set; }

	public ProcedureCache ProcedureCache { get; }

	private bool HasIdleConnections => _idlePool.Count > 0;

	private int NumConnections => _idlePool.Count + _inUsePool.Count;

	public bool BeingCleared { get; private set; }

	internal Dictionary<string, string> ServerProperties { get; set; }

	private void EnqueueIdle(Driver driver)
	{
		driver.IdleSince = DateTime.Now;
		_idlePool.Enqueue(driver);
	}

	public MySqlPool(MySqlConnectionStringBuilder settings)
	{
		_minSize = settings.MinimumPoolSize;
		_maxSize = settings.MaximumPoolSize;
		_available = (int)_maxSize;
		_autoEvent = new AutoResetEvent(initialState: false);
		if (_minSize > _maxSize)
		{
			_minSize = _maxSize;
		}
		Settings = settings;
		_inUsePool = new List<Driver>((int)_maxSize);
		_idlePool = new Queue<Driver>((int)_maxSize);
		for (int i = 0; i < _minSize; i++)
		{
			EnqueueIdle(CreateNewPooledConnection());
		}
		ProcedureCache = new ProcedureCache((int)settings.ProcedureCacheSize);
	}

	private Driver GetPooledConnection()
	{
		Driver driver = null;
		lock (((ICollection)_idlePool).SyncRoot)
		{
			if (HasIdleConnections)
			{
				driver = _idlePool.Dequeue();
			}
		}
		if (driver != null)
		{
			try
			{
				driver.ResetTimeout((int)(Settings.ConnectionTimeout * 1000));
			}
			catch (Exception)
			{
				driver.Close();
				driver = null;
			}
		}
		if (driver != null)
		{
			if (!driver.Ping())
			{
				driver.Close();
				driver = null;
			}
			else if (Settings.ConnectionReset)
			{
				try
				{
					driver.Reset();
				}
				catch (Exception)
				{
					Clear();
				}
			}
		}
		if (driver == null)
		{
			driver = CreateNewPooledConnection();
		}
		lock (((ICollection)_inUsePool).SyncRoot)
		{
			_inUsePool.Add(driver);
			return driver;
		}
	}

	private Driver CreateNewPooledConnection()
	{
		Driver driver = Driver.Create(Settings);
		driver.Pool = this;
		return driver;
	}

	public void ReleaseConnection(Driver driver)
	{
		lock (((ICollection)_inUsePool).SyncRoot)
		{
			if (_inUsePool.Contains(driver))
			{
				_inUsePool.Remove(driver);
			}
		}
		if (!driver.ConnectionLifetimeExpired() && !BeingCleared)
		{
			lock (((ICollection)_idlePool).SyncRoot)
			{
				EnqueueIdle(driver);
			}
		}
		else
		{
			driver.Close();
		}
		lock (_dnsSrvLock)
		{
			if (driver.Settings.DnsSrv)
			{
				FailoverManager.SetHostList(DnsResolver.GetDnsSrvRecords(DnsResolver.ServiceName).ConvertAll((DnsSrvRecord r) => new FailoverServer(r.Target, r.Port, null)), FailoverMethod.Sequential);
				foreach (Driver item in _idlePool)
				{
					string idleServer = item.Settings.Server;
					if (!FailoverManager.FailoverGroup.Hosts.Exists((FailoverServer h) => h.Host == idleServer) && !item.IsInActiveUse)
					{
						item.Close();
					}
				}
			}
		}
		Interlocked.Increment(ref _available);
		_autoEvent.Set();
	}

	public void RemoveConnection(Driver driver)
	{
		lock (((ICollection)_inUsePool).SyncRoot)
		{
			if (_inUsePool.Contains(driver))
			{
				_inUsePool.Remove(driver);
				Interlocked.Increment(ref _available);
				_autoEvent.Set();
			}
		}
		if (BeingCleared && NumConnections == 0)
		{
			MySqlPoolManager.RemoveClearedPool(this);
		}
	}

	private Driver TryToGetDriver()
	{
		if (Interlocked.Decrement(ref _available) < 0)
		{
			Interlocked.Increment(ref _available);
			return null;
		}
		try
		{
			return GetPooledConnection();
		}
		catch (Exception ex)
		{
			MySqlTrace.LogError(-1, ex.Message);
			Interlocked.Increment(ref _available);
			throw;
		}
	}

	public Driver GetConnection()
	{
		int num = (int)(Settings.ConnectionTimeout * 1000);
		int num2 = num;
		DateTime now = DateTime.Now;
		Driver driver;
		while (true)
		{
			if (num2 > 0)
			{
				driver = TryToGetDriver();
				if (driver != null)
				{
					break;
				}
				if (_autoEvent.WaitOne(num2, exitContext: false))
				{
					num2 = num - (int)DateTime.Now.Subtract(now).TotalMilliseconds;
					continue;
				}
			}
			throw new MySqlException(Resources.TimeoutGettingConnection);
		}
		return driver;
	}

	internal void Clear()
	{
		lock (((ICollection)_idlePool).SyncRoot)
		{
			BeingCleared = true;
			while (_idlePool.Count > 0)
			{
				_idlePool.Dequeue().Close();
			}
		}
	}

	internal List<Driver> RemoveOldIdleConnections()
	{
		List<Driver> list = new List<Driver>();
		DateTime now = DateTime.Now;
		lock (((ICollection)_idlePool).SyncRoot)
		{
			while (true)
			{
				if (_idlePool.Count > _minSize)
				{
					Driver driver = _idlePool.Peek();
					if (driver.IdleSince.Add(new TimeSpan(0, 0, MySqlPoolManager.maxConnectionIdleTime)).CompareTo(now) < 0)
					{
						list.Add(driver);
						_idlePool.Dequeue();
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
