using System;

namespace PenterWare.Network.Clients;

internal abstract class Client
{
	public string ServerAddress { get; set; }

	public int ServerPort { get; set; }

	protected Client(string serverAddress, int serverPort)
	{
		ServerAddress = serverAddress;
		ServerPort = serverPort;
	}

	public static Client ClientFactory(string serverIP, int serverPort, string clientType)
	{
		if (!(clientType == "HTTP"))
		{
			if (!(clientType == "TCP"))
			{
				throw new Exception($"No Client of type {clientType}");
			}
			return new TCPClient(serverIP, serverPort);
		}
		return new HTTPClient(serverIP, serverPort);
	}

	public abstract void InitConnection();

	public abstract int Send(string data);

	public abstract string Recieve(int timeoutMicroseconds = -1);

	public abstract void Close();
}
