using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

internal class m_inliningDepth
{
	private static CancelAsync InternalAssembly = new CancelAsync("DEBUG", 0);

	public static bool MaxMachineNameLength(string string_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		HttpClient val = new HttpClient();
		try
		{
			string text = "https://discord.com/api/v8/entitlements/gift-codes/" + string_0 + "?with_application=true&with_subscription_plan=true";
			InternalAssembly.Cancel(text);
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
