using System.IO;
using System.Net.Sockets;

namespace WinTro_3_Client;

internal class FileTransfer
{
	public static string file;

	public static long FileSize;

	public TcpClient TCPClient;

	public NetworkStream Stream;

	public Client Client;

	public string IP;

	public int Port;

	public FileTransfer(string ip, int port, string _file, Client client)
	{
		IP = ip;
		Port = port;
		file = _file;
		Client = client;
	}

	public void Connect()
	{
		TCPClient = new TcpClient();
		TCPClient.Connect(IP, Port);
		Stream = TCPClient.GetStream();
		TCPClient.SendBufferSize = (int)FileSize;
		SendFile();
	}

	public void SendFile()
	{
		FileStream fileStream = File.OpenRead(file);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, (int)fileStream.Length);
		Stream.Write(array, 0, array.Length);
		fileStream.Close();
		fileStream.Dispose();
	}
}
