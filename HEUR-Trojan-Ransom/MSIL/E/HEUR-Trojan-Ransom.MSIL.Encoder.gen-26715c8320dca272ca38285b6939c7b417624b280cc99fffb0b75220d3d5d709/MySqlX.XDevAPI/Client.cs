using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using MySql.Data;
using MySql.Data.Common;
using MySql.Data.Failover;
using MySql.Data.MySqlClient;
using MySqlX.Common;

namespace MySqlX.XDevAPI;

public class Client : IDisposable
{
	private class ClientSession : BaseSession
	{
	}

	internal class ConnectionOptions
	{
		internal class PoolingStruct
		{
			private int _maxSize;

			private int _maxIdleTime;

			private int _queueTimeout;

			public bool Enabled { get; set; }

			public int MaxSize
			{
				get
				{
					return _maxSize;
				}
				set
				{
					if (value <= 0)
					{
						throw new ArgumentException("MaxSize");
					}
					_maxSize = value;
				}
			}

			public int MaxIdleTime
			{
				get
				{
					return _maxIdleTime;
				}
				set
				{
					if (value < 0)
					{
						throw new ArgumentException("MaxIdleTime");
					}
					_maxIdleTime = value;
				}
			}

			public int QueueTimeout
			{
				get
				{
					return _queueTimeout;
				}
				set
				{
					if (value < 0)
					{
						throw new ArgumentException("QueueTimeout");
					}
					_queueTimeout = value;
				}
			}
		}

		public PoolingStruct Pooling { get; set; } = new PoolingStruct
		{
			Enabled = true,
			MaxSize = 25
		};


		public override bool Equals(object obj)
		{
			if (!(obj is ConnectionOptions))
			{
				return false;
			}
			return Equals(this, obj);
		}

