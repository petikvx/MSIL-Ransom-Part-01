using System.Collections.Generic;
using Discord;
using Discord.Webhook;

namespace YullySpoofer;

internal class OnlineErrorReport
{
	private static DiscordWebhookClient client;

	static OnlineErrorReport()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		client = new DiscordWebhookClient(Program.KeyAuthApp.var("WEBHOOK"));
	}

	public static void SendException(string Exception, bool Severe)
	{
		if (Severe)
		{
			SendRequest(Exception);
		}
	}

	private static void SendRequest(string Exception)
	{
		client.SendMessageAsync(Exception, false, (IEnumerable<Embed>)null, (string)null, (string)null, (RequestOptions)null, (AllowedMentions)null, (MessageComponent)null, (MessageFlags)0, (ulong?)null);
	}
}
