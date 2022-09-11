using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ns0;

internal static class Class5
{
	private static string string_0 = "http://btc.blockr.io/api/v1/";

	internal static double smethod_0()
	{
		string address = string_0 + "coin/info/";
		JObject val = JObject.Parse(new WebClient().DownloadString(address));
		JToken val2 = val.get_Item("status");
		if (val2 != null && ((object)val2).ToString() == "error")
		{
			throw new Exception(((object)val).ToString());
		}
		return val.get_Item("data").get_Item((object)"markets").get_Item((object)"coinbase")
			.Value<double>((object)"value");
	}

	internal static double smethod_1(string string_1)
	{
		string address = string_0 + "address/balance/" + string_1;
		JObject val = JObject.Parse(new WebClient().DownloadString(address));
		JToken val2 = val.get_Item("status");
		if (val2 != null && ((object)val2).ToString() == "error")
		{
			throw new Exception(((object)val).ToString());
		}
		return val.get_Item("data").Value<double>((object)"balance");
	}
}
