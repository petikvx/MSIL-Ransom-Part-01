using System.Net;
using Newtonsoft.Json.Linq;

namespace Main.Tools;

internal static class Blockr
{
	private static string BlockrAddress = "https://block.io/api/v2/";

	internal static double GetBalanceBtc(string address)
	{
		string text = "f521-e181-c855-79ad";
		string address2 = BlockrAddress + "get_address_balance/?api_key=" + text + "&addresses=" + address;
		return JObject.Parse(new WebClient().DownloadString(address2)).get_Item("data").Value<double>((object)"pending_received_balance");
	}
}
