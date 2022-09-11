using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace VanillaStub.Helpers.Telepathy;

public class Server : Common
{
	private class ClientToken
	{
		public readonly TcpClient client;

		public readonly ManualResetEvent sendPending = new ManualResetEvent(initialState: false);

		public readonly SafeQueue<byte[]> sendQueue = new SafeQueue<byte[]>();

		public ClientToken(TcpClient client)
		{
			this.client = client;
		}
	}

	private static int counter;

	private readonly ConcurrentDictionary<int, ClientToken> clients = new ConcurrentDictionary<int, ClientToken>();

	public TcpListener listener;

	private Thread listenerThread;

	public bool Active
	{
		get
		{
			if (listenerThread != null)
			{
				return listenerThread.IsAlive;
			}
			return false;
		}
	}

	public static int NextConnectionId()
	{
		int num = Interlocked.Increment(ref counter);
		if (num == int.MaxValue)
		{
			throw new Exception("connection id limit reached: " + num);
		}
		return num;
	}

	private void Listen(int port)
	{
		try
		{
			listener = new TcpListener(new IPEndPoint(IPAddress.Any, port));
			listener.Server.NoDelay = NoDelay;
			listener.Server.SendTimeout = SendTimeout;
			listener.Start();
			Logger.Log("Server: listening port=" + port);
			while (true)
			{
				TcpClient client = listener.AcceptTcpClient();
				int connectionId = NextConnectionId();
				ClientToken token = new ClientToken(client);
				clients[connectionId] = token;
				Thread sendThread = new Thread((ThreadStart)delegate
				{
					try
					{
						Common.SendLoop(connectionId, client, token.sendQueue, token.sendPending);
					}
					catch (ThreadAbortException)
					{
					}
					catch (Exception ex6)
					{
						Logger.LogError("Server send thread exception: " + ex6);
					}
				});
				sendThread.IsBackground = true;
				sendThread.Start();
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						Common.ReceiveLoop(connectionId, client, receiveQueue, MaxMessageSize);
						clients.TryRemove(connectionId, out var _);
						sendThread.Interrupt();
					}
					catch (Exception ex4)
					{
						Logger.LogError("Server client thread exception: " + ex4);
					}
				});
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch (ThreadAbortException ex)
		{
			Logger.Log("Server thread aborted. That's okay. " + ex);
		}
		catch (SocketException ex2)
		{
			Logger.Log("Server Thread stopped. That's okay. " + ex2);
		}
		catch (Exception ex3)
		{
			Logger.LogError("Server Exception: " + ex3);
		}
	}

	public bool Start(int port)
	{
		if (Active)
		{
			return false;
		}
		receiveQueue = new ConcurrentQueue<Message>();
		Logger.Log("Server: Start port=" + port);
		listenerThread = new Thread((ThreadStart)delegate
		{
			Listen(port);
		});
		listenerThread.IsBackground = true;
		listenerThread.Priority = ThreadPriority.BelowNormal;
		listenerThread.Start();
		return true;
	}

	public void Stop()
	{
		if (!Active)
		{
			return;
		}
		Logger.Log("Server: stopping...");
		listener?.Stop();
		listenerThread?.Interrupt();
		listenerThread = null;
		foreach (KeyValuePair<int, ClientToken> client2 in clients)
		{
			TcpClient client = client2.Value.client;
			try
			{
				client.GetStream().Close();
			}
			catch
			{
			}
			client.Close();
		}
		clients.Clear();
	}

	public bool Send(int connectionId, byte[] data)
	{
		if (data.Length <= MaxMessageSize)
		{
			if (clients.TryGetValue(connectionId, out var value))
			{
				value.sendQueue.Enqueue(data);
				value.sendPending.Set();
				return true;
			}
			Logger.Log("Server.Send: invalid connectionId: " + connectionId);
			return false;
		}
		Logger.LogError("Client.Send: message too big: " + data.Length + ". Limit: " + MaxMessageSize);
		return false;
	}

	public string GetClientAddress(int connectionId)
	{
		if (clients.TryGetValue(connectionId, out var value))
		{
			return ((IPEndPoint)value.client.Client.RemoteEndPoint).Address.ToString();
		}
		return "";
	}

	public bool Disconnect(int connectionId)
	{
		if (clients.TryGetValue(connectionId, out var value))
		{
			value.client.Close();
			Logger.Log("Server.Disconnect connectionId:" + connectionId);
			return true;
		}
		return false;
	}
}
