using System.Net.Sockets;

namespace insomnia;

internal class Class30
{
	public static bool Method1(int A_0)
	{
		try
		{
			TcpListener tcpListener = new TcpListener(A_0);
			tcpListener.Start();
			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(Class39.Field2, A_0);
			if (tcpClient.Connected)
			{
				tcpClient.Close();
				tcpListener.Stop();
				tcpListener.Server.Shutdown(SocketShutdown.Both);
				return true;
			}
			tcpClient.Close();
			tcpListener.Stop();
			tcpListener.Server.Shutdown(SocketShutdown.Both);
			return false;
		}
		catch
		{
			return false;
		}
	}
}
