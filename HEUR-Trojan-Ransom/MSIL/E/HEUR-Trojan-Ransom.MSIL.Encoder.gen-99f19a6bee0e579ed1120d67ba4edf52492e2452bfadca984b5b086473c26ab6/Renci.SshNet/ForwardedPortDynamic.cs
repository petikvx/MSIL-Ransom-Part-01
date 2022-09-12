using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Channels;
using Renci.SshNet.Common;

namespace Renci.SshNet;

public class ForwardedPortDynamic : ForwardedPort
{
	private ForwardedPortStatus _status;

	private bool _isDisposed;

	private Socket _listener;

	private CountdownEvent _pendingChannelCountdown;

	public string BoundHost { get; private set; }

	public uint BoundPort { get; private set; }

	public override bool IsStarted => _status == ForwardedPortStatus.Started;

	public ForwardedPortDynamic(uint port)
		: this(string.Empty, port)
	{
	}

	public ForwardedPortDynamic(string host, uint port)
	{
		BoundHost = host;
		BoundPort = port;
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
		InitializePendingChannelCountdown();
		IPAddress address = IPAddress.Any;
		if (!string.IsNullOrEmpty(BoundHost))
		{
			address = DnsAbstraction.GetHostAddresses(BoundHost)[0];
		}
		IPEndPoint iPEndPoint = new IPEndPoint(address, (int)BoundPort);
		_listener = new Socket(iPEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
		{
			NoDelay = true
		};
		_listener.Bind(iPEndPoint);
		_listener.Listen(5);
		base.Session.ErrorOccured += Session_ErrorOccured;
		base.Session.Disconnected += Session_Disconnected;
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

	~ForwardedPortDynamic()
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
			using IChannelDirectTcpip channelDirectTcpip = base.Session.CreateChannelDirectTcpip();
			channelDirectTcpip.Exception += Channel_Exception;
			if (!HandleSocks(channelDirectTcpip, clientSocket, base.Session.ConnectionInfo.Timeout))
			{
				CloseClientSocket(clientSocket);
			}
			else
			{
				channelDirectTcpip.Bind();
			}
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

	private bool HandleSocks(IChannelDirectTcpip channel, Socket clientSocket, TimeSpan timeout)
	{
		EventHandler value = delegate
		{
			CloseClientSocket(clientSocket);
		};
		base.Closing += value;
		try
		{
			int num = SocketAbstraction.ReadByte(clientSocket, timeout);
			return num switch
			{
				5 => HandleSocks5(clientSocket, channel, timeout), 
				4 => HandleSocks4(clientSocket, channel, timeout), 
				-1 => false, 
				_ => throw new NotSupportedException($"SOCKS version {num} is not supported."), 
			};
		}
		catch (SocketException ex)
		{
			if (ex.SocketErrorCode != SocketError.Interrupted)
			{
				RaiseExceptionEvent(ex);
			}
			return false;
		}
		finally
		{
			base.Closing -= value;
		}
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

	private bool HandleSocks4(Socket socket, IChannelDirectTcpip channel, TimeSpan timeout)
	{
		if (SocketAbstraction.ReadByte(socket, timeout) == -1)
		{
			return false;
		}
		byte[] array = new byte[2];
		if (SocketAbstraction.Read(socket, array, 0, array.Length, timeout) == 0)
		{
			return false;
		}
		uint port = (uint)(array[0] * 256 + array[1]);
		byte[] array2 = new byte[4];
		if (SocketAbstraction.Read(socket, array2, 0, array2.Length, timeout) == 0)
		{
			return false;
		}
		IPAddress iPAddress = new IPAddress(array2);
		if (ReadString(socket, timeout) == null)
		{
			return false;
		}
		string text = iPAddress.ToString();
		RaiseRequestReceived(text, port);
		channel.Open(text, port, this, socket);
		SocketAbstraction.SendByte(socket, 0);
		if (channel.IsOpen)
		{
			SocketAbstraction.SendByte(socket, 90);
			SocketAbstraction.Send(socket, array, 0, array.Length);
			SocketAbstraction.Send(socket, array2, 0, array2.Length);
			return true;
		}
		SocketAbstraction.SendByte(socket, 91);
		return false;
	}

	private bool HandleSocks5(Socket socket, IChannelDirectTcpip channel, TimeSpan timeout)
	{
		int num = SocketAbstraction.ReadByte(socket, timeout);
		if (num == -1)
		{
			return false;
		}
		byte[] array = new byte[num];
		if (SocketAbstraction.Read(socket, array, 0, array.Length, timeout) == 0)
		{
			return false;
		}
		if ((int)array.Min() == 0)
		{
			SocketAbstraction.Send(socket, new byte[2] { 5, 0 }, 0, 2);
		}
		else
		{
			SocketAbstraction.Send(socket, new byte[2] { 5, 255 }, 0, 2);
		}
		switch (SocketAbstraction.ReadByte(socket, timeout))
		{
		case -1:
			return false;
		default:
			throw new ProxyException("SOCKS5: Version 5 is expected.");
		case 5:
			if (SocketAbstraction.ReadByte(socket, timeout) == -1)
			{
				return false;
			}
			switch (SocketAbstraction.ReadByte(socket, timeout))
			{
			case -1:
				return false;
			default:
				throw new ProxyException("SOCKS5: 0 is expected for reserved byte.");
			case 0:
			{
				int num2 = SocketAbstraction.ReadByte(socket, timeout);
				if (num2 == -1)
				{
					return false;
				}
				string socks5Host = GetSocks5Host(num2, socket, timeout);
				if (socks5Host == null)
				{
					return false;
				}
				byte[] array2 = new byte[2];
				if (SocketAbstraction.Read(socket, array2, 0, array2.Length, timeout) == 0)
				{
					return false;
				}
				uint port = (uint)(array2[0] * 256 + array2[1]);
				RaiseRequestReceived(socks5Host, port);
				channel.Open(socks5Host, port, this, socket);
				byte[] array3 = CreateSocks5Reply(channel.IsOpen);
				SocketAbstraction.Send(socket, array3, 0, array3.Length);
				return true;
			}
			}
		}
	}

	private static string GetSocks5Host(int addressType, Socket socket, TimeSpan timeout)
	{
		switch (addressType)
		{
		case 1:
		{
			byte[] array2 = new byte[4];
			if (SocketAbstraction.Read(socket, array2, 0, 4, timeout) == 0)
			{
				return null;
			}
			return new IPAddress(array2).ToString();
		}
		default:
			throw new ProxyException($"SOCKS5: Address type '{addressType}' is not supported.");
		case 3:
		{
			int num = SocketAbstraction.ReadByte(socket, timeout);
			if (num == -1)
			{
				return null;
			}
			byte[] array3 = new byte[num];
			if (SocketAbstraction.Read(socket, array3, 0, array3.Length, timeout) == 0)
			{
				return null;
			}
			return SshData.Ascii.GetString(array3, 0, array3.Length);
		}
		case 4:
		{
			byte[] array = new byte[16];
			if (SocketAbstraction.Read(socket, array, 0, 16, timeout) == 0)
			{
				return null;
			}
			return new IPAddress(array).ToString();
		}
		}
	}

	private static byte[] CreateSocks5Reply(bool channelOpen)
	{
		byte[] array = new byte[10] { 5, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
		if (channelOpen)
		{
			array[1] = 0;
		}
		else
		{
			array[1] = 1;
		}
		array[2] = 0;
		array[3] = 1;
		return array;
	}

	private static string ReadString(Socket socket, TimeSpan timeout)
	{
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = new byte[1];
		while (true)
		{
			if (SocketAbstraction.Read(socket, array, 0, 1, timeout) != 0)
			{
				byte b = array[0];
				if (b == 0)
				{
					break;
				}
				char value = (char)b;
				stringBuilder.Append(value);
				continue;
			}
			return null;
		}
		return stringBuilder.ToString();
	}
}
