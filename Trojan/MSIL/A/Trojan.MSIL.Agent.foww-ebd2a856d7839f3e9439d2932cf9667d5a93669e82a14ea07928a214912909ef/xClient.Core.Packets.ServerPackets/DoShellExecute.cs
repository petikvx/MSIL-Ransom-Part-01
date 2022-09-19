using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoShellExecute : GInterface4
{
	public string Command { get; set; }

	public DoShellExecute()
	{
	}

	public DoShellExecute(string command)
	{
		Command = command;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
