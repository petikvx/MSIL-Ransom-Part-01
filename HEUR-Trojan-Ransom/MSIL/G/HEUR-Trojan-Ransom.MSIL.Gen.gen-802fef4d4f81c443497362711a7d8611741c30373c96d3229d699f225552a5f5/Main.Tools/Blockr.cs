using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Main.Tools;

internal static class Blockr
{
	private static string BlockrAddress = "http://btc.blockr.io/api/v1/";

	internal static double GetPrice()
	{
		string address = BlockrAddress + "coin/info/";
		JObject val = JObject.Parse(new WebClient().DownloadString(address));
		JToken val2 = val.get_Item("status");
		if (val2 != null && ((object)val2).ToString() == "error")
		{
			throw new Exception(((object)val).ToString());
		}
		return val.get_Item("data").get_Item((object)"markets").get_Item((object)"coinbase")
			.Value<double>((object)"value");
	}

	internal static double GetBalanceBtc(string address)
	{
		string address2 = BlockrAddress + "address/balance/" + address;
		JObject val = JObject.Parse(new WebClient().DownloadString(address2));
		JToken val2 = val.get_Item("status");
		if (val2 != null && ((object)val2).ToString() == "error")
		{
			throw new Exception(((object)val).ToString());
		}
		return val.get_Item("data").Value<double>((object)"balance");
	}
}
