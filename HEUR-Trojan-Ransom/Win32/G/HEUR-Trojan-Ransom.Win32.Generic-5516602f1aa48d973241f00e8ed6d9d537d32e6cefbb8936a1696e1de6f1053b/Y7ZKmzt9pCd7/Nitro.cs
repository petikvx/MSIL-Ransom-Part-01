using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Y7ZKmzt9pCd7;

internal class Nitro
{
	private static Logs logging = new Logs("DEBUG", 0);

	public static bool Check(string code)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		HttpClient val = new HttpClient();
		try
		{
			string text = "https://discord.com/api/v8/entitlements/gift-codes/" + code + "?with_application=true&with_subscription_plan=true";
			logging.Debug(text);
			Task<HttpResponseMessage> async = val.GetAsync(text);
			if (async.Result.get_StatusCode() != HttpStatusCode.NotFound)
			{
				return true;
			}
			return false;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
