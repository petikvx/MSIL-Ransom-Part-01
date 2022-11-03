using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using PenterWare.Utils;

namespace PenterWare.Network.Clients;

internal class TCPClient : Client
{
	protected static int MAX_RETRY_ATTEMPTS = 5;

	protected static int POLL_WAIT_MICROS = 100000;

	protected static int LINGER_TIMEOUT_SECONDS = 5;

	public Socket ClientSocket { get; set; }

	public IPAddress ServerIP { get; set; }

	public TCPClient(string serverIp, int serverPort)
		: base(serverIp, serverPort)
	{
		ServerIP = IPAddress.Parse(serverIp);
		ClientSocket = new Socket(IPAddress.Any.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
	}

	public override void InitConnection()
	{
		int num = 0;
		bool flag = false;
		while (!flag && num < MAX_RETRY_ATTEMPTS)
		{
			num++;
			try
			{
				ClientSocket.Connect(ServerIP, base.ServerPort);
				flag = ClientSocket.Connected;
			}
			catch (Exception ex)
			{
				GeneralUtils.Log($"Exception encountered - {ex.Message}, {MAX_RETRY_ATTEMPTS - num} retries left");
				Thread.Sleep(LINGER_TIMEOUT_SECONDS * 1000);
			}
		}
		string text = (flag ? "Success" : "Fail");
		GeneralUtils.Log("InitConnection " + text);
	}

	public override int Send(string data)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(data);
		return ClientSocket.Send(bytes);
	}

	public override string Recieve(int timeoutMicroseconds = -1)
	{
		List<byte> list = new List<byte>();
		try
		{
			bool flag = ClientSocket.Poll(timeoutMicroseconds, SelectMode.SelectRead);
			bool flag2 = ClientSocket.Available != 0;
			while (flag && flag2)
			{
				byte[] array = new byte[ClientSocket.Available];
				ClientSocket.Receive(array, ClientSocket.Available, SocketFlags.None);
				list.AddRange(array);
				flag = ClientSocket.Poll(POLL_WAIT_MICROS, SelectMode.SelectRead);
				flag2 = ClientSocket.Available != 0;
			}
		}
		catch (Exception ex)
		{
			GeneralUtils.Log("Exception occured while receiving data: " + ex.Message);
		}
		GeneralUtils.Log($"Received {list.Count} bytes");
		return Encoding.UTF8.GetString(list.ToArray());
	}

	public bool IsDisconnected()
	{
		return ClientSocket.Poll(0, SelectMode.SelectRead) & (ClientSocket.Available == 0);
	}

	public override void Close()
	{
		Thread.Sleep(LINGER_TIMEOUT_SECONDS * 1000);
		ClientSocket.Shutdown(SocketShutdown.Both);
		ClientSocket.Close();
	}
}
