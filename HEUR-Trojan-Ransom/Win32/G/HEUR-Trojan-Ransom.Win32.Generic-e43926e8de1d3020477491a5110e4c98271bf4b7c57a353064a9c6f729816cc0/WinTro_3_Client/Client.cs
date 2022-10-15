using System;
using System.Net.Sockets;
using System.Threading;
using System.Timers;

namespace WinTro_3_Client;

internal class Client
{
	public TcpClient TCPClient;

	public Data Data;

	public ComandiRicevuti Comandi;

	public string IP;

	public string Name;

	public int Port;

	public int FileTransferPort;

	public bool connected = false;

	public FileTransfer fileTransfer;

	private System.Timers.Timer timerCheckConnection = new System.Timers.Timer(30000.0);

	public Client(string ip, int port, int fileTransferPort, string clientName)
	{
		IP = ip;
		Port = port;
		Name = clientName;
		FileTransferPort = fileTransferPort;
		timerCheckConnection.Elapsed += TimerCheckConnection_Tick;
		Comandi = new ComandiRicevuti(this);
	}

	public void Connect()
	{
		while (!connected)
		{
			Debug.Log("Attemping to connect to " + IP + ":" + Port);
			try
			{
				TCPClient = new TcpClient();
				TCPClient.Connect(IP, Port);
				TCPClient.ReceiveBufferSize = 131072;
				TCPClient.SendBufferSize = 131072;
				Data = new Data(this);
				Data.StartChecking();
				connected = true;
				timerCheckConnection.Start();
				Data.Send("client|setname|" + Name);
				Data.Send("client|setversion|" + WinTro3.Info.version);
				Data.Send("client|macaddress|" + WinTro3.Info.MACAddress);
				Debug.Log("Client connected");
			}
			catch (Exception ex)
			{
				Debug.ClearLog();
				Debug.LogError("Connection failed: " + ex.Message);
				Debug.LogWarning("Waiting " + 10 + "s");
				connected = false;
				timerCheckConnection.Stop();
				Thread.Sleep(10000);
			}
		}
	}

	public void Disconnect(bool connectAgain)
	{
		Data.Send("client|disconnecting");
		Data.StopChecking();
		connected = false;
		timerCheckConnection.Stop();
		if (connectAgain)
		{
			Debug.LogWarning("Waiting " + 300 + "s...");
			Thread.Sleep(300000);
			Connect();
		}
	}

	public void TimerCheckConnection_Tick(object sender, ElapsedEventArgs e)
	{
		CheckConnection();
	}

	private void CheckConnection()
	{
		try
		{
			Data.Send("Connection check");
		}
		catch (Exception ex)
		{
			Debug.LogWarning("Connection checking failed: " + ex.Message + "\r\n ReConnecting to server...");
			connected = false;
			Connect();
			timerCheckConnection.Stop();
		}
	}
}
