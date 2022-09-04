using System.Net.Sockets;

internal sealed class Class6
{
	public static bool smethod_0(int int_0)
	{
		try
		{
			TcpListener tcpListener = new TcpListener(int_0);
			tcpListener.Start();
			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(Class0.smethod_4(), int_0);
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
