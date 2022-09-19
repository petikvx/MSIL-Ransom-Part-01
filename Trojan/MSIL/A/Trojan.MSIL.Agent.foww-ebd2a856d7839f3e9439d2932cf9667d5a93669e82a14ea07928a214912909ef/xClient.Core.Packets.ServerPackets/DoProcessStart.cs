using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoProcessStart : GInterface4
{
	public string Processname { get; set; }

	public DoProcessStart()
	{
	}

	public DoProcessStart(string processname)
	{
		Processname = processname;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
