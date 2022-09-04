using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

internal class Class32 : Interface0
{
	private static Class32 class32_0;

	public static List<UdpClient> list_0;

	private EventHandler<GEventArgs0> eventHandler_0;

	private EventHandler<GEventArgs0> eventHandler_1;

	private List<GInterface0> list_1;

	private Dictionary<IPAddress, DateTime> dictionary_0;

	private DateTime dateTime_0;

	private IPEndPoint ipendPoint_0;

	public event EventHandler<GEventArgs0> DeviceFound
	{
		add
		{
			EventHandler<GEventArgs0> eventHandler = eventHandler_0;
			EventHandler<GEventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs0> value2 = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<GEventArgs0> eventHandler = eventHandler_0;
			EventHandler<GEventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs0> value2 = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<GEventArgs0> DeviceLost
	{
		add
		{
			EventHandler<GEventArgs0> eventHandler = eventHandler_1;
			EventHandler<GEventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs0> value2 = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<GEventArgs0> eventHandler = eventHandler_1;
			EventHandler<GEventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs0> value2 = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[SpecialName]
	public static Class32 smethod_0()
	{
		return class32_0;
	}

	private Class32()
	{
		Class51.smethod_0();
		base._002Ector();
		list_1 = new List<GInterface0>();
		dictionary_0 = new Dictionary<IPAddress, DateTime>();
		ipendPoint_0 = new IPEndPoint(IPAddress.Parse("239.255.255.250"), 1900);
	}

	private static List<UdpClient> smethod_1()
	{
		List<UdpClient> list = new List<UdpClient>();
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
				{
					if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork)
					{
						try
						{
							list.Add(new UdpClient(new IPEndPoint(unicastAddress.Address, 0)));
						}
						catch
						{
						}
					}
				}
			}
			return list;
		}
		catch (Exception)
		{
			list.Add(new UdpClient(0));
			return list;
		}
	}

	public void imethod_0()
	{
		foreach (UdpClient item in list_0)
		{
			try
			{
				method_0(item);
			}
			catch
			{
			}
		}
	}

	private void method_0(UdpClient udpClient_0)
	{
		dateTime_0 = DateTime.Now.AddSeconds(300.0);
		byte[] array = Class33.smethod_0();
		for (int i = 0; i < 3; i++)
		{
			udpClient_0.Send(array, array.Length, ipendPoint_0);
		}
	}

	[SpecialName]
	public IPEndPoint method_1()
	{
		return ipendPoint_0;
	}

	public void imethod_1(IPAddress ipaddress_0, byte[] byte_0, IPEndPoint ipendPoint_1)
	{
		string text = null;
		try
		{
			text = Encoding.UTF8.GetString(byte_0);
			if (GClass3.smethod_2())
			{
				GClass3.smethod_4("UPnP Response: {0}", text);
			}
			string string_ = "UPnP Response: Router advertised a '{0}' service";
			StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;
			if (text.IndexOf("urn:schemas-upnp-org:service:WANIPConnection:", StringComparison.OrdinalIgnoreCase) != -1)
			{
				GClass3.smethod_4(string_, "urn:schemas-upnp-org:service:WANIPConnection:");
			}
			else if (text.IndexOf("urn:schemas-upnp-org:device:InternetGatewayDevice:", comparisonType) != -1)
			{
				GClass3.smethod_4(string_, "urn:schemas-upnp-org:device:InternetGatewayDevice:");
			}
			else
			{
				if (text.IndexOf("urn:schemas-upnp-org:service:WANPPPConnection:", comparisonType) == -1)
				{
					return;
				}
				GClass3.smethod_4(string_, "urn:schemas-upnp-org:service:WANPPPConnection:");
			}
			GClass1 gClass = new GClass1(ipaddress_0, text, "urn:schemas-upnp-org:service:WANIPConnection:1");
			if (list_1.Contains(gClass))
			{
				list_1[list_1.IndexOf(gClass)].imethod_16(DateTime.Now);
				return;
			}
			if (dictionary_0.ContainsKey(ipendPoint_1.Address))
			{
				DateTime dateTime = dictionary_0[ipendPoint_1.Address];
				if (DateTime.Now - dateTime < TimeSpan.FromSeconds(20.0))
				{
					return;
				}
			}
			dictionary_0[ipendPoint_1.Address] = DateTime.Now;
			GClass3.smethod_4("Fetching service list: {0}", gClass.method_0());
			gClass.method_13(method_2);
		}
		catch (Exception)
		{
		}
	}

	[SpecialName]
	public DateTime imethod_2()
	{
		return dateTime_0;
	}

	private void method_2(GInterface0 ginterface0_0)
	{
		lock (list_1)
		{
			if (list_1.Contains(ginterface0_0))
			{
				return;
			}
			list_1.Add(ginterface0_0);
		}
		method_3(new GEventArgs0(ginterface0_0));
	}

	private void method_3(GEventArgs0 geventArgs0_0)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, geventArgs0_0);
		}
	}

	static Class32()
	{
		Class51.smethod_0();
		class32_0 = new Class32();
		list_0 = smethod_1();
	}
}
