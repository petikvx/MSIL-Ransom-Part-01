using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Channels;
using Renci.SshNet.Common;

namespace Renci.SshNet;

public class ForwardedPortLocal : ForwardedPort, IDisposable
{
	private ForwardedPortStatus _status;

	private bool _isDisposed;

	private Socket _listener;

	private CountdownEvent _pendingChannelCountdown;

	public string BoundHost { get; private set; }

	public uint BoundPort { get; private set; }

	public string Host { get; private set; }

	public uint Port { get; private set; }

	public override bool IsStarted => _status == ForwardedPortStatus.Started;

	public ForwardedPortLocal(uint boundPort, string host, uint port)
		: this(string.Empty, boundPort, host, port)
	{
	}

	public ForwardedPortLocal(string boundHost, string host, uint port)
		: this(boundHost, 0u, host, port)
	{
	}

	public ForwardedPortLocal(string boundHost, uint boundPort, string host, uint port)
	{
		if (boundHost == null)
		{
			throw new ArgumentNullException("boundHost");
		}
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		boundPort.ValidatePort("boundPort");
		port.ValidatePort("port");
		BoundHost = boundHost;
		BoundPort = boundPort;
		Host = host;
		Port = port;
		_status = ForwardedPortStatus.Stopped;
	}

	protected override void StartPort()
	{
		if (!ForwardedPortStatus.ToStarting(ref _status))
		{
			return;
		}
		try
		{
			InternalStart();
		}
		catch (Exception)
		{
			_status = ForwardedPortStatus.Stopped;
			throw;
		}
	}

	protected override void StopPort(TimeSpan timeout)
	{
		if (ForwardedPortStatus.ToStopping(ref _status))
		{
			base.StopPort(timeout);
			StopListener();
			InternalStop(timeout);
			_status = ForwardedPortStatus.Stopped;
		}
	}

	protected override void CheckDisposed()
	{
		if (_isDisposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
	}

	private void InternalStart()
	{
		IPEndPoint iPEndPoint = new IPEndPoint(DnsAbstraction.GetHostAddresses(BoundHost)[0], (int)BoundPort);
		_listener = new Socket(iPEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
		{
			NoDelay = true
		};
		_listener.Bind(iPEndPoint);
		_listener.Listen(5);
		BoundPort = (uint)((IPEndPoint)_listener.LocalEndPoint).Port;
		base.Session.ErrorOccured += Session_ErrorOccured;
		base.Session.Disconnected += Session_Disconnected;
		InitializePendingChannelCountdown();
		_status = ForwardedPortStatus.Started;
		StartAccept(null);
	}

	private void StopListener()
	{
		_listener?.Dispose();
		ISession session = base.Session;
		if (session != null)
		{
			session.ErrorOccured -= Session_ErrorOccured;
			session.Disconnected -= Session_Disconnected;
		}
	}

	private void InternalStop(TimeSpan timeout)
	{
		_pendingChannelCountdown.Signal();
		_pendingChannelCountdown.Wait(timeout);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void InternalDispose(bool disposing)
	{
		if (disposing)
		{
			Socket listener = _listener;
			if (listener != null)
			{
				_listener = null;
				listener.Dispose();
			}
			CountdownEvent pendingChannelCountdown = _pendingChannelCountdown;
			if (pendingChannelCountdown != null)
			{
				_pendingChannelCountdown = null;
				pendingChannelCountdown.Dispose();
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (!_isDisposed)
		{
			base.Dispose(disposing);
			InternalDispose(disposing);
			_isDisposed = true;
		}
	}

	~ForwardedPortLocal()
	{
		Dispose(disposing: false);
	}

	private void StartAccept(SocketAsyncEventArgs e)
	{
		if (e == null)
		{
			e = new SocketAsyncEventArgs();
			e.Completed += AcceptCompleted;
		}
		else
		{
			e.AcceptSocket = null;
		}
		if (!IsStarted)
		{
			return;
		}
		try
		{
			if (!_listener.AcceptAsync(e))
			{
				AcceptCompleted(null, e);
			}
		}
		catch (ObjectDisposedException)
		{
			if (!(_status == ForwardedPortStatus.Stopped) && !(_status == ForwardedPortStatus.Stopped))
			{
				throw;
			}
		}
	}

	private void AcceptCompleted(object sender, SocketAsyncEventArgs e)
	{
		if (e.SocketError != SocketError.OperationAborted && e.SocketError != SocketError.NotSocket)
		{
			Socket acceptSocket = e.AcceptSocket;
			if (e.SocketError != 0)
			{
				StartAccept(e);
				CloseClientSocket(acceptSocket);
			}
			else
			{
				StartAccept(e);
				ProcessAccept(acceptSocket);
			}
		}
	}

	private void ProcessAccept(Socket clientSocket)
	{
		if (!IsStarted)
		{
			CloseClientSocket(clientSocket);
			return;
		}
		CountdownEvent pendingChannelCountdown = _pendingChannelCountdown;
		pendingChannelCountdown.AddCount();
		try
		{
			IPEndPoint iPEndPoint = (IPEndPoint)clientSocket.RemoteEndPoint;
			RaiseRequestReceived(iPEndPoint.Address.ToString(), (uint)iPEndPoint.Port);
			using IChannelDirectTcpip channelDirectTcpip = base.Session.CreateChannelDirectTcpip();
			channelDirectTcpip.Exception += Channel_Exception;
			channelDirectTcpip.Open(Host, Port, this, clientSocket);
			channelDirectTcpip.Bind();
		}
		catch (Exception exception)
		{
			RaiseExceptionEvent(exception);
			CloseClientSocket(clientSocket);
		}
		finally
		{
			try
			{
				pendingChannelCountdown.Signal();
			}
			catch (ObjectDisposedException)
			{
			}
		}
	}

	private void InitializePendingChannelCountdown()
	{
		Interlocked.Exchange(ref _pendingChannelCountdown, new CountdownEvent(1))?.Dispose();
	}

	private static void CloseClientSocket(Socket clientSocket)
	{
		if (clientSocket.Connected)
		{
			try
			{
				clientSocket.Shutdown(SocketShutdown.Send);
			}
			catch (Exception)
			{
			}
		}
		clientSocket.Dispose();
	}

	private void Session_Disconnected(object sender, EventArgs e)
	{
		ISession session = base.Session;
		if (session != null)
		{
			StopPort(session.ConnectionInfo.Timeout);
		}
	}

	private void Session_ErrorOccured(object sender, ExceptionEventArgs e)
	{
		ISession session = base.Session;
		if (session != null)
		{
			StopPort(session.ConnectionInfo.Timeout);
		}
	}

	private void Channel_Exception(object sender, ExceptionEventArgs e)
	{
		RaiseExceptionEvent(e.Exception);
	}
}
