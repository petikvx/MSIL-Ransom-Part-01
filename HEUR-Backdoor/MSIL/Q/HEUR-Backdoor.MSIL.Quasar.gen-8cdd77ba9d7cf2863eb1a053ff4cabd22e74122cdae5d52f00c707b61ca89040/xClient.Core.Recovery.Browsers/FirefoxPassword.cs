using System;

namespace xClient.Core.Recovery.Browsers;

public class FirefoxPassword
{
	public string Username { get; set; }

	public string Password { get; set; }

	public Uri Host { get; set; }

	public override string ToString()
	{
		return string.Format("User: {0}{3}Pass: {1}{3}Host: {2}", Username, Password, Host.Host, Environment.NewLine);
	}
}
