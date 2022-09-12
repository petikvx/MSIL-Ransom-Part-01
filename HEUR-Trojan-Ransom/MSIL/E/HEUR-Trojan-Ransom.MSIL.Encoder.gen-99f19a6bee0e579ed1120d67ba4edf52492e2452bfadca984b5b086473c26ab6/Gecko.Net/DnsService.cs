using System;
using Gecko.Interop;

namespace Gecko.Net;

public static class DnsService
{
	private static ComPtr<nsIDNSService> _dnsService;

	public static string MyHostName => nsString.Get(_dnsService.Instance.GetMyHostNameAttribute);

	static DnsService()
	{
		_dnsService = Xpcom.GetService2<nsIDNSService>("@mozilla.org/network/dns-service;1");
	}

	public static DnsRecord Resolve(string hostName, ResolveFlags flags)
	{
		if (hostName == null)
		{
			throw new ArgumentException("parameter cannot be null", "hostName");
		}
		return nsString.Pass(_dnsService.Instance.Resolve, hostName, (uint)flags).Wrap((nsIDNSRecord x) => new DnsRecord(x));
	}
}
