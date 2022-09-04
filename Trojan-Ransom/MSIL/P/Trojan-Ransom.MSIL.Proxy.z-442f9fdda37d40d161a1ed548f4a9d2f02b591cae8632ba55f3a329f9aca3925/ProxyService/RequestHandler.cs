using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ProxyService;

public class RequestHandler
{
	private readonly Socket _serverSocket;

	public RequestHandler(Socket serverSocket)
	{
		_serverSocket = serverSocket;
	}

	public void Handle()
	{
		string header = GetHeader(_serverSocket);
		string hostNameOrAddress = AnalyzeHeader(header);
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		IPAddress[] hostAddresses = Dns.GetHostAddresses(hostNameOrAddress);
		IPEndPoint remoteEP = new IPEndPoint(hostAddresses[0], 80);
		socket.Connect(remoteEP);
		SendRequest(socket, header);
		header = GetHeader(socket);
		if (!string.IsNullOrEmpty(header))
		{
			SendRequest(_serverSocket, header);
			byte[] buffer = new byte[1024];
			int num = socket.Receive(buffer);
			while (num > 0)
			{
				try
				{
					_serverSocket.Send(buffer, num, SocketFlags.None);
					num = socket.Receive(buffer);
				}
				catch (Exception ex)
				{
					ProxyServer.dbg("Handler:" + ex.Message);
				}
			}
		}
		_serverSocket.Shutdown(SocketShutdown.Both);
		_serverSocket.Close();
	}

	public string GetHeader(Socket socket)
	{
		string text = "";
		while (true)
		{
			try
			{
				while (true)
				{
					byte[] array = new byte[1];
					int count = socket.Receive(array);
					text += Encoding.ASCII.GetString(array, 0, count);
					if (text.IndexOf("\r\n\r\n", StringComparison.Ordinal) <= -1)
					{
						if (text.IndexOf("\n\n", StringComparison.Ordinal) <= -1)
						{
							continue;
						}
						return text;
					}
					break;
				}
				return text;
			}
			catch (Exception ex)
			{
				ProxyServer.dbg("GetHeader: " + ex.Message);
			}
		}
	}

	public string AnalyzeHeader(string header)
	{
		string result = "";
		string[] array = header.Split(new char[1] { '\n' });
		for (int i = 1; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(new char[1] { ':' });
			if (array2.Length >= 2 && array2[0].Trim().ToLower().Equals("host"))
			{
				result = array2[1].Trim();
			}
		}
		return result;
	}

	public void SendRequest(Socket socket, string header)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(header);
		socket.Send(bytes, bytes.Length, SocketFlags.None);
	}
}
