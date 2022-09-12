using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot.Trader.TradeWebAPI;

public class TradeSession
{
	private string string_0;

	private string string_1;

	private readonly SteamWeb steamWeb_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int hCqBxeubnq;

	public TradeSession(SteamWeb steamWeb)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		steamWeb_0 = steamWeb;
		method_13();
	}

	[SpecialName]
	[CompilerGenerated]
	internal int method_0()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(int value)
	{
		int_0 = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal int method_2()
	{
		return hCqBxeubnq;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(int value)
	{
		hCqBxeubnq = value;
	}

	internal TradeStatus method_4()
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("sessionid", string_0);
		nameValueCollection.Add("logpos", string.Concat(method_0()));
		nameValueCollection.Add("version", string.Concat(method_2()));
		return JsonConvert.DeserializeObject<TradeStatus>(method_12(string_1 + "tradestatus", "POST", nameValueCollection));
	}

	internal bool method_5(string string_2)
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("sessionid", string_0);
		nameValueCollection.Add("message", string_2);
		nameValueCollection.Add("logpos", string.Concat(method_0()));
		nameValueCollection.Add("version", string.Concat(method_2()));
		dynamic val = JsonConvert.DeserializeObject(method_12(string_1 + "chat", "POST", nameValueCollection));
		return IsSuccess(val);
	}

	internal bool method_6(ulong ulong_0, int int_1, int int_2, long long_0)
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("sessionid", string_0);
		nameValueCollection.Add("appid", string.Concat(int_2));
		nameValueCollection.Add("contextid", string.Concat(long_0));
		nameValueCollection.Add("itemid", string.Concat(ulong_0));
		nameValueCollection.Add("slot", string.Concat(int_1));
		dynamic val = JsonConvert.DeserializeObject(method_12(string_1 + "additem", "POST", nameValueCollection));
		return IsSuccess(val);
	}

	internal bool method_7(ulong ulong_0, int int_1, int int_2, long long_0)
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("sessionid", string_0);
		nameValueCollection.Add("appid", string.Concat(int_2));
		nameValueCollection.Add("contextid", string.Concat(long_0));
		nameValueCollection.Add("itemid", string.Concat(ulong_0));
		nameValueCollection.Add("slot", string.Concat(int_1));
		dynamic val = JsonConvert.DeserializeObject(method_12(string_1 + "removeitem", "POST", nameValueCollection));
		return IsSuccess(val);
	}

	internal bool method_8(bool bool_0)
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("sessionid", string_0);
		nameValueCollection.Add("ready", bool_0 ? "true" : "false");
		nameValueCollection.Add("version", string.Concat(method_2()));
		dynamic val = JsonConvert.DeserializeObject(method_12(string_1 + "toggleready", "POST", nameValueCollection));
		return IsSuccess(val);
	}

	internal bool method_9()
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("sessionid", string_0);
		nameValueCollection.Add("version", string.Concat(method_2()));
		dynamic val = JsonConvert.DeserializeObject(method_12(string_1 + "confirm", "POST", nameValueCollection));
		return IsSuccess(val);
	}

	internal bool method_10()
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("sessionid", string_0);
		dynamic val = JsonConvert.DeserializeObject(method_12(string_1 + "cancel", "POST", nameValueCollection));
		return IsSuccess(val);
	}

	private bool method_11(dynamic json)
	{
		if (json == null)
		{
			return false;
		}
		try
		{
			return json.success == "true" || (json.results != null && json.results.success == "11");
		}
		catch (Exception)
		{
			return false;
		}
	}

	private string method_12(string string_2, string string_3, NameValueCollection nameValueCollection_0 = null)
	{
		return steamWeb_0.Fetch(string_2, string_3, nameValueCollection_0);
	}

	private void method_13()
	{
		string_0 = Uri.UnescapeDataString(steamWeb_0.SessionId);
		method_3(1);
	}
}
