using System;
using System.Threading;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Transport;

namespace Renci.SshNet;

public abstract class BaseClient : IDisposable
{
	private readonly bool _ownsConnectionInfo;

	private readonly IServiceFactory _serviceFactory;

	private readonly object _keepAliveLock = new object();

	private TimeSpan _keepAliveInterval;

	private Timer _keepAliveTimer;

	private ConnectionInfo _connectionInfo;

	private bool _isDisposed;

	internal ISession Session { get; private set; }

	internal IServiceFactory ServiceFactory => _serviceFactory;

	public ConnectionInfo ConnectionInfo
	{
		get
		{
			CheckDisposed();
			return _connectionInfo;
		}
		private set
		{
			_connectionInfo = value;
		}
	}

	public bool IsConnected
	{
		get
		{
			CheckDisposed();
			if (Session != null)
			{
				return Session.IsConnected;
			}
			return false;
		}
	}

	public TimeSpan KeepAliveInterval
	{
		get
		{
			CheckDisposed();
			return _keepAliveInterval;
		}
		set
		{
			CheckDisposed();
			if (!(value == _keepAliveInterval))
			{
				if (value == Renci.SshNet.Session.InfiniteTimeSpan)
				{
					StopKeepAliveTimer();
				}
				else if (_keepAliveTimer != null)
				{
					_keepAliveTimer.Change(value, value);
				}
				_keepAliveInterval = value;
			}
		}
	}

	public event EventHandler<ExceptionEventArgs> ErrorOccurred;

	public event EventHandler<HostKeyEventArgs> HostKeyReceived;

	protected BaseClient(ConnectionInfo connectionInfo, bool ownsConnectionInfo)
		: this(connectionInfo, ownsConnectionInfo, new ServiceFactory())
	{
	}

	internal BaseClient(ConnectionInfo connectionInfo, bool ownsConnectionInfo, IServiceFactory serviceFactory)
	{
		if (connectionInfo == null)
		{
			throw new ArgumentNullException("connectionInfo");
		}
		if (serviceFactory == null)
		{
			throw new ArgumentNullException("serviceFactory");
		}
		ConnectionInfo = connectionInfo;
		_ownsConnectionInfo = ownsConnectionInfo;
		_serviceFactory = serviceFactory;
		_keepAliveInterval = Renci.SshNet.Session.InfiniteTimeSpan;
	}

	public void Connect()
	{
		CheckDisposed();
		if (Session != null && Session.IsConnected)
		{
			throw new InvalidOperationException("The client is already connected.");
		}
		OnConnecting();
		Session = _serviceFactory.CreateSession(ConnectionInfo);
		Session.HostKeyReceived += Session_HostKeyReceived;
		Session.ErrorOccured += Session_ErrorOccured;
		Session.Connect();
		StartKeepAliveTimer();
		OnConnected();
	}

	public void Disconnect()
	{
		CheckDisposed();
		OnDisconnecting();
		StopKeepAliveTimer();
		if (Session != null)
		{
			Session.ErrorOccured -= Session_ErrorOccured;
			Session.HostKeyReceived -= Session_HostKeyReceived;
			Session.Dispose();
			Session = null;
		}
		OnDisconnected();
	}

	[Obsolete("Use KeepAliveInterval to send a keep-alive message at regular intervals.")]
	public void SendKeepAlive()
	{
		CheckDisposed();
		SendKeepAliveMessage();
	}

	protected virtual void OnConnecting()
	{
	}

	protected virtual void OnConnected()
	{
	}

	protected virtual void OnDisconnecting()
	{
		if (Session != null)
		{
			Session.OnDisconnecting();
		}
	}

	protected virtual void OnDisconnected()
	{
	}

	private void Session_ErrorOccured(object sender, ExceptionEventArgs e)
	{
		this.ErrorOccurred?.Invoke(this, e);
	}

	private void Session_HostKeyReceived(object sender, HostKeyEventArgs e)
	{
		this.HostKeyReceived?.Invoke(this, e);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (_isDisposed || !disposing)
		{
			return;
		}
		Disconnect();
		if (_ownsConnectionInfo && _connectionInfo != null)
		{
			if (_connectionInfo is IDisposable disposable)
			{
				disposable.Dispose();
			}
			_connectionInfo = null;
		}
		_isDisposed = true;
	}

	protected void CheckDisposed()
	{
		if (_isDisposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
	}

	~BaseClient()
	{
		Dispose(disposing: false);
	}

	private void StopKeepAliveTimer()
	{
		if (_keepAliveTimer != null)
		{
			_keepAliveTimer.Dispose();
			_keepAliveTimer = null;
		}
	}

	private void SendKeepAliveMessage()
	{
		if (Session == null || !Monitor.TryEnter(_keepAliveLock))
		{
			return;
		}
		try
		{
			Session.TrySendMessage(new IgnoreMessage());
		}
		finally
		{
			Monitor.Exit(_keepAliveLock);
		}
	}

	private void StartKeepAliveTimer()
	{
		if (!(_keepAliveInterval == Renci.SshNet.Session.InfiniteTimeSpan) && _keepAliveTimer == null)
		{
			_keepAliveTimer = new Timer(delegate
			{
				SendKeepAliveMessage();
			}, null, _keepAliveInterval, _keepAliveInterval);
		}
	}
}
