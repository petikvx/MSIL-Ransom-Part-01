using System;
using System.Collections.Specialized;
using System.Net;

public class MGR : IDisposable
{
	private readonly WebClient dWebClient;

	private static NameValueCollection discordValues = new NameValueCollection();

	public string WebHook { get; set; }

	public string UserName { get; set; }

	public string ProfilePicture { get; set; }

	public MGR()
	{
		dWebClient = new WebClient();
	}

	public void SendMessage(string msgSend)
	{
		discordValues.Set("username", UserName);
		discordValues.Set("avatar_url", ProfilePicture);
		discordValues.Set("content", msgSend);
		dWebClient.UploadValues(WebHook, discordValues);
	}

	public void Dispose()
	{
		dWebClient.Dispose();
	}
}
