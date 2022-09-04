using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

internal class Class28 : Interface0
{
	private static Class28 class28_0;

	public static List<UdpClient> list_0;

	private static Dictionary<UdpClient, List<IPEndPoint>> dictionary_0;

	private int int_0;

	private DateTime dateTime_0;

	private EventHandler<GEventArgs0> eventHandler_0;

	private EventHandler<GEventArgs0> eventHandler_1;

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
	public static Class28 smethod_0()
	{
		return class28_0;
	}

	static Class28()
	{
		Class51.smethod_0();
		class28_0 = new Class28();
		smethod_1();
	}

	private Class28()
	{
		Class51.smethod_0();
		base._002Ector();
		int_0 = 250;
	}

	private static void smethod_1()
	{
		list_0 = new List<UdpClient>();
		dictionary_0 = new Dictionary<UdpClient, List<IPEndPoint>>();
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				IPInterfaceProperties iPProperties = networkInterface.GetIPProperties();
				List<IPEndPoint> list = new List<IPEndPoint>();
				foreach (GatewayIPAddressInformation gatewayAddress in iPProperties.GatewayAddresses)
				{
					if (gatewayAddress.Address.AddressFamily == AddressFamily.InterNetwork)
					{
						list.Add(new IPEndPoint(gatewayAddress.Address, 5351));
					}
				}
				if (list.Count <= 0)
				{
					continue;
				}
				foreach (UnicastIPAddressInformation unicastAddress in iPProperties.UnicastAddresses)
				{
					if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork)
					{
						UdpClient udpClient;
						try
						{
							udpClient = new UdpClient(new IPEndPoint(unicastAddress.Address, 0));
						}
						catch (SocketException)
						{
							continue;
						}
						dictionary_0.Add(udpClient, list);
						list_0.Add(udpClient);
					}
				}
			}
		}
		catch (Exception)
		{
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
		dateTime_0 = DateTime.Now.AddMilliseconds(int_0);
		int_0 *= 2;
		if (int_0 == 128000)
		{
			int_0 = 250;
			dateTime_0 = DateTime.Now.AddMinutes(10.0);
			return;
		}
		byte[] array = new byte[2];
		byte[] array2 = array;
		foreach (IPEndPoint item in dictionary_0[udpClient_0])
		{
			udpClient_0.Send(array2, array2.Length, item);
		}
	}

	private bool method_1(IPAddress ipaddress_0)
	{
		foreach (List<IPEndPoint> value in dictionary_0.Values)
		{
			foreach (IPEndPoint item in value)
			{
				if (item.Address.Equals(ipaddress_0))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void imethod_1(IPAddress ipaddress_0, byte[] byte_0, IPEndPoint ipendPoint_0)
	{
		if (method_1(ipendPoint_0.Address) && byte_0.Length == 12 && byte_0[0] == 0 && byte_0[1] == 128)
		{
			int num = IPAddress.NetworkToHostOrder(BitConverter.ToInt16(byte_0, 2));
			if (num != 0)
			{
				GClass3.smethod_4("Non zero error: {0}", num);
			}
			IPAddress ipaddress_ = new IPAddress(new byte[4]
			{
				byte_0[8],
				byte_0[9],
				byte_0[10],
				byte_0[11]
			});
			dateTime_0 = DateTime.Now.AddMinutes(5.0);
			int_0 = 250;
			method_2(new GEventArgs0(new Class23(ipendPoint_0.Address, ipaddress_)));
		}
	}

	[SpecialName]
	public DateTime imethod_2()
	{
		return dateTime_0;
	}

	private void method_2(GEventArgs0 geventArgs0_0)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, geventArgs0_0);
		}
	}
}
