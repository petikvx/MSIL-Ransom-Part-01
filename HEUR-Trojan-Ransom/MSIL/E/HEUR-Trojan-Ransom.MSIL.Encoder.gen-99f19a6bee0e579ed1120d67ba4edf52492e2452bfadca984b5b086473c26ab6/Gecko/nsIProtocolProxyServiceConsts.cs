namespace Gecko;

public class nsIProtocolProxyServiceConsts
{
	public const ulong RESOLVE_PREFER_SOCKS_PROXY = 2uL;

	public const ulong RESOLVE_IGNORE_URI_SCHEME = 4uL;

	public const ulong RESOLVE_PREFER_HTTPS_PROXY = 12uL;

	public const ulong RESOLVE_ALWAYS_TUNNEL = 16uL;

	public const ulong PROXYCONFIG_DIRECT = 0uL;

	public const ulong PROXYCONFIG_MANUAL = 1uL;

	public const ulong PROXYCONFIG_PAC = 2uL;

	public const ulong PROXYCONFIG_WPAD = 4uL;

	public const ulong PROXYCONFIG_SYSTEM = 5uL;
}
