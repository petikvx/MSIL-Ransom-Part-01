using System.Net;

namespace xClient.Core.Data;

public class Host
{
	public string Hostname { get; set; }

	public IPAddress IpAddress { get; set; }

	public ushort Port { get; set; }

	public override string ToString()
	{
		return Hostname + ":" + Port;
	}
}
