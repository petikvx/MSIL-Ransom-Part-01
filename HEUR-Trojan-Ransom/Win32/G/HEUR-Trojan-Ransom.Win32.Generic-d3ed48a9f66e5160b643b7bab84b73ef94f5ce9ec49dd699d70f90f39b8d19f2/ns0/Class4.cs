using Newtonsoft.Json.Linq;

namespace ns0;

internal static class Class4
{
	private static string String_0 => "http://btc.blockr.io/api/v1/";

	internal static double smethod_0()
	{
		string string_ = Delegate173.smethod_0(String_0, "coin/info/");
		JObject object_ = Delegate46.smethod_0(Delegate8.smethod_0(Delegate72.smethod_0(), string_));
		JToken val = Delegate184.smethod_0(object_, "status");
		if (val != null && Delegate143.smethod_0(Delegate55.smethod_0(val), "error"))
		{
			throw Delegate240.smethod_0(Delegate55.smethod_0(object_));
		}
		return Delegate175.smethod_0(Delegate175.smethod_0(Delegate184.smethod_0(object_, "data"), "markets"), "coinbase").Value<double>((object)"value");
	}

	internal static double smethod_1(string string_0)
	{
		string string_ = Delegate113.smethod_0(String_0, "address/balance/", string_0);
		JObject object_ = Delegate46.smethod_0(Delegate8.smethod_0(Delegate72.smethod_0(), string_));
		JToken val = Delegate184.smethod_0(object_, "status");
		if (val != null && Delegate143.smethod_0(Delegate55.smethod_0(val), "error"))
		{
			throw Delegate240.smethod_0(Delegate55.smethod_0(object_));
		}
		return Delegate184.smethod_0(object_, "data").Value<double>((object)"balance");
	}
}
