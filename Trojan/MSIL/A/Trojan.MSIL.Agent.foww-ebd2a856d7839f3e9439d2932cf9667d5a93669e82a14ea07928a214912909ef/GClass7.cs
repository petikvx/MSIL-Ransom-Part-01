using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

public class GClass7
{
	private readonly Queue<GClass55> queue_0 = new Queue<GClass55>();

	public bool IsEmpty => queue_0.Count == 0;

	public GClass7(List<GClass55> hosts)
	{
		foreach (GClass55 host in hosts)
		{
			queue_0.Enqueue(host);
		}
	}

	public GClass55 method_0()
	{
		GClass55 gClass = queue_0.Dequeue();
		queue_0.Enqueue(gClass);
		gClass.IpAddress = smethod_0(gClass);
		return gClass;
	}

	private static IPAddress smethod_0(GClass55 host)
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
			case AddressFamily.InterNetworkV6:
				if (addressList.Length == 1)
				{
					return iPAddress;
				}
				break;
			case AddressFamily.InterNetwork:
				return iPAddress;
			}
		}
		return address;
	}
}
