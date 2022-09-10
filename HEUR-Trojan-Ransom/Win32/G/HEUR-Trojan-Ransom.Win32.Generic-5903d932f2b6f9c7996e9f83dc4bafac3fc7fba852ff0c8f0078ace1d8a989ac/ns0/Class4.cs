using Newtonsoft.Json.Linq;

namespace ns0;

internal static class Class4
{
	private static string String_0 => "http://btc.blockr.io/api/v1/";

	internal static double smethod_0()
	{
		string string_ = Delegate127.smethod_0(String_0, "coin/info/");
		JObject object_ = Delegate222.smethod_0(Delegate38.smethod_0(Delegate217.smethod_0(), string_));
		JToken val = Delegate129.smethod_0(object_, "status");
		if (val != null && Delegate208.smethod_0(Delegate197.smethod_0(val), "error"))
		{
			throw Delegate68.smethod_0(Delegate197.smethod_0(object_));
		}
		return Delegate195.smethod_0(Delegate195.smethod_0(Delegate129.smethod_0(object_, "data"), "markets"), "coinbase").Value<double>((object)"value");
	}

	internal static double smethod_1(string string_0)
	{
		string string_ = Delegate240.smethod_0(String_0, "address/balance/", string_0);
		JObject object_ = Delegate222.smethod_0(Delegate38.smethod_0(Delegate217.smethod_0(), string_));
		JToken val = Delegate129.smethod_0(object_, "status");
		if (val != null && Delegate208.smethod_0(Delegate197.smethod_0(val), "error"))
		{
			throw Delegate68.smethod_0(Delegate197.smethod_0(object_));
		}
		return Delegate129.smethod_0(object_, "data").Value<double>((object)"balance");
	}
}
