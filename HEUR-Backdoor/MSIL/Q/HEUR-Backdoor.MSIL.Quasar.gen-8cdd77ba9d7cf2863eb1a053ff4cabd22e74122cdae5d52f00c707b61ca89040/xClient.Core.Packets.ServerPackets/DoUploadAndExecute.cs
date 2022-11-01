using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoUploadAndExecute : IPacket
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

	public void Execute(Client client)
	{
		client.SendBlocking(this);
	}
}