		private new bool Equals(object x, object y)
		{
			if (x.GetType() != y.GetType())
			{
				return false;
			}
			PropertyInfo[] properties = x.GetType().GetProperties();
			int num = 0;
			while (true)
			{
				if (num < properties.Length)
				{
					PropertyInfo propertyInfo = properties[num];
					if (!propertyInfo.PropertyType.IsNested)
					{
						if (!propertyInfo.GetValue(x)!.Equals(propertyInfo.GetValue(y)))
						{
							break;
						}
						num++;
						continue;
					}
					return Equals(propertyInfo.GetValue(x), propertyInfo.GetValue(y));
				}
				return true;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}

	private string _connectionString;

	private ConnectionOptions _connectionOptions;

	private List<Session> _inUse;

	private ConcurrentQueue<Session> _inIdle;

	private int _available;

	private AutoResetEvent _autoResetEvent;

	private Timer _idleTimer;

	private bool _isClosed;

	internal const int DEMOTED_TIMEOUT = 120000;

	private readonly object _dnsSrvLock = new object();

	private bool disposedValue;

	internal ConcurrentQueue<FailoverServer> DemotedHosts { get; set; }

	internal List<FailoverServer> Hosts { get; set; }

	internal Timer DemotedServersTimer { get; set; }

	internal Client(object connectionString, object connectionOptions)
	{
		if (connectionString != null && (!(connectionString is string) || !string.IsNullOrWhiteSpace(connectionString as string)))
		{
			if (connectionOptions != null && (!(connectionOptions is string) || !string.IsNullOrWhiteSpace(connectionOptions as string)))
			{
				bool isDefaultPort = true;
				if (connectionString is string)
				{
					isDefaultPort = !connectionString.ToString()!.Contains("port");
					new MySqlXConnectionStringBuilder(new ClientSession().ParseConnectionData(connectionString as string), isDefaultPort);
					_connectionString = connectionString as string;
				}
				else
				{
					MySqlXConnectionStringBuilder mySqlXConnectionStringBuilder = new MySqlXConnectionStringBuilder();
					foreach (KeyValuePair<string, object> dictionaryFromAnonymou in Tools.GetDictionaryFromAnonymous(connectionString))
					{
						if (mySqlXConnectionStringBuilder.ContainsKey(dictionaryFromAnonymou.Key))
						{
							mySqlXConnectionStringBuilder.SetValue(dictionaryFromAnonymou.Key, dictionaryFromAnonymou.Value, ".ctor");
							if (dictionaryFromAnonymou.Key == "port")
							{
								isDefaultPort = false;
							}
							continue;
						}
						throw new KeyNotFoundException(string.Format(ResourcesX.InvalidConnectionStringAttribute, dictionaryFromAnonymou.Key));
					}
					_connectionString = mySqlXConnectionStringBuilder.ToString().Replace("\"", "");
					mySqlXConnectionStringBuilder.AnalyzeConnectionString(_connectionString, isXProtocol: true, isDefaultPort);
				}
				_connectionOptions = ParseConnectionOptions(connectionOptions);
				_inUse = new List<Session>(_connectionOptions.Pooling.MaxSize);
				_inIdle = new ConcurrentQueue<Session>();
				_available = _connectionOptions.Pooling.MaxSize;
				_autoResetEvent = new AutoResetEvent(initialState: false);
				_idleTimer = new Timer(CleanIdleConnections, null, _connectionOptions.Pooling.MaxIdleTime, (_connectionOptions.Pooling.MaxIdleTime == 0) ? (-1) : _connectionOptions.Pooling.MaxIdleTime);
				return;
			}
			throw new ArgumentNullException("connectionOptions");
		}
		throw new ArgumentNullException("connectionString");
	}

	internal void ReleaseDemotedHosts(object state)
	{
		FailoverServer result;
		while (!DemotedHosts.IsEmpty && DemotedHosts.TryPeek(out result) && result.DemotedTime.AddMilliseconds(120000.0) < DateTime.Now)
		{
			result.Attempted = false;
			Hosts?.Add(result);
			DemotedHosts.TryDequeue(out result);
		}
		if (!disposedValue)
		{
			DemotedServersTimer?.Change(120000, -1);
		}
	}

	private void CleanIdleConnections(object state)
	{
		List<Session> list = new List<Session>();
		while (!_inIdle.IsEmpty)
		{
			if (_inIdle.TryPeek(out var result))
			{
				if (!(result.IdleSince.AddMilliseconds(_connectionOptions.Pooling.MaxIdleTime) < DateTime.Now))
				{
					break;
				}
				if (_inIdle.TryDequeue(out var result2))
				{
					list.Add(result2);
				}
			}
		}
		foreach (Session item in list)
		{
			try
			{
				item.CloseFully();
			}
			catch
			{
			}
		}
	}

	public Session GetSession()
	{
		if (_isClosed)
		{
			throw new MySqlException(ResourcesX.ClientIsClosed);
		}
		if (!_connectionOptions.Pooling.Enabled)
		{
			return new Session(_connectionString);
		}
		int queueTimeout = _connectionOptions.Pooling.QueueTimeout;
		int num = queueTimeout;
		Stopwatch stopwatch = Stopwatch.StartNew();
		Session session;
		while (true)
		{
			if (num >= 0)
			{
				session = TryToGetSession();
				if (session != null)
				{
					break;
				}
				if (_autoResetEvent.WaitOne((queueTimeout == 0) ? (-1) : num))
				{
					num = queueTimeout - (int)stopwatch.ElapsedMilliseconds;
					continue;
				}
			}
			stopwatch.Stop();
			throw new TimeoutException(ResourcesX.PoolingQueueTimeout);
		}
		return session;
	}

	private Session TryToGetSession()
	{
		if (Interlocked.Decrement(ref _available) < 0)
		{
			Interlocked.Increment(ref _available);
			return null;
		}
		try
		{
			return GetPooledSession();
		}
		catch (Exception)
		{
			Interlocked.Increment(ref _available);
			throw;
		}
	}

	private Session GetPooledSession()
	{
		Session result = null;
		while (!_inIdle.IsEmpty && result == null)
		{
			if (!_inIdle.TryDequeue(out result))
			{
				continue;
			}
			try
			{
				result.Reset();
				if (result.XSession.sessionResetNoReauthentication == false)
				{
					result.XSession.Authenticate();
				}
				result.XSession.SetState(SessionState.Open, broadcast: false);
			}
			catch
			{
				result = null;
				CleanIdleConnections(null);
			}
		}
		if (result == null)
		{
			result = CreateNewSession();
		}
		_inUse.Add(result);
		return result;
	}

	private Session CreateNewSession()
	{
		return new Session(_connectionString, this);
	}

	internal void ReleaseSession(BaseSession session)
	{
		Session session2 = new Session(session.InternalSession, this);
		if (_inUse.Contains((Session)session))
		{
			_inUse.Remove((Session)session);
			Interlocked.Increment(ref _available);
		}
		try
		{
			session2.Reset();
			session2.IdleSince = DateTime.Now;
			_inIdle.Enqueue(session2);
		}
		catch
		{
			session2 = null;
		}
		lock (_dnsSrvLock)
		{
			if (session.Settings.DnsSrv)
			{
				FailoverManager.SetHostList(DnsResolver.GetDnsSrvRecords(DnsResolver.ServiceName).ConvertAll((DnsSrvRecord r) => new FailoverServer(r.Target, r.Port, null)), FailoverMethod.Sequential);
				foreach (Session item in _inIdle)
				{
					string idleServer = item.Settings.Server;
					if (!FailoverManager.FailoverGroup.Hosts.Exists((FailoverServer h) => h.Host == idleServer) && !_inUse.Contains(item))
					{
						_inIdle.TryDequeue(out var _);
					}
				}
			}
		}
		_autoResetEvent.Set();
	}

	public void Close()
	{
		if (_isClosed)
		{
			return;
		}
		_isClosed = true;
		_idleTimer.Change(0, -1);
		foreach (Session item in _inUse)
		{
			try
			{
				item.CloseFully();
			}
			catch
			{
			}
		}
		while (!_inIdle.IsEmpty)
		{
			if (_inIdle.TryDequeue(out var result))
			{
				try
				{
					result.CloseFully();
				}
				catch
				{
				}
			}
		}
		if (DemotedServersTimer != null)
		{
			DemotedServersTimer.Change(0, -1);
			while (!DemotedHosts.IsEmpty)
			{
				DemotedHosts.TryDequeue(out var _);
			}
			Hosts?.Clear();
		}
		FailoverManager.Reset();
		Interlocked.Exchange(ref _available, -1);
	}

	internal static ConnectionOptions ParseConnectionOptions(object connectionOptions)
	{
		DbDoc dbDoc;
		try
		{
			dbDoc = new DbDoc(connectionOptions);
		}
		catch (Exception innerException)
		{
			throw new ArgumentException(string.Format(ResourcesX.ClientOptionNotValid, "JSON"), innerException);
		}
		if (dbDoc != null && dbDoc.values.Count != 0)
		{
			ConnectionOptions connectionOptions2 = new ConnectionOptions();
			Type type = connectionOptions2.GetType();
			{
				foreach (KeyValuePair<string, object> value2 in dbDoc.values)
				{
					PropertyInfo property = type.GetProperty(value2.Key, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
					if (!(property == null))
					{
						object value = property.GetValue(connectionOptions2);
						if (property.DeclaringType!.IsNested)
						{
							DbDoc dbDoc2;
							try
							{
								dbDoc2 = new DbDoc(value2.Value);
							}
							catch (Exception innerException2)
							{
								throw new ArgumentException(string.Format(ResourcesX.ClientOptionInvalidValue, value2.Key, "JSON"), innerException2);
							}
							if (dbDoc2 == null || dbDoc2.values.Count == 0)
							{
								throw new ArgumentException(string.Format(ResourcesX.ClientOptionInvalidValue, value2.Key, value2.Value));
							}
							foreach (KeyValuePair<string, object> value3 in dbDoc2.values)
							{
								PropertyInfo property2 = property.PropertyType.GetProperty(value3.Key, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
								if (!(property2 == null))
								{
									try
									{
										property2.SetValue(value, value3.Value);
									}
									catch (Exception innerException3)
									{
										object obj = value3.Value;
										if (obj is MySqlExpression mySqlExpression)
										{
											obj = mySqlExpression.value.Trim();
										}
										throw new ArgumentException(string.Format(ResourcesX.ClientOptionInvalidValue, value2.Key + "." + value3.Key, obj), innerException3);
									}
									continue;
								}
								throw new ArgumentException(string.Format(ResourcesX.ClientOptionNotValid, value2.Key + "." + value3.Key));
							}
						}
						property.SetValue(connectionOptions2, value);
						continue;
					}
					throw new ArgumentException(string.Format(ResourcesX.ClientOptionNotValid, value2.Key));
				}
				return connectionOptions2;
			}
		}
		throw new ArgumentException(string.Format(ResourcesX.ClientOptionNotValid, connectionOptions));
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposedValue)
		{
			return;
		}
		if (disposing)
		{
			Close();
			_idleTimer.Dispose();
			_inUse.Clear();
			if (DemotedServersTimer != null)
			{
				DemotedServersTimer.Dispose();
			}
		}
		disposedValue = true;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}
}
