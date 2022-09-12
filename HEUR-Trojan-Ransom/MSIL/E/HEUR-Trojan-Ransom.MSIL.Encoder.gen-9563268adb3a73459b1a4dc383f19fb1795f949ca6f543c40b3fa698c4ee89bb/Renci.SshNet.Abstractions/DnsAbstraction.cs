using System.Net;

namespace Renci.SshNet.Abstractions;

internal static class DnsAbstraction
{
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress)
	{
		return Dns.GetHostAddresses(hostNameOrAddress);
	}
}
