using Newtonsoft.Json.Linq;

namespace ns0;

internal static class Class4
{
	private static string String_0 => "http://btc.blockr.io/api/v1/";

	internal static double smethod_0()
	{
		string string_ = Delegate117.smethod_0(String_0, "coin/info/");
		JObject object_ = Delegate168.smethod_0(Delegate227.smethod_0(Delegate204.smethod_0(), string_));
		JToken val = Delegate111.smethod_0(object_, "status");
		if (val != null && Delegate94.smethod_0(Delegate136.smethod_0(val), "error"))
		{
			throw Delegate103.smethod_0(Delegate136.smethod_0(object_));
		}
		return Delegate38.smethod_0(Delegate38.smethod_0(Delegate111.smethod_0(object_, "data"), "markets"), "coinbase").Value<double>((object)"value");
	}

	internal static double smethod_1(string string_0)
	{
		string string_ = Delegate237.smethod_0(String_0, "address/balance/", string_0);
		JObject object_ = Delegate168.smethod_0(Delegate227.smethod_0(Delegate204.smethod_0(), string_));
		JToken val = Delegate111.smethod_0(object_, "status");
		if (val != null && Delegate94.smethod_0(Delegate136.smethod_0(val), "error"))
		{
			throw Delegate103.smethod_0(Delegate136.smethod_0(object_));
		}
		return Delegate111.smethod_0(object_, "data").Value<double>((object)"balance");
	}
}
