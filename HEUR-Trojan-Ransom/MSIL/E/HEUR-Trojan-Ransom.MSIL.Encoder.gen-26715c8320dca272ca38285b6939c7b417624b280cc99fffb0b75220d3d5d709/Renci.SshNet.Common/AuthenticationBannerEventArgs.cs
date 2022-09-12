namespace Renci.SshNet.Common;

public class AuthenticationBannerEventArgs : AuthenticationEventArgs
{
	public string BannerMessage { get; private set; }

	public string Language { get; private set; }

	public AuthenticationBannerEventArgs(string username, string message, string language)
		: base(username)
	{
		BannerMessage = message;
		Language = language;
	}
}
