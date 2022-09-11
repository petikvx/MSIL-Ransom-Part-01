using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Storage.Basic;

public class RequestToken : TokenBase
{
	public bool AccessDenied { get; set; }

	public bool UsedUp { get; set; }

	public AccessToken AccessToken { get; set; }

	public string CallbackUrl { get; set; }

	public string Verifier { get; set; }

	public override string ToString()
	{
		string text = base.ToString();
		return text + "&oauth_callback_confirmed=true";
	}
}
