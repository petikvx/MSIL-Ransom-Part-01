using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

public static class GClass3
{
	private static ManualResetEvent manualResetEvent_0;

	private static EventHandler<GEventArgs0> eventHandler_0;

	private static EventHandler<GEventArgs0> eventHandler_1;

	private static EventHandler<UnhandledExceptionEventArgs> eventHandler_2;

	private static TextWriter textWriter_0;

	private static List<Interface0> list_0;

	private static bool bool_0;

	[CompilerGenerated]
	private static EventHandler<GEventArgs0> eventHandler_3;

	[CompilerGenerated]
	private static EventHandler<GEventArgs0> eventHandler_4;

	[CompilerGenerated]
	private static ThreadStart threadStart_0;

	public static event EventHandler<GEventArgs0> Event_0
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

	public static event EventHandler<GEventArgs0> Event_1
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

	public static event EventHandler<UnhandledExceptionEventArgs> Event_2
	{
		add
		{
			EventHandler<UnhandledExceptionEventArgs> eventHandler = eventHandler_2;
			EventHandler<UnhandledExceptionEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<UnhandledExceptionEventArgs> value2 = (EventHandler<UnhandledExceptionEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<UnhandledExceptionEventArgs> eventHandler = eventHandler_2;
			EventHandler<UnhandledExceptionEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<UnhandledExceptionEventArgs> value2 = (EventHandler<UnhandledExceptionEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[SpecialName]
	public static TextWriter smethod_0()
	{
		return textWriter_0;
	}

	[SpecialName]
	public static void smethod_1(TextWriter textWriter_1)
	{
		textWriter_0 = textWriter_1;
	}

	[SpecialName]
	public static bool smethod_2()
	{
		return bool_0;
	}

	[SpecialName]
	public static void smethod_3(bool bool_1)
	{
		bool_0 = bool_1;
	}

	static GClass3()
	{
		Class51.smethod_0();
		manualResetEvent_0 = new ManualResetEvent(initialState: false);
		list_0 = new List<Interface0>();
		list_0.Add(Class32.smethod_0());
		list_0.Add(Class28.smethod_0());
		foreach (Interface0 item in list_0)
		{
			item.DeviceFound += delegate(object sender, GEventArgs0 e)
			{
				if (eventHandler_0 != null)
				{
					eventHandler_0(sender, e);
				}
			};
			item.DeviceLost += delegate(object sender, GEventArgs0 e)
			{
				if (eventHandler_1 != null)
				{
					eventHandler_1(sender, e);
				}
			};
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			smethod_5();
		});
		thread.IsBackground = true;
		thread.Start();
	}

	internal static void smethod_4(string string_0, params object[] args)
	{
		textWriter_0?.WriteLine(string_0, args);
	}

	private static void smethod_5()
	{
		while (true)
		{
			manualResetEvent_0.WaitOne();
			try
			{
				smethod_6(Class32.smethod_0(), Class32.list_0);
				smethod_6(Class28.smethod_0(), Class28.list_0);
				foreach (Interface0 item in list_0)
				{
					if (item.imethod_2() < DateTime.Now)
					{
						item.imethod_0();
					}
				}
			}
			catch (Exception exception)
			{
				if (eventHandler_2 != null)
				{
					eventHandler_2(typeof(GClass3), new UnhandledExceptionEventArgs(exception, isTerminating: false));
				}
			}
			Thread.Sleep(10);
		}
	}

	private static void smethod_6(Interface0 interface0_0, List<UdpClient> clients)
	{
		IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("192.168.0.1"), 5351);
		foreach (UdpClient client in clients)
		{
			if (client.Available > 0)
			{
				IPAddress address = ((IPEndPoint)client.Client.LocalEndPoint).Address;
				byte[] byte_ = client.Receive(ref remoteEP);
				interface0_0.imethod_1(address, byte_, remoteEP);
			}
		}
	}

	public static void smethod_7()
	{
		manualResetEvent_0.Set();
	}

	public static void smethod_8()
	{
		manualResetEvent_0.Reset();
	}

	[Obsolete("This method serves no purpose and shouldn't be used")]
	public static IPAddress[] smethod_9(bool bool_1)
	{
		List<IPAddress> list = new List<IPAddress>();
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		IPAddress[] addressList = hostEntry.AddressList;
		foreach (IPAddress iPAddress in addressList)
		{
			if (iPAddress.AddressFamily == AddressFamily.InterNetwork || (bool_1 && iPAddress.AddressFamily == AddressFamily.InterNetworkV6))
			{
				list.Add(iPAddress);
			}
		}
		return list.ToArray();
	}

	public static bool smethod_10(IPAddress ipaddress_0)
	{
		byte[] addressBytes = ipaddress_0.GetAddressBytes();
		return addressBytes[0] switch
		{
			192 => addressBytes[1] == 168, 
			172 => (addressBytes[1] & 0x10) != 0, 
			10 => true, 
			_ => false, 
		};
	}

	[CompilerGenerated]
	private static void smethod_11(object sender, GEventArgs0 e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(sender, e);
		}
	}

	[CompilerGenerated]
	private static void smethod_12(object sender, GEventArgs0 e)
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(sender, e);
		}
	}

	[CompilerGenerated]
	private static void smethod_13()
	{
		smethod_5();
	}
}
